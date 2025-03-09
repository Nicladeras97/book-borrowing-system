Imports System.Data.OleDb
Public Class BorrowForm
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\borrowing-system.accdb"

    Private bookID As String
    Private bookTitle As String
    Private bookImage As String
    Private bookStatus As String

    Public Sub New(id As String, title As String, image As String, status As String)
        InitializeComponent()
        bookID = id
        bookTitle = title
        bookImage = image
        bookStatus = status
    End Sub

    Public Sub BorrowForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.ImageLocation = bookImage
        Label2.Text = bookTitle
        Label9.Text = bookStatus
        Label10.Text = bookID
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MMMM dd, yyyy"
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "MMMM dd, yyyy"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form As New DisplayAvailable()
        form.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New OleDbConnection(connString)

        Try
            conn.Open()

            Dim studentNumber As String = MaskedTextBox2.Text
            Dim fullName As String = TextBox3.Text
            Dim contactNumber As String = TextBox1.Text
            Dim borrowDate As Date = DateTimePicker1.Value
            Dim dueDate As Date = DateTimePicker2.Value

            Dim checkUserQuery As String = "SELECT COUNT(*) FROM [users] WHERE StudNo = ?"
            Dim checkCmd As New OleDbCommand(checkUserQuery, conn)
            checkCmd.Parameters.AddWithValue("?", studentNumber)
            Dim userExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If userExists = 0 Then
                Dim insertUserQuery As String = "INSERT INTO [users] (StudNo, FullName, ContactNumber) VALUES (?, ?, ?)"
                Dim insertUserCmd As New OleDbCommand(insertUserQuery, conn)
                insertUserCmd.Parameters.AddWithValue("?", studentNumber)
                insertUserCmd.Parameters.AddWithValue("?", fullName)
                insertUserCmd.Parameters.AddWithValue("?", contactNumber)
                insertUserCmd.ExecuteNonQuery()
            End If

            Dim insertQuery As String =
                "INSERT INTO borrow (StudNo, BookID, BorrowDate, DueDate, Status) 
                 VALUES (?, ?, ?, ?, ?)"

            Dim cmd As New OleDbCommand(insertQuery, conn)
            cmd.Parameters.AddWithValue("?", studentNumber)
            cmd.Parameters.AddWithValue("?", bookID)
            cmd.Parameters.AddWithValue("?", borrowDate)
            cmd.Parameters.AddWithValue("?", dueDate)
            cmd.Parameters.AddWithValue("?", "Borrowed")
            cmd.ExecuteNonQuery()

            Dim updateQuery As String = "UPDATE book SET Status = 'Borrowed' WHERE BookID = ?"
            Dim cmdUpdate As New OleDbCommand(updateQuery, conn)
            cmdUpdate.Parameters.AddWithValue("?", bookID)
            cmdUpdate.ExecuteNonQuery()

            MessageBox.Show("Book successfully borrowed!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim displayForm As New DisplayAvailable()
            displayForm.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
