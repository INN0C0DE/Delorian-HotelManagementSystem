Imports MySql.Data.MySqlClient

Public Class login_form
    'Private Sub hide_pass_Click(sender As Object, e As EventArgs)
    '    password.PasswordChar = ""
    '    hide_pass.Visible = False
    '    show_pass.Visible = True
    'End Sub

    'Private Sub show_pass_Click(sender As Object, e As EventArgs)
    '    password.PasswordChar = "*"
    '    hide_pass.Visible = True
    '    show_pass.Visible = False
    'End Sub

    Private Sub login_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'show_pass.Visible = False
        staffpwd_show.Visible = False
        adminpwd_show.Visible = False
        Login_Pages.SetPage("Staff_Login")

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub staffpwd_hide_Click(sender As Object, e As EventArgs) Handles staffpwd_hide.Click
        staff_password.PasswordChar = ""
        staffpwd_hide.Visible = False
        staffpwd_show.Visible = True
    End Sub

    Private Sub staffpwd_show_Click(sender As Object, e As EventArgs) Handles staffpwd_show.Click
        staff_password.PasswordChar = "*"
        staffpwd_hide.Visible = True
        staffpwd_show.Visible = False
    End Sub

    Private Sub ADMIN_BTN_Click(sender As Object, e As EventArgs) Handles ADMIN_BTN.Click
        Login_Pages.SetPage("Admin_Login")
        staff_username.Text = ""
        staff_password.Text = ""
        staff_username.Focus()
    End Sub

    Private Sub staff_btn_Click(sender As Object, e As EventArgs) Handles staff_btn.Click
        Login_Pages.SetPage("Staff_Login")
        admin_username.Text = ""
        admin_password.Text = ""
        admin_username.Focus()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub adminpwd_show_Click(sender As Object, e As EventArgs) Handles adminpwd_show.Click
        admin_password.PasswordChar = "*"
        adminpwd_hide.Visible = True
        adminpwd_show.Visible = False
    End Sub

    Private Sub adminpwd_hide_Click(sender As Object, e As EventArgs) Handles adminpwd_hide.Click
        admin_password.PasswordChar = ""
        adminpwd_hide.Visible = False
        adminpwd_show.Visible = True
    End Sub

    Private Sub rfid_btn_Click(sender As Object, e As EventArgs) Handles rfid_btn.Click
        admin_rfid.Show()

    End Sub

    Private Sub rfidbtn_Click(sender As Object, e As EventArgs) Handles rfidbtn.Click
        staff_rfid.Show()

    End Sub

    Private Sub admin_loginbtn_Click(sender As Object, e As EventArgs) Handles admin_loginbtn.Click
        If admin_username.Text = Nothing Or admin_password.Text = Nothing Then
            MessageBox.Show("Please specify the blank inputs.", "DELORIAN HOTEL | LOGIN STATUS:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                ' Retrieve login information from the database
                Dim connectionString As String = "server=rasc.mysql.database.azure.com;username=innocode_rasc;password=Rasc_062301;database=hms_db;"
                Dim query As String = "SELECT * FROM admin_account WHERE admin_username = @USERNAME AND admin_password = @PASSWORD"
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@USERNAME", admin_username.Text)
                        command.Parameters.AddWithValue("@PASSWORD", admin_password.Text)
                        Using reader As MySqlDataReader = command.ExecuteReader()
                            ' Check if the login information is correct
                            If reader.HasRows Then
                                MessageBox.Show("Login Successful!", "DELORIAN HOTEL | LOGIN STATUS:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                admin_username.Clear()
                                admin_password.Clear()
                                admin_dashboard.Show()
                                admin_dashboard.admin_pages.SetPage("admin_profile")
                                Me.Hide()
                            Else
                                MessageBox.Show("Invalid Username or Password!", "DELORIAN HOTEL | LOGIN STATUS:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                admin_username.Clear()
                                admin_password.Clear()
                                admin_username.Focus()

                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub staff_logintbn_Click(sender As Object, e As EventArgs) Handles staff_logintbn.Click
        If staff_username.Text = Nothing Or staff_password.Text = Nothing Then
            MessageBox.Show("Please specify the blank inputs.", "DELORIAN HOTEL | LOGIN STATUS:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                ' Retrieve login information from the database
                Dim connectionString As String = "server=rasc.mysql.database.azure.com;username=innocode_rasc;password=Rasc_062301;database=hms_db;"
                Dim query As String = "SELECT * FROM staff_account WHERE staff_username = @USERNAME AND staff_password = @PASSWORD"
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@USERNAME", staff_username.Text)
                        command.Parameters.AddWithValue("@PASSWORD", staff_password.Text)
                        Using reader As MySqlDataReader = command.ExecuteReader()
                            ' Check if the login information is correct
                            If reader.HasRows Then
                                MessageBox.Show("Login Successful!", "DELORIAN HOTEL | LOGIN STATUS:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                staff_username.Clear()
                                staff_password.Clear()
                                staff_dashboard.Show()
                                staff_dashboard.staff_pages.SetPage("rooms")
                                Me.Hide()
                            Else
                                MessageBox.Show("Invalid Username or Password!", "DELORIAN HOTEL | LOGIN STATUS:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                staff_username.Clear()
                                staff_password.Clear()
                                staff_username.Focus()

                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class