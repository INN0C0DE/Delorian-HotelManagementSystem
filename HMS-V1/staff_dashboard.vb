Imports MySql.Data.MySqlClient

Public Class staff_dashboard

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        staff_pages.SetPage("rooms")
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        staff_pages.SetPage("bookings")
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

    Private Sub staff_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LOADLV2()

        staff_pages.SetPage("rooms")
    End Sub
    Public Sub LOADLV2()
        reload("SELECT * FROM bookings", booking_dgv)
    End Sub

    Private Sub booking_addbtn_Click(sender As Object, e As EventArgs) Handles booking_addbtn.Click
        Try
            add_booking.Show()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
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
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    'OPTIMIZED SEARCH BAR *****STARTS HERE******
    Private searchDelayTimer As Timer

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
    Private Sub staff_dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Application.Exit()
        End If
    End Sub

End Class