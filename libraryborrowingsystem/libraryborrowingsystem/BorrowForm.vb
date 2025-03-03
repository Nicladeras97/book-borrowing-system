Imports System.Data.OleDb
Public Class BorrowForm
    Dim connString As String = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\borrowing-system.accdb")

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

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MMMM dd, yyyy"
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "MMMM dd, yyyy"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim form As New DisplayAvailable()
        form.Show()
        Me.Close()
    End Sub
End Class