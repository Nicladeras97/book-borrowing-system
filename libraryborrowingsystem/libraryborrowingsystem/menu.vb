

Public Class Menu
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim logout As New Login()
        logout.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Panel2.Click, Label2.Click, PictureBox2.Click
        Dim available As New DisplayAvailable()
        available.Show()
        Me.Hide()
    End Sub

    Private Sub Panel3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Panel3.Click, Label3.Click, PictureBox3.Click
        Dim borrow As New DisplayBorrowed()
        borrow.Show()
        Me.Hide()
    End Sub

End Class