Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Visible = False
        Button1.DialogResult = System.Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Visible = False
    End Sub
End Class