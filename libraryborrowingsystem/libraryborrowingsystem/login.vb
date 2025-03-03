Imports System.Data.OleDb

Public Class Login
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\borrowing-system.accdb"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        Dim Menu As New Menu()

        Dim query As String = "SELECT COUNT(*) FROM login WHERE [Username]=@user AND [Password]=@pass"

        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@user", username)
                cmd.Parameters.AddWithValue("@pass", password)

                Try
                    conn.Open()
                    Dim userCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If userCount > 0 Then
                        'MessageBox.Show("Login successful!", "Success",
                        '                MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Hide()
                        Dim menuForm As New Menu()
                        menuForm.Show()
                    Else
                        MessageBox.Show("Invalid username or password!", "Login Failed",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Database Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class
