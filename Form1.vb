Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


#   seleccionando el boton para al darle clic cambie el texto
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        TextBox1.Text = "Texto Cambiado"
    End Sub
End Class
