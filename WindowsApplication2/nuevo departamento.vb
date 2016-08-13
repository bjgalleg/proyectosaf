Public Class nuevodepartamento
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'UNIDOSDataSet2.PERSONAS' Puede moverla o quitarla según sea necesario.
        Me.PERSONASTableAdapter1.Fill(Me.UNIDOSDataSet2.PERSONAS)
        'TODO: esta línea de código carga datos en la tabla 'UNIDOSDataSet1.PERSONAS' Puede moverla o quitarla según sea necesario.
        Me.PERSONASTableAdapter.Fill(Me.UNIDOSDataSet1.PERSONAS)

    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Me.Close()
    End Sub

    Private Sub btnañadir_Click(sender As Object, e As EventArgs) Handles btnañadir.Click

    End Sub
End Class