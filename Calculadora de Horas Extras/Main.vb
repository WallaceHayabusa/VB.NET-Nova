Public Class frmPrincipal
    Private Sub btnLimparCampos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimparCampos.Click
        txtHoraEntrada.Clear()
        txtAlmocoEntrada.Clear()
        txtAlmocoSaida.Clear()
        txtHoraSaida.Clear()
        txtMotivo.Clear()
    End Sub

    Private Function calcularHorasExtras() As TimeSpan
        Dim horasTrabalhadas As TimeSpan = calcularHorasPorDiaComAlmoco()
        Dim horaDiaria As TimeSpan = TimeSpan.Parse("08:00:00")
        Dim horasExtras As TimeSpan = horasTrabalhadas.Subtract(horaDiaria)

        Return horasExtras
    End Function

    Private Function calcularTotalHorasExtras() As Double
        txtHorasExtras.Text = calcularHorasExtras().ToString
        If txtHorasExtras.Text > 2 Then
            Dim hora = txtHorasExtras.Text - 2
            lblNumeroHorasExtras.Text = (2 + (hora) * 1.5).ToString + " horas"
        Else
            lblNumeroHorasExtras.Text = txtHorasExtras.Text + " hora(s)"
        End If
    End Function

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        calcularTotalHorasExtras()
    End Sub

    Private Function calcularHorasAlmoco() As TimeSpan
        Dim horaEntrada As String = txtAlmocoEntrada.Text
        Dim entrada As TimeSpan = TimeSpan.Parse(horaEntrada)

        Dim horaSaida As String = txtAlmocoSaida.Text
        Dim saida As TimeSpan = TimeSpan.Parse(horaSaida)

        Dim diferenca As TimeSpan
        diferenca = saida.Subtract(entrada)

        Return diferenca
    End Function

    Private Function calcularHorasPorDiaSemAlmoco() As String
        'Str1 = Data + " " + hora
        'dt1 = Str()
        'Str2 = Data + " " + hora
        'dt2 = str2
        'diferenca()

        Dim dataEntrada As String
        dataEntrada = dtEntrada.Text + " " + txtHoraEntrada.Text + ":00"

        Dim data As DateTime = DateTime.Parse(dataEntrada)

        Dim dataSaida As String
        dataSaida = dtSaida.Text + " " + txtHoraSaida.Text + ":00"

        Dim data2 As DateTime = DateTime.Parse(dataSaida)
        Dim minutos As Integer = DateDiff(DateInterval.Minute, data, data2)

        Dim diferenca As String = (Math.Round(minutos / 60, 0)).ToString + ":" + (minutos Mod 60).ToString

        Return diferenca
    End Function

    Private Function calcularHorasPorDiaComAlmoco() As TimeSpan
        Dim horasSemAlmoco As TimeSpan = TimeSpan.Parse(calcularHorasPorDiaSemAlmoco())
        Dim horaAlmoco As TimeSpan = calcularHorasAlmoco()
        Dim diferenca As TimeSpan = horasSemAlmoco.Subtract(horaAlmoco)

        Return diferenca
    End Function
End Class
