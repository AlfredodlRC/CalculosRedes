Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        RBClaseA.Checked = True
        RBMascara.Checked = True
        RBMascaraSub.Checked = True

        Dim Ott As New ToolTip

        Ott.IsBalloon = True

        Ott.InitialDelay = 300
        Ott.ReshowDelay = 20
        Ott.AutoPopDelay = 8000

        Ott.SetToolTip(CBMascara1, "Byte más alto de la máscara de red")
        Ott.SetToolTip(CBMascara2, "Segundo byte con más peso de la máscara de red")
        Ott.SetToolTip(CBMascara3, "Segundo byte con menos peso de la máscara de red")
        Ott.SetToolTip(CBMascara4, "Byte más bajo de la máscara de red")
        Ott.SetToolTip(CBMascaraSub1, "Byte más alto de la máscara de subred")
        Ott.SetToolTip(CBMascaraSub2, "Segundo byte con más peso de la máscara de subred")
        Ott.SetToolTip(CBMascaraSub3, "Segundo byte con menos peso de la máscara de subred")
        Ott.SetToolTip(CBMascaraSub4, "Byte más bajo de la máscara de subred")

        Ott.SetToolTip(NUDcidr, "Valor CIDR de la máscara de red")
        Ott.SetToolTip(NUDCIDRSub, "Valor CIDR de la máscara de subred")
        Ott.SetToolTip(NUDRed1, "Primer octeto de la dirección de red")
        Ott.SetToolTip(NUDRed2, "Segundo octeto de la dirección de red")
        Ott.SetToolTip(NUDRed3, "Tercero octeto de la dirección de red")
        Ott.SetToolTip(NUDRed4, "Cuarto octeto de la dirección de red")

        Ott.SetToolTip(RBcidr, "Activado se seleccionará la máscara de red por el valor CIDR")
        Ott.SetToolTip(RBCIDRSub, "Activado se seleccionará la máscara de subred por el valor CIDR")
        Ott.SetToolTip(RBMascara, "Activado se seleccionará la máscara de red por los octetos de la máscara de red")
        Ott.SetToolTip(RBMascaraSub, "Activado se seleccionará la máscara de red por los octetos de la máscara de subred")
        Ott.SetToolTip(RBClaseA, "Se implementará los parametros de red de la clase A")
        Ott.SetToolTip(RBClaseB, "Se implementará los parametros de red de la clase B")
        Ott.SetToolTip(RBClaseC, "Se implementará los parametros de red de la clase C")

        Ott.SetToolTip(TBBroadcast, "Dirección broadcast de la red")
        Ott.SetToolTip(TBCantidadDirecciones, "Número de direcciones que tiene la red")
        Ott.SetToolTip(TBDireccionPrimera, "Primera dirección útil de la red")
        Ott.SetToolTip(TBDireccionUltima, "Última dirección útil de la red")
        Ott.SetToolTip(TBNumeroEquipos, "Número de Equipos que puede haber en la red")
        Ott.SetToolTip(TBRed, "Dirección de la red")

        Ott.SetToolTip(GBClaseRed, "Grupo donde se selecciona la clase da la dirección")
        Ott.SetToolTip(GBEleccionMascara, "Se decide si la máscara de red se selecciona por valor de máscara o por valor cidr")

        Ott.SetToolTip(BtnCalcular, "Botón para realizar los datos")
        Ott.SetToolTip(BtnLimpiar, "Resetea los valores por defecto de la entrada y vácia los elementos de sálida.")



        Ott.SetToolTip(LblDireccionIP, "Elección de la dirección de red")
        Ott.SetToolTip(LblMascaraRed, "Elección de la máscara de red")
        Ott.SetToolTip(LblMascaraSubred, "Elección de la máscara de subred")

        Ott.SetToolTip(LblDirBroadcast, "Dirección broadcast de la red")
        Ott.SetToolTip(LblDirPrimera, "Primera dirección útil de la red")
        Ott.SetToolTip(LblDirRed, "Dirección de la red")
        Ott.SetToolTip(LblDirUltima, "Última dirección útil de la red")
        Ott.SetToolTip(LblNuDir, "Número de direcciones que tiene la red")
        Ott.SetToolTip(LblNuHosts, "Número de Equipos que puede haber en la red")



    End Sub

    ' --------------------------------------------------------------------------------------------------------------
    ' --------------------------------------------------------------------------------------------------------------
    ' -------------------------------------  Eventos de los botones de accion  -------------------------------------
    ' --------------------------------------------------------------------------------------------------------------
    ' --------------------------------------------------------------------------------------------------------------

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        Dim red As UInteger
        Dim mascara As UInteger
        Dim primeraDireccion As UInteger
        Dim ultimaDireccion As UInteger
        Dim cantidad As UInteger
        Dim listaBytes As Byte()
        Dim i As Integer

        mascara = 0
        For i = 31 To 32 - NUDcidr.Value Step -1
            mascara = mascara + 2 ^ i
        Next i

        red = (((NUDRed1.Value * 256) + NUDRed2.Value) * 256 + NUDRed3.Value) * 256 + NUDRed4.Value

        red = red And mascara

        cantidad = 2 ^ (32 - NUDcidr.Value)

        primeraDireccion = red + 1
        ultimaDireccion = red + cantidad - 1

        listaBytes = BitConverter.GetBytes(red)
        TBRed.Text = listaBytes(3).ToString + "." + listaBytes(2).ToString + "." +
                                 listaBytes(1).ToString + "." + listaBytes(0).ToString

        listaBytes = BitConverter.GetBytes(mascara)
        TBBroadcast.Text = listaBytes(3).ToString + "." + listaBytes(2).ToString + "." +
                                 listaBytes(1).ToString + "." + listaBytes(0).ToString

        listaBytes = BitConverter.GetBytes(primeraDireccion)
        TBDireccionPrimera.Text = listaBytes(3).ToString + "." + listaBytes(2).ToString + "." +
                                  listaBytes(1).ToString + "." + listaBytes(0).ToString

        listaBytes = BitConverter.GetBytes(ultimaDireccion)
        TBDireccionUltima.Text = listaBytes(3).ToString + "." + listaBytes(2).ToString + "." +
                                 listaBytes(1).ToString + "." + listaBytes(0).ToString


        If NUDcidr.Value = 32 Then
            TBCantidadDirecciones.Text = 0
            TBNumeroEquipos.Text = 0
        Else
            TBCantidadDirecciones.Text = cantidad
            TBNumeroEquipos.Text = cantidad - 2
        End If


    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click

        TBBroadcast.Text = ""
        TBCantidadDirecciones.Text = ""
        TBDireccionPrimera.Text = ""
        TBDireccionUltima.Text = ""
        TBNumeroEquipos.Text = ""
        TBRed.Text = ""

        RBClaseA.Checked = True
        RBMascarasub_CheckedChanged(sender, e)

        RBMascara.Checked = True
        RBMascara_CheckedChanged(sender, e)

        RBMascaraSub.Checked = True
        RBMascarasub_CheckedChanged(sender, e)

    End Sub

    ' --------------------------------------------------------------------------------------------------------------
    ' --------------------------------------------------------------------------------------------------------------
    ' ----------------------------------  Eventos para el cambio de clase de red  ----------------------------------
    ' --------------------------------------------------------------------------------------------------------------
    ' --------------------------------------------------------------------------------------------------------------

    Private Sub RBClaseA_CheckedChanged(sender As Object, e As EventArgs) Handles RBClaseA.CheckedChanged
        'Clase A:  10.0.0.0 a 10.255.255.255 (8 bits red, 24 bits hosts)


        If sender.checked = True Then
            NUDRed1.Minimum = 10
            NUDRed1.Maximum = 10
            NUDRed1.Value = 10

            NUDRed2.Minimum = 0
            NUDRed2.Maximum = 255
            NUDRed2.Value = 0

            NUDRed3.Minimum = 0
            NUDRed3.Maximum = 255
            NUDRed3.Value = 0

            NUDRed4.Minimum = 0
            NUDRed4.Maximum = 255
            NUDRed4.Value = 0


            CBMascara1.SelectedIndex = 8
            CBMascara2.SelectedIndex = 0
            CBMascara3.SelectedIndex = 0
            CBMascara4.SelectedIndex = 0

            CBMascaraSub1.SelectedIndex = 8
            CBMascaraSub2.SelectedIndex = 0
            CBMascaraSub3.SelectedIndex = 0
            CBMascaraSub4.SelectedIndex = 0

            NUDcidr.Value = 8

        End If

    End Sub


    Private Sub RBClaseB_CheckedChanged(sender As Object, e As EventArgs) Handles RBClaseB.CheckedChanged
        'Clase B:  172.16.0.0 a 172.31.255.255 (16 bits red, 16 bits hosts)

        If sender.checked = True Then
            NUDRed1.Minimum = 172
            NUDRed1.Maximum = 172
            NUDRed1.Value = 172

            NUDRed2.Minimum = 16
            NUDRed2.Maximum = 31
            NUDRed2.Value = 16

            NUDRed3.Minimum = 0
            NUDRed3.Maximum = 255
            NUDRed3.Value = 0

            NUDRed4.Minimum = 0
            NUDRed4.Maximum = 255
            NUDRed4.Value = 0

            CBMascara1.SelectedIndex = 8
            CBMascara2.SelectedIndex = 8
            CBMascara3.SelectedIndex = 0
            CBMascara4.SelectedIndex = 0

            CBMascaraSub1.SelectedIndex = 8
            CBMascaraSub2.SelectedIndex = 8
            CBMascaraSub3.SelectedIndex = 0
            CBMascaraSub4.SelectedIndex = 0

            NUDcidr.Value = 16
        End If

    End Sub

    Private Sub RBClaseC_CheckedChanged(sender As Object, e As EventArgs) Handles RBClaseC.CheckedChanged
        'Clase C:  192.168.0.0 a 192.168.255.255 (24 bits red, 8 bits hosts)

        If sender.checked = True Then
            NUDRed1.Minimum = 192
            NUDRed1.Maximum = 192
            NUDRed1.Value = 192

            NUDRed2.Minimum = 168
            NUDRed2.Maximum = 168
            NUDRed2.Value = 168

            NUDRed3.Minimum = 0
            NUDRed3.Maximum = 255
            NUDRed3.Value = 0

            NUDRed4.Minimum = 0
            NUDRed4.Maximum = 255
            NUDRed4.Value = 0

            CBMascara1.SelectedIndex = 8
            CBMascara2.SelectedIndex = 8
            CBMascara3.SelectedIndex = 8
            CBMascara4.SelectedIndex = 0

            CBMascaraSub1.SelectedIndex = 8
            CBMascaraSub2.SelectedIndex = 8
            CBMascaraSub3.SelectedIndex = 8
            CBMascaraSub4.SelectedIndex = 0


            NUDcidr.Value = 24

        End If

    End Sub




    ' --------------------------------------------------------------------------------------------------------------
    ' --------------------------------------------------------------------------------------------------------------
    ' -------------------------------  Eventos para el cambio de la mascara de red  --------------------------------
    ' --------------------------------------------------------------------------------------------------------------
    ' --------------------------------------------------------------------------------------------------------------


    Private Sub RBcidr_CheckedChanged(sender As Object, e As EventArgs) Handles RBcidr.CheckedChanged

        If RBcidr.Checked = True Then

            CBMascara1.Enabled = False
            CBMascara2.Enabled = False
            CBMascara3.Enabled = False
            CBMascara4.Enabled = False
            NUDcidr.Enabled = True

        End If


    End Sub

    Private Sub RBMascara_CheckedChanged(sender As Object, e As EventArgs) Handles RBMascara.CheckedChanged

        If RBMascara.Checked = True Then

            CBMascara1.Enabled = True

            If CBMascara1.SelectedIndex = 8 Then CBMascara2.Enabled = True Else CBMascara2.Enabled = False

            If CBMascara2.SelectedIndex = 8 Then CBMascara3.Enabled = True Else CBMascara3.Enabled = False

            If CBMascara3.SelectedIndex = 8 Then CBMascara4.Enabled = True Else CBMascara4.Enabled = False

            NUDcidr.Enabled = False
            Select Case NUDcidr.Value
                Case < 8
                    CBMascara1.SelectedIndex = NUDcidr.Value
                Case 8 To 16
                    CBMascara1.SelectedIndex = 8
                    CBMascara2.SelectedIndex = NUDcidr.Value - 8
                Case 17 To 24
                    CBMascara1.SelectedIndex = 8
                    CBMascara2.SelectedIndex = 8
                    CBMascara3.SelectedIndex = NUDcidr.Value - 16
                Case > 24
                    CBMascara1.SelectedIndex = 8
                    CBMascara2.SelectedIndex = 8
                    CBMascara3.SelectedIndex = 8
                    CBMascara4.SelectedIndex = NUDcidr.Value - 24
            End Select

        End If


    End Sub

    Private Sub NUDcidr_ValueChanged(sender As Object, e As EventArgs) Handles NUDcidr.ValueChanged

        Select Case NUDcidr.Value
            Case 0 To 8
                CBMascara1.SelectedIndex = NUDcidr.Value
                CBMascara2.SelectedIndex = 0
                CBMascara3.SelectedIndex = 0
                CBMascara4.SelectedIndex = 0
            Case 9 To 16
                CBMascara1.SelectedIndex = 8
                CBMascara2.SelectedIndex = NUDcidr.Value - 8
                CBMascara3.SelectedIndex = 0
                CBMascara4.SelectedIndex = 0
            Case 17 To 24
                CBMascara1.SelectedIndex = 8
                CBMascara2.SelectedIndex = 8
                CBMascara3.SelectedIndex = NUDcidr.Value - 16
                CBMascara4.SelectedIndex = 0
            Case > 24
                CBMascara1.SelectedIndex = 8
                CBMascara2.SelectedIndex = 8
                CBMascara3.SelectedIndex = 8
                CBMascara4.SelectedIndex = NUDcidr.Value - 24
        End Select

        NUDCIDRSub.Minimum = NUDcidr.Value

    End Sub

    Private Sub CBMascara1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMascara1.SelectedIndexChanged

        If CBMascara1.SelectedIndex = 8 Then CBMascara2.Enabled = True Else CBMascara2.Enabled = False

        CBMascara2.SelectedIndex = 0
        CBMascara3.Enabled = False
        CBMascara3.SelectedIndex = 0
        CBMascara4.Enabled = False
        CBMascara4.SelectedIndex = 0

        NUDcidr.Value = CBMascara1.SelectedIndex + CBMascara2.SelectedIndex + CBMascara3.SelectedIndex + CBMascara4.SelectedIndex

    End Sub

    Private Sub CBMascara2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMascara2.SelectedIndexChanged

        If CBMascara2.SelectedIndex = 8 Then CBMascara3.Enabled = True Else CBMascara3.Enabled = False

        CBMascara3.SelectedIndex = 0
        CBMascara4.Enabled = False
        CBMascara4.SelectedIndex = 0

        NUDcidr.Value = CBMascara1.SelectedIndex + CBMascara2.SelectedIndex + CBMascara3.SelectedIndex + CBMascara4.SelectedIndex

    End Sub

    Private Sub CBMascara3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMascara3.SelectedIndexChanged

        If CBMascara3.SelectedIndex = 8 Then CBMascara4.Enabled = True Else CBMascara4.Enabled = False

        CBMascara4.SelectedIndex = 0

        NUDcidr.Value = CBMascara1.SelectedIndex + CBMascara2.SelectedIndex + CBMascara3.SelectedIndex + CBMascara4.SelectedIndex

    End Sub

    Private Sub CBMascara4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMascara4.SelectedIndexChanged

        NUDcidr.Value = CBMascara1.SelectedIndex + CBMascara2.SelectedIndex + CBMascara3.SelectedIndex + CBMascara4.SelectedIndex

    End Sub




    ' --------------------------------------------------------------------------------------------------------------
    ' --------------------------------------------------------------------------------------------------------------
    ' -------------------------------  Eventos para el cambio de la mascara de subred  --------------------------------
    ' --------------------------------------------------------------------------------------------------------------
    ' --------------------------------------------------------------------------------------------------------------


    Private Sub RBcidrSub_CheckedChanged(sender As Object, e As EventArgs) Handles RBCIDRSub.CheckedChanged

        If RBCIDRSub.Checked = True Then

            CBMascaraSub1.Enabled = False
            CBMascaraSub2.Enabled = False
            CBMascaraSub3.Enabled = False
            CBMascaraSub4.Enabled = False
            NUDCIDRSub.Enabled = True

        End If


    End Sub

    Private Sub RBMascarasub_CheckedChanged(sender As Object, e As EventArgs) Handles RBMascaraSub.CheckedChanged

        If RBMascaraSub.Checked = True Then

            CBMascaraSub1.Enabled = True
            If CBMascaraSub1.SelectedIndex = 8 Then CBMascaraSub2.Enabled = True Else CBMascaraSub2.Enabled = False

            If CBMascaraSub2.SelectedIndex = 8 Then CBMascaraSub3.Enabled = True Else CBMascaraSub3.Enabled = False

            If CBMascaraSub3.SelectedIndex = 8 Then CBMascaraSub4.Enabled = True Else CBMascaraSub4.Enabled = False

            NUDCIDRSub.Enabled = False

            Select Case NUDCIDRSub.Value
                Case < 8
                    CBMascaraSub1.SelectedIndex = NUDCIDRSub.Value
                Case 8 To 16
                    CBMascaraSub1.SelectedIndex = 8
                    CBMascaraSub2.SelectedIndex = NUDCIDRSub.Value - 8
                Case 17 To 24
                    CBMascaraSub1.SelectedIndex = 8
                    CBMascaraSub2.SelectedIndex = 8
                    CBMascaraSub3.SelectedIndex = NUDCIDRSub.Value - 16
                Case > 24
                    CBMascaraSub1.SelectedIndex = 8
                    CBMascaraSub2.SelectedIndex = 8
                    CBMascaraSub3.SelectedIndex = 8
                    CBMascaraSub4.SelectedIndex = NUDCIDRSub.Value - 24
            End Select

        End If


    End Sub

    Private Sub NUDcidrsub_ValueChanged(sender As Object, e As EventArgs) Handles NUDCIDRSub.ValueChanged

        Select Case NUDCIDRSub.Value
            Case 0 To 8
                CBMascaraSub1.SelectedIndex = NUDCIDRSub.Value
                'CBMascaraSub2.SelectedIndex = 0
                'CBMascaraSub3.SelectedIndex = 0
                'CBMascaraSub4.SelectedIndex = 0
            Case 9 To 16
                CBMascaraSub1.SelectedIndex = 8
                CBMascaraSub2.SelectedIndex = NUDCIDRSub.Value - 8
                'CBMascaraSub3.SelectedIndex = 0
                'CBMascaraSub4.SelectedIndex = 0
            Case 17 To 24
                CBMascaraSub1.SelectedIndex = 8
                CBMascaraSub2.SelectedIndex = 8
                CBMascaraSub3.SelectedIndex = NUDCIDRSub.Value - 16
                'CBMascaraSub4.SelectedIndex = 0
            Case > 24
                CBMascaraSub1.SelectedIndex = 8
                CBMascaraSub2.SelectedIndex = 8
                CBMascaraSub3.SelectedIndex = 8
                CBMascaraSub4.SelectedIndex = NUDCIDRSub.Value - 24
        End Select

    End Sub

    Private Sub CBMascarasub1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMascaraSub1.SelectedIndexChanged

        Dim valor As Byte

        valor = CBMascaraSub1.SelectedIndex + CBMascaraSub2.SelectedIndex + CBMascaraSub3.SelectedIndex + CBMascaraSub4.SelectedIndex

        If valor < NUDcidr.Value Then
            CBMascaraSub1.SelectedIndex = CBMascara1.SelectedIndex
            Return
        End If

        If CBMascaraSub1.SelectedIndex = 8 Then CBMascaraSub2.Enabled = True Else CBMascaraSub2.Enabled = False

        CBMascaraSub2.SelectedIndex = 0
        CBMascaraSub3.Enabled = False
        CBMascaraSub3.SelectedIndex = 0
        CBMascaraSub4.Enabled = False
        CBMascaraSub4.SelectedIndex = 0

        NUDCIDRSub.Value = valor

    End Sub

    Private Sub CBMascarasub2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMascaraSub2.SelectedIndexChanged

        Dim valor As Byte

        valor = CBMascaraSub1.SelectedIndex + CBMascaraSub2.SelectedIndex + CBMascaraSub3.SelectedIndex + CBMascaraSub4.SelectedIndex

        If valor < NUDcidr.Value Then
            CBMascaraSub2.SelectedIndex = CBMascara2.SelectedIndex
            Return
        End If

        If CBMascaraSub2.SelectedIndex = 8 Then CBMascaraSub3.Enabled = True Else CBMascaraSub3.Enabled = False

        CBMascaraSub3.SelectedIndex = 0
        CBMascaraSub4.Enabled = False
        CBMascaraSub4.SelectedIndex = 0

        NUDCIDRSub.Value = valor

    End Sub

    Private Sub CBMascarasub3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMascaraSub3.SelectedIndexChanged

        Dim valor As Byte

        valor = CBMascaraSub1.SelectedIndex + CBMascaraSub2.SelectedIndex + CBMascaraSub3.SelectedIndex + CBMascaraSub4.SelectedIndex

        If valor < NUDcidr.Value Then
            CBMascaraSub3.SelectedIndex = CBMascara3.SelectedIndex
            Return
        End If

        If CBMascaraSub3.SelectedIndex = 8 Then CBMascaraSub4.Enabled = True Else CBMascaraSub4.Enabled = False

        CBMascaraSub4.SelectedIndex = 0

        NUDCIDRSub.Value = valor

    End Sub

    Private Sub CBMascarasub4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMascaraSub4.SelectedIndexChanged

        Dim valor As Byte

        valor = CBMascaraSub1.SelectedIndex + CBMascaraSub2.SelectedIndex + CBMascaraSub3.SelectedIndex + CBMascaraSub4.SelectedIndex

        If valor < NUDcidr.Value Then
            CBMascaraSub4.SelectedIndex = CBMascara4.SelectedIndex
            Return
        End If

        NUDCIDRSub.Value = valor

    End Sub

End Class
