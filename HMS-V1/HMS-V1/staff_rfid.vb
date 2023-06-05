'Imports MySql.Data.MySqlClient

'Public Class staff_rfid
'    Private connectionString As String = "server=rasc.mysql.database.azure.com;username=innocode_rasc;password=Rasc_062301;database=hms_db;"

'    Private Sub rfid_stafftb_TextChanged(sender As Object, e As EventArgs) Handles rfid_stafftb.TextChanged
'        Dim cardNumber As String = rfid_stafftb.Text.Trim()

'        If cardNumber.Length > 0 Then
'            If VerifyCardNumber(cardNumber) Then
'                MessageBox.Show("RFID card valid, logged in successfully", "DELORIAN HOTEL | LOGIN STATUS:", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                staff_dashboard.Show()
'                'NOTE: MUST ENTER THE STAFF NAME AT THE LABEL AFTER LOGIN
'                login_form.Hide()
'                Me.Close()
'            Else
'                MessageBox.Show("RFID card not valid, logged in failed!", "DELORIAN HOTEL | LOGIN STATUS:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
'                rfid_stafftb.Clear()
'                rfid_stafftb.Focus()
'            End If
'        End If
'    End Sub
'    Private Function VerifyCardNumber(cardNumber As String) As Boolean
'        Dim query As String = "SELECT * FROM staff_account WHERE staff_rfid = @cardNumber"
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
'Imports MySql.Data.MySqlClient

'Public Class staff_rfid
'    Private connectionString As String = "server=rasc.mysql.database.azure.com;username=innocode_rasc;password=Rasc_062301;database=hms_db;"

'    Private Sub rfid_stafftb_TextChanged(sender As Object, e As EventArgs) Handles rfid_stafftb.TextChanged
'        Dim cardNumber As String = rfid_stafftb.Text.Trim()

'        If cardNumber.Length > 0 Then
'            If VerifyCardNumber(cardNumber) Then
'                MessageBox.Show("RFID card valid, logged in successfully", "DELORIAN HOTEL | LOGIN STATUS:", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                staff_dashboard.Show()
'                staff_dashboard.profile_name.Text = GetStaffFullName(cardNumber) + "!" ' Set the staff name label in staff_dashboard form
'                login_form.Hide()
'                Me.Close()
'            Else
'                MessageBox.Show("RFID card not valid, logged in failed!", "DELORIAN HOTEL | LOGIN STATUS:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
'                rfid_stafftb.Clear()
'                rfid_stafftb.Focus()
'            End If
'        End If
'    End Sub

'    Private Function VerifyCardNumber(cardNumber As String) As Boolean
'        Dim query As String = "SELECT * FROM staff_account WHERE staff_rfid = @cardNumber"
'        Using connection As New MySqlConnection(connectionString)
'            connection.Open()
'            Using command As New MySqlCommand(query, connection)
'                command.Parameters.AddWithValue("@cardNumber", cardNumber)
'                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
'                Return count > 0
'            End Using
'        End Using
'    End Function

'    Private Function GetStaffFullName(cardNumber As String) As String
'        Dim query As String = "SELECT staff_fullname FROM staff_account WHERE staff_rfid = @cardNumber"
'        Using connection As New MySqlConnection(connectionString)
'            connection.Open()
'            Using command As New MySqlCommand(query, connection)
'                command.Parameters.AddWithValue("@cardNumber", cardNumber)
'                Dim staffFullName As Object = command.ExecuteScalar()
'                If staffFullName IsNot Nothing Then
'                    Return staffFullName.ToString()
'                Else
'                    Return String.Empty
'                End If
'            End Using
'        End Using
'    End Function

'    Private Sub staff_rfid_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'    End Sub
'End Class

'UPDATED RFID CODE
Imports MySql.Data.MySqlClient

Public Class staff_rfid
    Private connectionString As String = "server=rasc.mysql.database.azure.com;username=innocode_rasc;password=Rasc_062301;database=hms_db;"

    Private Sub rfid_stafftb_KeyDown(sender As Object, e As KeyEventArgs) Handles rfid_stafftb.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent the Enter key from adding a new line to the TextBox

            Dim cardNumber As String = rfid_stafftb.Text.Trim()

            If cardNumber.Length > 0 Then
                If VerifyCardNumber(cardNumber) Then
                    MessageBox.Show("RFID card valid, logged in successfully", "DELORIAN HOTEL | LOGIN STATUS:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    staff_dashboard.Show()
                    staff_dashboard.profile_name.Text = GetStaffFullName(cardNumber) + "!" ' Set the staff name label in staff_dashboard form
                    login_form.Hide()
                    Me.Close()
                Else
                    MessageBox.Show("RFID card not valid, logged in failed!", "DELORIAN HOTEL | LOGIN STATUS:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    rfid_stafftb.Clear()
                    rfid_stafftb.Focus()
                End If
            End If
        End If
    End Sub

    Private Function VerifyCardNumber(cardNumber As String) As Boolean
        Dim query As String = "SELECT * FROM staff_account WHERE staff_rfid = @cardNumber"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@cardNumber", cardNumber)
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Function GetStaffFullName(cardNumber As String) As String
        Dim query As String = "SELECT staff_fullname FROM staff_account WHERE staff_rfid = @cardNumber"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@cardNumber", cardNumber)
                Dim staffFullName As Object = command.ExecuteScalar()
                If staffFullName IsNot Nothing Then
                    Return staffFullName.ToString()
                Else
                    Return String.Empty
                End If
            End Using
        End Using
    End Function

    Private Sub staff_rfid_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
