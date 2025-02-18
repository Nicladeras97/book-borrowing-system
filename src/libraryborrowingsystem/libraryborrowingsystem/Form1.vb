Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Panel2.Cursor = Cursors.Hand
        Panel3.Cursor = Cursors.Hand
        Panel5.Cursor = Cursors.Hand
        Button2.Cursor = Cursors.Hand
    End Sub

    Private Sub Panel2_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Panel2.MouseEnter, Label3.MouseEnter,
        Label6.MouseEnter, Label7.MouseEnter, PictureBox2.MouseEnter
        Panel2.BackColor = Color.DarkGray
    End Sub

    Private Sub Panel2_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Panel2.MouseLeave, Label3.MouseLeave,
        Label6.MouseLeave, Label7.MouseLeave, PictureBox2.MouseLeave
        Panel2.BackColor = Color.LightGray
    End Sub

    Private Sub Panel3_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Panel3.MouseEnter, Label8.MouseEnter,
        Label9.MouseEnter, Label10.MouseEnter, PictureBox3.MouseEnter
        Panel2.BackColor = Color.DarkGray
    End Sub

    Private Sub Panel3_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Panel3.MouseLeave, Label8.MouseLeave,
        Label9.MouseLeave, Label10.MouseLeave, PictureBox3.MouseLeave
        Panel2.BackColor = Color.LightGray
    End Sub

    Private Sub Panel5_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles Panel5.MouseEnter, Label4.MouseEnter,
        Label11.MouseEnter, Label12.MouseEnter, PictureBox4.MouseEnter
        Panel2.BackColor = Color.DarkGray
    End Sub

    Private Sub Panel5_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Panel5.MouseLeave, Label4.MouseLeave,
        Label11.MouseLeave, Label12.MouseLeave, PictureBox4.MouseLeave
        Panel2.BackColor = Color.LightGray
    End Sub

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