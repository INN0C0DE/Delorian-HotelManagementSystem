Imports System.IO.Ports
Imports System.Threading

Public Class notifier_form
    Dim WithEvents smsport As New SerialPort("COM4")

    Private Sub notifier_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With smsport
            .BaudRate = 115200
            .DataBits = 8
            .Parity = Parity.None
            .StopBits = StopBits.One
            .Handshake = Handshake.None
            .DtrEnable = True
            .RtsEnable = True
            .NewLine = vbCrLf
        End With

        Try
            smsport.Open()
        Catch ex As Exception
            Me.Invoke(Sub() MessageBox.Show("Failed to open serial port: " & ex.Message))
        End Try
    End Sub

    Private Sub notifier_form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            smsport.Close()
        Catch ex As Exception
            MessageBox.Show("Failed to close serial port: " & ex.Message)
        End Try
    End Sub

    Private Sub send_message_Click(sender As Object, e As EventArgs) Handles send_message.Click
        If notifier_number.Text = "" Or notifier_message.Text = "" Then
            MessageBox.Show("Please enter a Recepient's number and a Message.", "Message Notifier:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim atCMGS As String = "AT+CMGS=" & Chr(34) & notifier_number.Text & Chr(34) & vbCrLf
            With smsport
                .WriteLine("AT" & vbCrLf)
                .WriteLine("AT+CMGF=1" & vbCrLf)
                .WriteLine(atCMGS)
                Threading.Thread.Sleep(1000)
                Dim response As String = smsport.ReadExisting()
                Do Until response.Contains(">")
                    response &= smsport.ReadExisting()
                Loop
                .WriteLine(notifier_message.Text & vbCrLf & Chr(26))
                Threading.Thread.Sleep(3000)
                Dim newresponse = smsport.ReadExisting()
                If newresponse.Contains("ERROR") Then
                    MessageBox.Show("Failed to send message.", "Message Notifier:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Message sent!", "Message Notifier:", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            End With
            'MessageBox.Show("Message Sent!", "Message Notifier:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        notifier_message.Clear()
        notifier_number.Clear()
        Me.Close()
    End Sub
End Class
