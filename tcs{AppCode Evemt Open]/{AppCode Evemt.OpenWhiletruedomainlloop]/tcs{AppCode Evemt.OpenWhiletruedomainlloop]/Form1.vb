Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.MouseEnter
        CheckBox1.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "92369" Then Label3.Visible = True And Label2.Visible = False
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        Application.Exit()
    End Sub

    Private Sub Info_Click(sender As Object, e As EventArgs) Handles Info.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.BackColor = Color.Gray
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.BackColor = Color.Gainsboro
    End Sub
End Class
