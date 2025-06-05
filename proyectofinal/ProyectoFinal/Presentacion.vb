Public NotInheritable Class Presentacion
    Private Sub Presentacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Me.Hide()
        Buscador.Show()
    End Sub
End Class
