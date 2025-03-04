Imports System.Data.OleDb
Public Class ReturnForm
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\borrowing-system.accdb"

    Private bookID As String
    Private bookTitle As String
    Private bookImage As String

    Public Sub New(id As String, title As String, image As String)
        InitializeComponent()
        bookTitle = title
        bookID = id
        bookImage = image
    End Sub

    Public Sub ReturnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.ImageLocation = bookImage
        Label2.Text = bookTitle
        Label4.Text = bookID
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim form As New DisplayBorrowed()
        form.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conn As New OleDbConnection(connString)
        Try
            conn.Open()

            Dim studentNumber As String = MaskedTextBox2.Text
            Dim borrowerName As String = TextBox6.Text

            Dim checkQuery As String = "SELECT COUNT(*) FROM borrow WHERE StudNo = ? AND BookID = ?"
            Dim checkCmd As New OleDbCommand(checkQuery, conn)
            checkCmd.Parameters.AddWithValue("?", studentNumber)
            checkCmd.Parameters.AddWithValue("?", bookID)
            Dim recordExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If recordExists > 0 Then
                Dim deleteQuery As String = "DELETE FROM borrow WHERE StudNo = ? AND BookID = ?"
                Dim deleteCmd As New OleDbCommand(deleteQuery, conn)
                deleteCmd.Parameters.AddWithValue("?", studentNumber)
                deleteCmd.Parameters.AddWithValue("?", bookID)
                deleteCmd.ExecuteNonQuery()

                Dim updateQuery As String = "UPDATE book SET Status = 'Available' WHERE BookID = ?"
                Dim updateCmd As New OleDbCommand(updateQuery, conn)
                updateCmd.Parameters.AddWithValue("?", bookID)
                updateCmd.ExecuteNonQuery()

                MessageBox.Show("Book successfully returned!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim displayForm As New DisplayBorrowed()
                displayForm.Show()
                Me.Close()
            Else
                MessageBox.Show("No matching borrow record found.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
End Class
