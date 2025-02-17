Imports System.Drawing.Drawing2D

Public Class Form2

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MMMM dd, yyyy"
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "MMMM dd, yyyy"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim form As New Form1()
        form.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Button4.Paint
        Dim radius As Integer = 20
        Dim path As New GraphicsPath()

        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(Button4.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(Button4.Width - radius, Button4.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, Button4.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        Button4.Region = New Region(path)
    End Sub
End Class