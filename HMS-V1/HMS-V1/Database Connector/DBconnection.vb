Imports MySql.Data.MySqlClient

'Public Class DBconnection
'    'Public conn As New MySqlConnection("server=localhost;username=root;password=;database=hms_db")
'    'Public CONNECT As New MySqlConnection(conn)
'    'Public CONSTRING As String = "server=localhost;username=root;password=;database=hms_db"
'    'Public CONNECT As New MySqlConnection(CONSTRING)
'    'Public ADPTR As MySqlDataAdapter
'    'Public CMD As New MySqlCommand
'    'Public DR As MySqlDataReader
'    'Public DS As DataSet
'    'Public itemcoll(999) As String
'    'Public str_user As String
'    ''Public _title As String = "Hotel Mangement System"
'    'Public Sub OPENCONNECTION()
'    '    Try
'    '        If CONNECT.State = ConnectionState.Closed Then
'    '            CONNECT.Open()
'    '        End If
'    '    Catch ex As Exception
'    '        MsgBox(ex.ToString)
'    '    End Try
'    'End Sub

'    '### FOR CHECKING CONNECTION
'    'Public Function openDB()
'    '    Try
'    '        conn.Open()
'    '        Form1.BunifuLabel2.Text = "db connnected"
'    '    Catch ex As Exception
'    '        Form1.BunifuLabel2.Text = "db not connnected"
'    '        MsgBox(ex.Message)
'    '    End Try
'    '    Return conn
'    'End Function
'    'Public Function closeDB()
'    '    Try
'    '        conn.Close()
'    '        Form1.BunifuLabel2.Text = "db closed"
'    '    Catch ex As Exception
'    '        Form1.BunifuLabel2.Text = "db not close"
'    '        MsgBox(ex.Message)
'    '    End Try
'    '    Return conn
'    'End Function
'End Class
Module DBconnection
    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server=rasc.mysql.database.azure.com;username=innocode_rasc;password=Rasc_062301;database=hms_db;")
        'encrypt=true;trustServerCertificate=true
    End Function
    Public strcon As MySqlConnection = strconnection()

    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable



    'FOR RELOADING DATA TO THE DATABASE
    Public Sub reload(ByVal sql As String, ByVal staff_dvg As Object)
        Try
            dt = New DataTable
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            staff_dvg.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    'FOR SAVING DATA TO THE DATABASE
    Public Sub create(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("FAILED TO SAVE THE DATA", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DATA SAVED SUCCESSFULLY", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()

        End Try
    End Sub

    'FOR UPDATING DATA TO THE DATABASE
    Public Sub updates(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("FAILED TO UPDATE THE DATA", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DATA UPDATED SUCCESSFULLY", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()

        End Try
    End Sub

    'FOR DELETING DATA TO THE DATABASE
    Public Sub delete(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("FAILED TO DELETE THE DATA", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DATA DELETED SUCCESSFULLY", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()

        End Try
    End Sub
End Module