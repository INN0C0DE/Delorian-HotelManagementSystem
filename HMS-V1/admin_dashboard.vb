Imports MySql.Data.MySqlClient
Public Class admin_dashboard
    Public Sub LOADLV()
        reload("SELECT * FROM staff_account", staff_dgv)
    End Sub
    Public Sub LOADLV2()
        reload("SELECT * FROM bookings", booking_dgv)
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        admin_pages.SetPage("admin_profile")
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        admin_pages.SetPage("admin_staffmanage")
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        admin_pages.SetPage("bookings")
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to sign out?", "SIGN-OUT STATUS:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If (result = DialogResult.Yes) Then
            login_form.Show()

            Me.Hide()
        Else
            'MessageBox.Show("SIGNING OUT CANCELLED!", "SIGN-OUT STATUS:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BunifuTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub admin_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LOADLV()
        Call LOADLV2()

        admin_pages.SetPage("admin_profile")
        'admin_gender.SelectedIndex = 0 ' Assuming Male is the first item in the ComboBox
        'If admin_gender.Text = "Male" Then
        '    admin_picture.Image = My.Resources.admin_male
        'ElseIf admin_gender.Text = "Female" Then
        '    admin_picture.Image = My.Resources.admin_female
        'End If


        'Account name display besides welcome in dashboard
        Using connection As New MySqlConnection(connectionString)
            Dim sqlQuery As String = $"SELECT admin_fullname, admin_rfid, admin_username, admin_password, admin_email, admin_gender, admin_age, admin_id FROM admin_account"

            Dim dataAdapter As New MySqlDataAdapter(sqlQuery, connection)

            Dim dataTable As New DataTable()

            Try
                connection.Open()
                dataAdapter.Fill(dataTable)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connection.Close()
            End Try

            If dataTable.Rows.Count > 0 Then
                Dim adminName As String = dataTable.Rows(0)("admin_fullname").ToString()
                profile_name.Text = adminName + "!"
                'Show admin data to the textboxes after load
                admin_name.Text = adminName
                Dim adminRFID As String = dataTable.Rows(0)("admin_rfid").ToString()
                admin_rfid.Text = adminRFID
                Dim adminUsername As String = dataTable.Rows(0)("admin_username").ToString()
                admin_username.Text = adminUsername
                Dim adminPassword As String = dataTable.Rows(0)("admin_password").ToString()
                admin_pwd.Text = adminPassword
                Dim adminEmail As String = dataTable.Rows(0)("admin_email").ToString()
                admin_email.Text = adminEmail
                Dim adminGender As String = dataTable.Rows(0)("admin_gender").ToString()
                admin_gender.Text = adminGender
                Dim adminAge As String = dataTable.Rows(0)("admin_age").ToString()
                admin_age.Text = adminAge
                Dim adminID As String = dataTable.Rows(0)("admin_id").ToString()
                admin_id.Text = adminID
            End If
        End Using
        Call SetProfilePhoto()
    End Sub
    Private connectionString As String = "server=rasc.mysql.database.azure.com;username=innocode_rasc;password=Rasc_062301;database=hms_db;"

    'Private Sub staff_search_TextChanged(sender As Object, e As EventArgs) Handles staff_search.TextChanged
    '    'REALTIME SEARCHBAR CODES
    '    Dim query As String = "SELECT * FROM staff_account WHERE staff_fullname LIKE '%" + staff_search.Text + "%' OR staff_rfid LIKE '%" + staff_search.Text + "%'"
    '    Dim conn As String = "server=rasc.mysql.database.azure.com;username=innocode_rasc;password=Rasc_062301;database=hms_db;"

    '    Using connection As New MySqlConnection(conn)
    '        Dim cmd As New MySqlCommand(query, connection)
    '        Dim da As New MySqlDataAdapter(cmd)
    '        Dim dt As New DataTable
    '        Dim ds As New DataSet
    '        da.Fill(dt)
    '        staff_dgv.DataSource = dt
    '    End Using
    'End Sub


    'OPTIMIZED SEARCH BAR *****STARTS HERE******
    Private searchDelayTimer As Timer

    Private Sub staff_search_TextChanged(sender As Object, e As EventArgs) Handles staff_search.TextChanged
        ' Stop any previous timer
        If searchDelayTimer IsNot Nothing Then
            searchDelayTimer.Stop()
            searchDelayTimer.Dispose()
        End If

        ' Create a new timer
        searchDelayTimer = New Timer()
        searchDelayTimer.Interval = 200 ' Adjust the delay as needed (in milliseconds)
        AddHandler searchDelayTimer.Tick, AddressOf StartSearch
        searchDelayTimer.Start()
    End Sub

    Private Sub StartSearch(sender As Object, e As EventArgs)
        ' Stop the timer
        searchDelayTimer.Stop()

        ' Perform the search
        PerformSearch()
    End Sub

    Private Sub PerformSearch()
        ' Perform the actual search
        Dim query As String = "SELECT * FROM staff_account WHERE staff_fullname LIKE @searchText OR staff_rfid LIKE @searchText"
        Dim conn As String = "server=rasc.mysql.database.azure.com;username=innocode_rasc;password=Rasc_062301;database=hms_db;"

        Using connection As New MySqlConnection(conn)
            connection.Open()

            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@searchText", "%" + staff_search.Text + "%")

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            staff_dgv.DataSource = dt
        End Using
    End Sub
    'OPTIMIZED SEARCH BAR *****ENDS HERE******


    Private Sub addstaff_btn_Click(sender As Object, e As EventArgs) Handles addstaff_btn.Click
        add_staff.Show()
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub staff_updatebtn_Click(sender As Object, e As EventArgs) Handles staff_updatebtn.Click
        Try
            If staff_dgv.SelectedRows.Count > 0 Then
                With update_staff
                    .update_id.Text = staff_dgv.SelectedRows.Item(0).Cells(0).Value
                    .update_username.Text = staff_dgv.SelectedRows.Item(0).Cells(1).Value
                    .update_pwd.Text = staff_dgv.SelectedRows.Item(0).Cells(2).Value
                    .update_rfid.Text = staff_dgv.SelectedRows.Item(0).Cells(3).Value
                    .update_name.Text = staff_dgv.SelectedRows.Item(0).Cells(4).Value
                    .update_gender.Text = staff_dgv.SelectedRows.Item(0).Cells(5).Value
                    .update_age.Text = staff_dgv.SelectedRows.Item(0).Cells(6).Value
                    .update_email.Text = staff_dgv.SelectedRows.Item(0).Cells(7).Value
                    .update_number.Text = staff_dgv.SelectedRows.Item(0).Cells(8).Value
                    .ShowDialog()

                End With
            Else
                MsgBox("Please select account to edit.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub staff_deletebtn_Click(sender As Object, e As EventArgs) Handles staff_deletebtn.Click
        'Try
        '    delete("DELETE FROM staff_account WHERE staff_id='" & staff_dgv.SelectedRows.Item(0).Cells(0).Value & "'")
        '    Call LOADLV()
        '    'Call CLEARTEXT()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        'MessageBox.Show("Are you sure you want to delete the selected record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        'If DialogResult.No Then
        '    MessageBox.Show("DATA DELETITION CANCELLED!")
        'Else
        '    Try
        '        delete("DELETE FROM staff_account WHERE staff_id='" & staff_dgv.SelectedRows.Item(0).Cells(0).Value & "'")
        '        Call LOADLV()
        '        'Call CLEARTEXT()
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '    End Try
        'End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If (result = DialogResult.Yes) Then
            Try
                delete("DELETE FROM staff_account WHERE staff_id='" & staff_dgv.SelectedRows.Item(0).Cells(0).Value & "'")
                Call LOADLV()
                'Call CLEARTEXT()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("DATA DELETITION CANCELLED!", "STATUS:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub admin_updatebtn_Click(sender As Object, e As EventArgs) Handles admin_updatebtn.Click
        Try
            'updates("UPDATE admin_account SET firstname='" & firstname.Text & "', lastname='" & lastname.Text & "', age='" & age.Text & "' WHERE staff_id='" & update_id.Text & "'")
            updates("UPDATE admin_account SET admin_fullname='" & admin_name.Text & "', admin_username='" & admin_username.Text & "', admin_password='" & admin_pwd.Text & "', admin_rfid='" & admin_rfid.Text & "', admin_gender='" & admin_gender.Text & "', admin_age='" & admin_age.Text & "', admin_email='" & admin_email.Text & "' WHERE admin_id='" & admin_id.Text & "'")
            'admin_dashboard.LOADLV()

            'Call CLEARTEXT()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub chooseImage_btn_Click(sender As Object, e As EventArgs)
        'Dim openFileDialog1 As New OpenFileDialog()
        'openFileDialog1.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif"
        'openFileDialog1.Title = "Select an Image File"

        'If openFileDialog1.ShowDialog() = DialogResult.OK Then
        '    ' Display the selected image in the PictureBox
        '    admin_picture.Image = Image.FromFile(openFileDialog1.FileName)
        'End If
    End Sub

    Private Sub admin_gender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles admin_gender.SelectedIndexChanged
        SetProfilePhoto()
        'If admin_gender.SelectedItem.ToString() = "Male" Then
        '    admin_picture.Image = My.Resources.admin_male
        'ElseIf admin_gender.SelectedItem.ToString() = "Female" Then
        '    admin_picture.Image = My.Resources.admin_female
        'Else
        '    admin_picture.Image = Nothing
        'End If

    End Sub

    'Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles admin_updatebtn.Click

    'End Sub

    'Private Sub BunifuButton9_Click(sender As Object, e As EventArgs) Handles staff_deletebtn.Click

    'End Sub

    'Private Sub BunifuButton8_Click(sender As Object, e As EventArgs) Handles staff_updatebtn.Click

    'End Sub
    Private Sub SetProfilePhoto()

        If admin_gender.Text = "Male" Then
            admin_picture.Image = My.Resources.admin_male
        ElseIf admin_gender.Text = "Female" Then
            admin_picture.Image = My.Resources.admin_female
        Else
            admin_picture.Image = Nothing
        End If
    End Sub

    Private Sub admin_rfid_TextChanged(sender As Object, e As EventArgs) Handles admin_rfid.TextChanged

    End Sub

    Private Sub admin_rfid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles admin_rfid.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Ignore non-numeric key presses
        End If
    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        admin_pages.SetPage("rooms")
    End Sub

    Private Sub booking_addbtn_Click(sender As Object, e As EventArgs) Handles booking_addbtn.Click
        Try
            add_booking.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub booking_updatebtn_Click(sender As Object, e As EventArgs) Handles booking_updatebtn.Click
        Try
            If booking_dgv.SelectedRows.Count > 0 Then
                With update_booking
                    .booking_id.Text = booking_dgv.SelectedRows.Item(0).Cells(0).Value
                    .booking_firstname.Text = booking_dgv.SelectedRows.Item(0).Cells(1).Value
                    .booking_lastname.Text = booking_dgv.SelectedRows.Item(0).Cells(2).Value
                    .booking_email.Text = booking_dgv.SelectedRows.Item(0).Cells(3).Value
                    .booking_number.Text = booking_dgv.SelectedRows.Item(0).Cells(4).Value
                    .booking_address.Text = booking_dgv.SelectedRows.Item(0).Cells(5).Value
                    .booking_startdate.Value = booking_dgv.SelectedRows.Item(0).Cells(6).Value
                    .booking_enddate.Value = booking_dgv.SelectedRows.Item(0).Cells(7).Value
                    .booking_status.Text = booking_dgv.SelectedRows.Item(0).Cells(8).Value
                    .booking_roomtype.Text = booking_dgv.SelectedRows.Item(0).Cells(9).Value
                    .booking_amount.Text = booking_dgv.SelectedRows.Item(0).Cells(10).Value
                    .booking_days.Text = booking_dgv.SelectedRows.Item(0).Cells(11).Value
                    .ShowDialog()
                End With
            Else
                MessageBox.Show("Please select booking info to edit.", "BOOKING STATUS:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub booking_deletebtn_Click(sender As Object, e As EventArgs) Handles booking_deletebtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If (result = DialogResult.Yes) Then
            Try
                delete("DELETE FROM bookings WHERE booking_id='" & booking_dgv.SelectedRows.Item(0).Cells(0).Value & "'")
                Call LOADLV2()
                'Call CLEARTEXT()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("DATA DELETITION CANCELLED!", "STATUS:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    'Private Sub booking_search_TextChanged(sender As Object, e As EventArgs) Handles booking_search.TextChanged
    '    'REALTIME SEARCHBAR CODES
    '    Dim query As String = "SELECT * FROM bookings WHERE booking_firstname LIKE '%" + booking_search.Text + "%' OR booking_lastname LIKE '%" + booking_search.Text + "%'"
    '    Dim conn As String = "server=rasc.mysql.database.azure.com;username=innocode_rasc;password=Rasc_062301;database=hms_db;"

    '    Using connection As New MySqlConnection(conn)
    '        Dim cmd As New MySqlCommand(query, connection)
    '        Dim da As New MySqlDataAdapter(cmd)
    '        Dim dt As New DataTable
    '        Dim ds As New DataSet
    '        da.Fill(dt)
    '        booking_dgv.DataSource = dt
    '    End Using
    'End Sub


    'OPTIMIZED SEARCH BAR *****STARTS HERE******
    'Private searchDelayTimer As Timer

    Private Sub booking_search_TextChanged(sender As Object, e As EventArgs) Handles booking_search.TextChanged
        ' Stop any previous timer
        If searchDelayTimer IsNot Nothing Then
            searchDelayTimer.Stop()
            searchDelayTimer.Dispose()
        End If

        ' Create a new timer
        searchDelayTimer = New Timer()
        searchDelayTimer.Interval = 200 ' Adjust the delay as needed (in milliseconds)
        AddHandler searchDelayTimer.Tick, AddressOf StartSearch2
        searchDelayTimer.Start()
    End Sub

    Private Sub StartSearch2(sender As Object, e As EventArgs)
        ' Stop the timer
        searchDelayTimer.Stop()

        ' Perform the search
        PerformSearch2()
    End Sub

    Private Sub PerformSearch2()
        ' Perform the actual search
        Dim query As String = "SELECT * FROM bookings WHERE booking_firstname LIKE @searchText OR booking_lastname LIKE @searchText"
        Dim conn As String = "server=rasc.mysql.database.azure.com;username=innocode_rasc;password=Rasc_062301;database=hms_db;"

        Using connection As New MySqlConnection(conn)
            connection.Open()

            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@searchText", "%" + booking_search.Text + "%")

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            booking_dgv.DataSource = dt
        End Using
    End Sub
    'OPTIMIZED SEARCH BAR *****ENDS HERE******
End Class