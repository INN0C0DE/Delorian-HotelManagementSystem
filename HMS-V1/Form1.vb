Imports MySql.Data.MySqlClient

Public Class splash_screen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        'Dim login_form As New splash_screen
        login_form.Show()
        Me.Hide()
    End Sub

    Private Sub splash_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Dim conn As New DBconnection
    'Private Sub BunifuButton1_Click(sender As Object, e As EventArgs)
    '    conn.openDB()
    'End Sub

    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

    'Private Sub BunifuButton2_Click(sender As Object, e As EventArgs)
    '    conn.closeDB()

    'End Sub
End Class
