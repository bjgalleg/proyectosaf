Imports System.Data.SqlClient
Public Class EliminarDatos
    Dim sqlConn As New SqlConnection
    Private Sub Crear_Conexion()
        sqlConn.ConnectionString = " Data Source=USUARIO\SQLEXPRESS;Initial Catalog=UNIDOS;Integrated Security=True"
        sqlConn.Open()
    End Sub
    Private Sub cerrar_Conexion()
        sqlConn.Close()
    End Sub
    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Me.Close()
    End Sub

    Private Sub txtced_TextChanged(sender As Object, e As EventArgs) Handles txtced.TextChanged

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click

        Dim conexion As New SqlConnection(My.Settings.conexion)
        conexion.Open()

        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = conexion
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.CommandText = "validarcedula"

        sqlcmd.Parameters.Add(New SqlParameter("@cedula", SqlDbType.NChar, 50)).Value = txtced.Text

        Dim reader As SqlDataReader
        reader = sqlcmd.ExecuteReader

        Dim r As Boolean = reader.HasRows()
        If r = True Then
            Dim connexion As New SqlConnection(My.Settings.conexion)
            connexion.Open()

            Dim sqlcmdd As New SqlCommand
            sqlcmdd.Connection = connexion
            sqlcmdd.CommandType = CommandType.StoredProcedure
            sqlcmdd.CommandText = "eliminarusuario"
            sqlcmdd.Parameters.Add(New SqlParameter("@cedula", SqlDbType.NChar, 50)).Value = txtced.Text

            Dim readerr As SqlDataReader = sqlcmd.ExecuteReader()

            MsgBox("Usuario Eliminado")
        Else

            MsgBox("Usuario no Encontrado")
        End If



    End Sub
End Class