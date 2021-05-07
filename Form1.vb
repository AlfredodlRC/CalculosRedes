﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RBClaseA.Checked = True
        RBMascara.Checked = True

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
        For i = 31 To 32 - NUDcicd.Value Step -1
            mascara = mascara + 2 ^ i
        Next i

        red = (((NUDRed1.Value * 256) + NUDRed2.Value) * 256 + NUDRed3.Value) * 256 + NUDRed4.Value

        red = red And mascara

        cantidad = 2 ^ (32 - NUDcicd.Value)

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


        If NUDcicd.Value = 32 Then
            TBCantidadDirecciones.Text = 0
            TBNumeroEquipos.Text = 0
        Else
            TBCantidadDirecciones.Text = cantidad
            TBNumeroEquipos.Text = cantidad - 2
        End If


    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click

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

            NUDRed2.Minimum = 0
            NUDRed2.Maximum = 255
            NUDRed2.Value = 0

            CBMascara1.SelectedIndex = 8
            CBMascara1.Enabled = False
            CBMascara2.SelectedIndex = 0
            CBMascara2.Enabled = True
            CBMascara3.SelectedIndex = 0
            CBMascara3.Enabled = False
            CBMascara4.SelectedIndex = 0
            CBMascara4.Enabled = False
            NUDcicd.Value = 8
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

            NUDRed2.Minimum = 0
            NUDRed2.Maximum = 255
            NUDRed2.Value = 0

            CBMascara1.SelectedIndex = 8
            CBMascara1.Enabled = False
            CBMascara2.SelectedIndex = 8
            CBMascara2.Enabled = False
            CBMascara3.SelectedIndex = 0
            CBMascara3.Enabled = True
            CBMascara4.SelectedIndex = 0
            CBMascara4.Enabled = False
            NUDcicd.Value = 16
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
            CBMascara1.Enabled = False
            CBMascara2.SelectedIndex = 8
            CBMascara2.Enabled = False
            CBMascara3.SelectedIndex = 8
            CBMascara3.Enabled = False
            CBMascara4.SelectedIndex = 0
            CBMascara4.Enabled = True
            NUDcicd.Value = 24

        End If

    End Sub

    ' --------------------------------------------------------------------------------------------------------------
    ' --------------------------------------------------------------------------------------------------------------
    ' -------------------------------  Eventos para el cambio de la mascara de red  --------------------------------
    ' --------------------------------------------------------------------------------------------------------------
    ' --------------------------------------------------------------------------------------------------------------


    Private Sub RBcicd_CheckedChanged(sender As Object, e As EventArgs) Handles RBcicd.CheckedChanged

        If RBcicd.Checked = True Then

            CBMascara1.Enabled = False
            CBMascara2.Enabled = False
            CBMascara3.Enabled = False
            CBMascara4.Enabled = False
            NUDcicd.Enabled = True

        End If


    End Sub

    Private Sub RBMascara_CheckedChanged(sender As Object, e As EventArgs) Handles RBMascara.CheckedChanged

        If RBMascara.Checked = True Then

            CBMascara1.Enabled = True
            If CBMascara1.SelectedIndex = 8 Then
                CBMascara2.Enabled = True
            End If
            If CBMascara2.SelectedIndex = 8 Then
                CBMascara3.Enabled = True
            End If
            If CBMascara3.SelectedIndex = 8 Then
                CBMascara4.Enabled = True
            End If
            NUDcicd.Enabled = False
                Select Case NUDcicd.Value
                    Case < 8
                        CBMascara1.SelectedIndex = NUDcicd.Value
                    Case 8 To 16
                        CBMascara1.SelectedIndex = 8
                        CBMascara2.SelectedIndex = NUDcicd.Value - 8
                    Case 17 To 24
                        CBMascara1.SelectedIndex = 8
                        CBMascara2.SelectedIndex = 8
                        CBMascara3.SelectedIndex = NUDcicd.Value - 16
                    Case > 24
                        CBMascara1.SelectedIndex = 8
                        CBMascara2.SelectedIndex = 8
                        CBMascara3.SelectedIndex = 8
                        CBMascara4.SelectedIndex = NUDcicd.Value - 24
                End Select

            End If


    End Sub

    Private Sub NUDcicd_ValueChanged(sender As Object, e As EventArgs) Handles NUDcicd.ValueChanged
        Select Case NUDcicd.Value
            Case 0 To 8
                CBMascara1.SelectedIndex = NUDcicd.Value
                CBMascara2.SelectedIndex = 0
                CBMascara3.SelectedIndex = 0
                CBMascara4.SelectedIndex = 0
            Case 9 To 16
                CBMascara1.SelectedIndex = 8
                CBMascara2.SelectedIndex = NUDcicd.Value - 8
                CBMascara3.SelectedIndex = 0
                CBMascara4.SelectedIndex = 0
            Case 17 To 24
                CBMascara1.SelectedIndex = 8
                CBMascara2.SelectedIndex = 8
                CBMascara3.SelectedIndex = NUDcicd.Value - 16
                CBMascara4.SelectedIndex = 0
            Case > 24
                CBMascara1.SelectedIndex = 8
                CBMascara2.SelectedIndex = 8
                CBMascara3.SelectedIndex = 8
                CBMascara4.SelectedIndex = NUDcicd.Value - 24
        End Select
    End Sub

    Private Sub CBMascara1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMascara1.SelectedIndexChanged

        If CBMascara1.SelectedIndex = 8 Then
            CBMascara2.Enabled = True
            CBMascara2.SelectedIndex = 0
            CBMascara3.Enabled = False
            CBMascara3.SelectedIndex = 0
            CBMascara4.Enabled = False
            CBMascara4.SelectedIndex = 0
        Else
            CBMascara2.Enabled = False
            CBMascara2.SelectedIndex = 0
            CBMascara3.Enabled = False
            CBMascara3.SelectedIndex = 0
            CBMascara4.Enabled = False
            CBMascara4.SelectedIndex = 0
        End If
        NUDcicd.Value = CBMascara1.SelectedIndex + CBMascara2.SelectedIndex + CBMascara3.SelectedIndex + CBMascara4.SelectedIndex

    End Sub

    Private Sub CBMascara2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMascara2.SelectedIndexChanged

        If CBMascara2.SelectedIndex = 8 Then
            CBMascara3.Enabled = True
            CBMascara3.SelectedIndex = 0
            CBMascara4.Enabled = False
            CBMascara4.SelectedIndex = 0
        Else
            CBMascara3.Enabled = False
            CBMascara3.SelectedIndex = 0
            CBMascara4.Enabled = False
            CBMascara4.SelectedIndex = 0
        End If
        NUDcicd.Value = CBMascara1.SelectedIndex + CBMascara2.SelectedIndex + CBMascara3.SelectedIndex + CBMascara4.SelectedIndex

    End Sub

    Private Sub CBMascara3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMascara3.SelectedIndexChanged

        If CBMascara3.SelectedIndex = 8 Then
            CBMascara4.Enabled = True
            CBMascara4.SelectedIndex = 0
        Else
            CBMascara4.Enabled = False
            CBMascara4.SelectedIndex = 0
        End If

        NUDcicd.Value = CBMascara1.SelectedIndex + CBMascara2.SelectedIndex + CBMascara3.SelectedIndex + CBMascara4.SelectedIndex

    End Sub

    Private Sub CBMascara4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMascara4.SelectedIndexChanged

        NUDcicd.Value = CBMascara1.SelectedIndex + CBMascara2.SelectedIndex + CBMascara3.SelectedIndex + CBMascara4.SelectedIndex

    End Sub


End Class