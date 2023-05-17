Imports MySql.Data.MySqlClient
Public Class update_staff
    Private Sub updatestaff_btn_Click(sender As Object, e As EventArgs) Handles updatestaff_btn.Click
        Try
            'updates("UPDATE staff_account SET firstname='" & firstname.Text & "', lastname='" & lastname.Text & "', age='" & age.Text & "' WHERE staff_id='" & update_id.Text & "'")
            updates("UPDATE staff_account SET staff_id='" & update_id.Text & "', staff_username='" & update_username.Text & "', staff_password='" & update_pwd.Text & "', staff_rfid='" & update_rfid.Text & "', staff_fullname='" & update_name.Text & "', staff_gender='" & update_gender.Text & "', staff_age='" & update_age.Text & "', staff_email='" & update_email.Text & "', staff_number='" & update_number.Text & "' WHERE staff_id='" & update_id.Text & "'")
            admin_dashboard.LOADLV()
            Me.Hide()


            Call CLEARTEXT()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub CLEARTEXT()
        update_id.Clear()
        update_username.Clear()
        update_pwd.Clear()
        update_rfid.Clear()
        update_name.Clear()
        update_gender.SelectedIndex = -1
        update_email.Clear()
        update_age.Clear()
        update_number.Clear()
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Me.Hide()
        Call CLEARTEXT()
    End Sub

    Private Sub update_staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub update_rfid_TextChanged(sender As Object, e As EventArgs) Handles update_rfid.TextChanged

    End Sub

    Private Sub update_rfid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles update_rfid.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Ignore non-numeric key presses
        End If
    End Sub

    Private Sub update_number_TextChanged(sender As Object, e As EventArgs) Handles update_number.TextChanged

    End Sub

    Private Sub update_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles update_number.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Ignore non-numeric key presses
        End If
    End Sub

    Private Sub update_age_TextChanged(sender As Object, e As EventArgs) Handles update_age.TextChanged

    End Sub

    Private Sub update_age_KeyPress(sender As Object, e As KeyPressEventArgs) Handles update_age.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Ignore non-numeric key presses
        End If
    End Sub
End Class