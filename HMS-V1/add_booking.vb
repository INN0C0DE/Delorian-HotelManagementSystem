Public Class add_booking

    Private Sub add_booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub booking_startdate_ValueChanged(sender As Object, e As EventArgs) Handles booking_startdate.ValueChanged

    End Sub

    Private Sub booking_compute_Click(sender As Object, e As EventArgs) Handles booking_compute.Click
        Dim checkInDate As Date = booking_startdate.Value
        Dim checkOutDate As Date = booking_enddate.Value
        ' Calculate the number of days between check-in and check-out
        Dim numDays As Integer = (checkOutDate - checkInDate).Days
        ' Display the number of days in the TextBox
        booking_days.Text = numDays.ToString()
        ' Validate that a room type is selected
        If booking_roomtype.SelectedIndex = -1 Then
            MessageBox.Show("Please select a room type.", "You forgot something:", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ' Get the price of the selected room type
        Dim roomType As String = booking_roomtype.SelectedItem.ToString()
        Dim roomPrice As Decimal

        Select Case roomType
            Case "STANDARD"
                roomPrice = 3500
            Case "DELUXE"
                roomPrice = 5500
            Case "SUITE"
                roomPrice = 7500
        End Select

        ' Calculate the total cost based on the number of days and room price
        Dim totalCost As Decimal = numDays * roomPrice

        ' Display the total cost in the TextBox
        booking_amount.Text = totalCost.ToString()
    End Sub

    Private Sub addbooking_btn_Click(sender As Object, e As EventArgs) Handles addbooking_btn.Click
        If booking_firstname.Text = "" OrElse
       booking_lastname.Text = "" OrElse
       booking_email.Text = "" OrElse
       booking_number.Text = "" OrElse
       booking_address.Text = "" OrElse
       booking_roomtype.Text = "" OrElse
       booking_startdate.Value = DateTimePicker.MinimumDateTime OrElse
       booking_enddate.Value = DateTimePicker.MinimumDateTime OrElse
       booking_days.Text = "" OrElse
       booking_amount.Text = "" OrElse
       booking_status.Text = "" Then
            MsgBox("Please fill up all required fields.", vbInformation, "Incomplete Information")
        Else
            create("INSERT INTO bookings (booking_firstname,booking_lastname,booking_email,booking_number,booking_address,booking_roomtype,booking_inDate,booking_outDate,booking_days,booking_amount,booking_status) VALUES ('" & booking_firstname.Text & "','" & booking_lastname.Text & "','" & booking_email.Text & "','" & booking_number.Text & "','" & booking_address.Text & "','" & booking_roomtype.Text & "','" & booking_startdate.Value.ToString("yyyy-MM-dd") & "','" & booking_enddate.Value.ToString("yyyy-MM-dd") & "','" & booking_days.Text & "','" & booking_amount.Text & "','" & booking_status.Text & "')")

            Me.Hide()
            admin_dashboard.LOADLV2()
            Call CLEARTEXT()
        End If
    End Sub
    Public Sub CLEARTEXT()
        booking_id.Text = ""
        booking_firstname.Text = ""
        booking_lastname.Text = ""
        booking_email.Text = ""
        booking_number.Text = ""
        booking_address.Text = ""
        booking_roomtype.Text = ""
        booking_startdate.Value = DateTimePicker.MinimumDateTime
        booking_enddate.Value = DateTimePicker.MinimumDateTime
        booking_days.Text = ""
        booking_amount.Text = ""
        booking_status.Text = ""
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Me.Hide()
        Call CLEARTEXT()
    End Sub
End Class