Public Class Form1
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim back As New Menu()
        back.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Panel2.Click, Label3.Click, Label6.Click,
        Label7.Click, PictureBox2.Click
        Dim borrow As New Form2
        borrow.Show()
        Me.Hide()
    End Sub
End Class