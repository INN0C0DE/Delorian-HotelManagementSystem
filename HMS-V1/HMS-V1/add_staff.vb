Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class add_staff
    Private Sub add_staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        add_username.Focus()
        If My.Settings.MaxTextBoxLength <> 0 Then
            add_rfid.MaxLength = My.Settings.MaxTextBoxLength
        End If
    End Sub

    Private Sub BunifuDropdown1_onItemSelected(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuDropdown1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub staff_gender_onItemSelected(sender As Object, e As EventArgs)

    End Sub

    Private Sub addstaff_btn_Click(sender As Object, e As EventArgs) Handles addstaff_btn.Click
        If add_username.Text = "" Or add_pwd.Text = "" Or add_rfid.Text = "" Or add_name.Text = "" Or add_gender.Text = "" Or add_age.Text = "" Or add_email.Text = "" Or add_number.Text = "" Then
            MsgBox("Please fill up all forms needed.", vbInformation, "You forgot to fill something!")
        Else
            create("INSERT INTO staff_account (staff_username,staff_password,staff_rfid,staff_fullname,staff_gender,staff_age,staff_email,staff_number) VALUES ('" & add_username.Text & "','" & add_pwd.Text & "','" & add_rfid.Text & "','" & add_name.Text & "','" & add_gender.Text & "','" & add_age.Text & "','" & add_email.Text & "','" & add_number.Text & "')")
            'staff id removed
            'Call LOADLV()
            Me.Hide()
            admin_dashboard.LOADLV()
            Call CLEARTEXT()
        End If
    End Sub
    Public Sub CLEARTEXT()
        add_id.Clear()
        add_username.Clear()
        add_pwd.Clear()
        add_rfid.Clear()
        add_name.Clear()
        add_gender.Text = Nothing
        add_email.Clear()
        add_age.Clear()
        add_number.Clear()
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Me.Hide()
        Call CLEARTEXT()

    End Sub

    Private Sub add_rfid_TextChanged(sender As Object, e As EventArgs) Handles add_rfid.TextChanged

    End Sub

    Private Sub add_rfid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles add_rfid.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Ignore non-numeric key presses
        End If
    End Sub

    Private Sub add_number_TextChanged(sender As Object, e As EventArgs) Handles add_number.TextChanged

    End Sub

    Private Sub add_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles add_number.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Ignore non-numeric key presses
        End If
    End Sub

    Private Sub add_age_TextChanged(sender As Object, e As EventArgs) Handles add_age.TextChanged

    End Sub

    Private Sub add_age_KeyPress(sender As Object, e As KeyPressEventArgs) Handles add_age.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Ignore non-numeric key presses
        End If
    End Sub

    Private Sub add_staff_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'Saving the max length value
        My.Settings.MaxTextBoxLength = add_rfid.MaxLength
        My.Settings.Save()
    End Sub
End Class