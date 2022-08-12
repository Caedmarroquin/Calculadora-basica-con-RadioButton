Public Class Form1
    Dim A, B As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        A = TextBox1.Text
        B = TextBox2.Text
        If (RadioButton1.Checked) Then
            Label5.Text = A + B
        ElseIf (RadioButton2.Checked) Then
            Label5.Text = A - B
        ElseIf (RadioButton3.Checked) Then
            Label5.Text = A * B
        ElseIf (RadioButton4.Checked) Then
            Label5.Text = A / B
        Else
            Label5.Text = "Seleccione operación"
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        Label5.Text = ""
    End Sub
End Class
