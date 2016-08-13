Public Class Departamentos
    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Me.Close()
    End Sub

    Private Sub btnnvodpto_Click(sender As Object, e As EventArgs) Handles btnnvodpto.Click
        nuevodepartamento.Show()
    End Sub
End Class