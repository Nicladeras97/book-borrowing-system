Imports System.Drawing.Drawing2D

Public Class Login
    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Panel1.Paint
        Dim radius As Integer = 20
        Dim path As New GraphicsPath()

        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(Panel1.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(Panel1.Width - radius, Panel1.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, Panel1.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        Panel1.Region = New Region(path)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim menu As New Menu()
        menu.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Button1.Paint
        Dim radius As Integer = 20
        Dim path As New GraphicsPath()

        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(Button1.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(Button1.Width - radius, Button1.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, Button1.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        Button1.Region = New Region(path)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class

