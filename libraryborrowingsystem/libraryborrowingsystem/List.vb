Public Class List
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim menu As New Menu
        menu.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim menu As New Menu
        menu.Show()
        Me.Hide()

    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        Dim Form4 As New Form4
        Form4.Show()
        Me.Hide()

    End Sub
End Class