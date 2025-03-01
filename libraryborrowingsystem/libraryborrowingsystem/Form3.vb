Public Class Form3
    Dim connString As String = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\borrowing-system.accdb")

    Private bookID As String
    Private bookTitle As String
    Private bookImage As String

    Public Sub New(id As String, title As String, image As String)
        InitializeComponent()
        bookTitle = title
        bookID = id
        bookImage = image
    End Sub

    Public Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.ImageLocation = bookImage
        Label2.Text = bookTitle
        Label4.Text = bookID
    End Sub
End Class