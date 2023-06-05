'Imports MySql.Data.MySqlClient
'Public Class admin_rfid

'    Private connectionString As String = "server=rasc.mysql.database.azure.com;username=innocode_rasc;password=Rasc_062301;database=hms_db;"

'    Private Sub rfid_admintb_TextChanged(sender As Object, e As EventArgs) Handles rfid_admintb.TextChanged
'        Dim cardNumber As String = rfid_admintb.Text.Trim()

'        If cardNumber.Length > 0 Then
'            If VerifyCardNumber(cardNumber) Then
'                MessageBox.Show("RFID card valid, logged in successfully", "DELORIAN HOTEL | LOGIN STATUS:", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                admin_dashboard.Show()
'                login_form.Hide()
'                Me.Close()
'            Else
'                MessageBox.Show("RFID card not valid, logged in failed!", "DELORIAN HOTEL | LOGIN STATUS:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
'                rfid_admintb.Clear()
'                rfid_admintb.Focus()
'            End If
'        End If
'    End Sub
'    Private Function VerifyCardNumber(cardNumber As String) As Boolean
'        Dim query As String = "SELECT * FROM admin_account WHERE admin_rfid = @cardNumber"
'        Using connection As New MySqlConnection(connectionString)
'            connection.Open()
'            Using command As New MySqlCommand(query, connection)
'                command.Parameters.AddWithValue("@cardNumber", cardNumber)
'                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
'                Return count > 0
'            End Using
'        End Using
'    End Function
'End Class

Imports MySql.Data.MySqlClient

Public Class admin_rfid
    Private connectionString As String = "server=rasc.mysql.database.azure.com;username=innocode_rasc;password=Rasc_062301;database=hms_db;"

    Private Sub rfid_admintb_KeyDown(sender As Object, e As KeyEventArgs) Handles rfid_admintb.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent the Enter key from adding a new line to the TextBox

            Dim cardNumber As String = rfid_admintb.Text.Trim()

            If cardNumber.Length > 0 Then
                If VerifyCardNumber(cardNumber) Then
                    MessageBox.Show("RFID card valid, logged in successfully", "DELORIAN HOTEL | LOGIN STATUS:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    admin_dashboard.Show()
                    admin_dashboard.profile_name.Text = GetAdminFullName(cardNumber) + "!" ' Set the admin name label in admin_dashboard form
                    login_form.Hide()
                    Me.Close()
                Else
                    MessageBox.Show("RFID card not valid, logged in failed!", "DELORIAN HOTEL | LOGIN STATUS:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    rfid_admintb.Clear()
                    rfid_admintb.Focus()
                End If
            End If
        End If
    End Sub

    Private Function VerifyCardNumber(cardNumber As String) As Boolean
        Dim query As String = "SELECT * FROM admin_account WHERE admin_rfid = @cardNumber"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@cardNumber", cardNumber)
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Function GetAdminFullName(cardNumber As String) As String
        Dim query As String = "SELECT admin_fullname FROM admin_account WHERE admin_rfid = @cardNumber"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@cardNumber", cardNumber)
                Dim adminFullName As Object = command.ExecuteScalar()
                If adminFullName IsNot Nothing Then
                    Return adminFullName.ToString()
                Else
                    Return String.Empty
                End If
            End Using
        End Using
    End Function
End Class

