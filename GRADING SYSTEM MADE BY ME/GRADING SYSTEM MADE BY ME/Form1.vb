Public Class Form1

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click

        txtAverage.Text = (Val(txtPrelim) + Val(txtMidterm) + Val(txtSemi) + Val(txtFinal)) / 4






    End Sub
End Class
