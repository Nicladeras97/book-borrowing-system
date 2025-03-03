Imports System.Data.OleDb
Imports System.IO

Public Class DisplayBorrowed
    Dim connString As String = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\borrowing-system.accdb")

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim back As New Menu()
        back.Show()
        Me.Hide()
    End Sub
    Private Sub DisplayBorrowed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadBooks("")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        LoadBooks(TextBox1.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadBooks(TextBox1.Text)
    End Sub

    Private Sub LoadBooks(Optional searchQuery As String = "")
        FlowLayoutPanel1.Controls.Clear()

        Dim conn As New OleDbConnection(connString)
        Dim query As String = "SELECT * FROM displayBooks WHERE Status = 'Borrowed' AND (Title LIKE @search OR Author LIKE @search)"
        Dim cmd As New OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("@search", "%" & searchQuery & "%")

        Try
            conn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim status As String = reader("Status").ToString()
                Dim bookID As String = reader("BookID").ToString()

                Dim bookPanel As New Panel With {
                    .Size = New Size(200, 350),
                    .BorderStyle = BorderStyle.None,
                    .BackColor = Color.LightBlue,
                    .Padding = New Padding(10)
                }

                Dim bookTitle As New Label With {
                    .Text = reader("Title").ToString(),
                    .Location = New Point(10, 220),
                    .Size = New Size(180, 20),
                    .Font = New Font("Arial", 10, FontStyle.Bold),
                    .ForeColor = Color.Black,
                    .BackColor = Color.Transparent,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .AutoSize = False
                }

                Dim bookAuthor As New Label With {
                    .Text = "By: " & reader("Author").ToString(),
                    .Location = New Point(10, 245),
                    .Size = New Size(180, 15),
                    .Font = New Font("Arial", 8, FontStyle.Regular),
                    .ForeColor = Color.Black,
                    .BackColor = Color.Transparent,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .AutoSize = False
                }

                Dim bookImage As New PictureBox With {
                    .Size = New Size(180, 200),
                    .Location = New Point(10, 10),
                    .SizeMode = PictureBoxSizeMode.Zoom,
                    .BackColor = Color.Transparent
                }

                Dim imagePath As String = reader("Image").ToString()
                If File.Exists(imagePath) Then
                    bookImage.Image = Image.FromFile(imagePath)
                Else
                    bookImage.Image = My.Resources.image
                End If

                Dim btnReturn As New Button With {
                    .Text = "Return",
                    .Size = New Size(90, 30),
                    .Location = New Point(55, 270),
                    .BackColor = Color.Red,
                    .ForeColor = Color.White,
                    .Font = New Font("Arial", 9, FontStyle.Bold),
                    .FlatStyle = FlatStyle.Flat,
                    .Tag = bookID
                }
                btnReturn.FlatAppearance.BorderSize = 0
                btnReturn.Cursor = Cursors.Hand
                AddHandler btnReturn.Click, AddressOf ReturnBook

                bookPanel.Controls.Add(bookImage)
                bookPanel.Controls.Add(bookTitle)
                bookPanel.Controls.Add(bookAuthor)
                bookPanel.Controls.Add(btnReturn)

                bookPanel.Tag = reader("BookID")
                FlowLayoutPanel1.Controls.Add(bookPanel)
            End While
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ReturnBook(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim bookID As String = btn.Tag.ToString()

        Dim bookTitle As String = ""
        Dim bookImage As String = ""

        Using conn As New OleDbConnection(connString)
            Dim query As String = "SELECT Title, Image FROM displayBooks WHERE BookID = @bookID"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@bookID", bookID)

            Try
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    bookTitle = reader("Title").ToString()
                    bookImage = reader("Image").ToString()
                End If
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error fetching book details: " & ex.Message)
            End Try
        End Using

        Dim returnForm As New ReturnForm(bookID, bookTitle, bookImage)
        returnForm.Show()
        Me.Close()
    End Sub
End Class