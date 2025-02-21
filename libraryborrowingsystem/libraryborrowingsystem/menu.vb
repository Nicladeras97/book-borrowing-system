Imports System.Drawing.Drawing2D

Public Class Menu

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim logout As New Login()
        logout.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Panel2.Paint
        Dim radius As Integer = 20
        Dim path As New GraphicsPath()

        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(Panel2.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(Panel2.Width - radius, Panel2.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, Panel2.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        Panel2.Region = New Region(path)
    End Sub

    Private Sub Panel3_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Panel3.Paint
        Dim radius As Integer = 20
        Dim path As New GraphicsPath()

        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(Panel3.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(Panel3.Width - radius, Panel3.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, Panel3.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        Panel3.Region = New Region(path)
    End Sub

    Private Sub Panel4_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Panel4.Paint
        Dim radius As Integer = 20
        Dim path As New GraphicsPath()

        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(Panel4.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(Panel4.Width - radius, Panel4.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, Panel4.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        Panel4.Region = New Region(path)
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Panel2.Cursor = Cursors.Hand
        Panel3.Cursor = Cursors.Hand
        Panel4.Cursor = Cursors.Hand
        Button1.Cursor = Cursors.Hand
        Button2.Cursor = Cursors.Hand
    End Sub

    Private Sub Panel2_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Panel2.MouseEnter, Label2.MouseEnter,
        PictureBox2.MouseEnter
        Panel2.BackColor = Color.DarkGray
    End Sub

    Private Sub Panel2_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Panel2.MouseLeave, Label2.MouseLeave,
        PictureBox2.MouseLeave
        Panel2.BackColor = Color.LightGray
    End Sub

    Private Sub Panel3_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Panel3.MouseEnter, Label3.MouseEnter,
        PictureBox3.MouseEnter
        Panel3.BackColor = Color.DarkGray
    End Sub

    Private Sub Panel3_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Panel3.MouseLeave, Label3.MouseLeave,
        PictureBox3.MouseLeave
        Panel3.BackColor = Color.LightGray
    End Sub

    Private Sub Panel4_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Panel4.MouseEnter, Label4.MouseEnter,
        PictureBox4.MouseEnter
        Panel4.BackColor = Color.DarkGray
    End Sub

    Private Sub Panel4_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Panel4.MouseLeave, Label4.MouseLeave,
        PictureBox4.MouseLeave
        Panel4.BackColor = Color.LightGray
    End Sub

    Private Sub Panel2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Panel2.Click, Label2.Click, PictureBox2.Click
        Dim borrow As New Form1()
        borrow.Show()
        Me.Hide()
    End Sub
End Class