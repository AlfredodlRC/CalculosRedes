<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.NUDRed1 = New System.Windows.Forms.NumericUpDown()
        Me.NUDRed2 = New System.Windows.Forms.NumericUpDown()
        Me.NUDRed3 = New System.Windows.Forms.NumericUpDown()
        Me.NUDRed4 = New System.Windows.Forms.NumericUpDown()
        Me.LblDireccionIP = New System.Windows.Forms.Label()
        Me.RBClaseA = New System.Windows.Forms.RadioButton()
        Me.RBClaseC = New System.Windows.Forms.RadioButton()
        Me.RBClaseB = New System.Windows.Forms.RadioButton()
        Me.GBClaseRed = New System.Windows.Forms.GroupBox()
        Me.CBMascara1 = New System.Windows.Forms.ComboBox()
        Me.CBMascara2 = New System.Windows.Forms.ComboBox()
        Me.CBMascara3 = New System.Windows.Forms.ComboBox()
        Me.CBMascara4 = New System.Windows.Forms.ComboBox()
        Me.NUDcicd = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblMascaraRed = New System.Windows.Forms.Label()
        Me.GBEleccionMascara = New System.Windows.Forms.GroupBox()
        Me.RBMascara = New System.Windows.Forms.RadioButton()
        Me.RBcicd = New System.Windows.Forms.RadioButton()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.LblDirRed = New System.Windows.Forms.Label()
        Me.LblDirBroadcast = New System.Windows.Forms.Label()
        Me.LblDirUltima = New System.Windows.Forms.Label()
        Me.LblDirPrimera = New System.Windows.Forms.Label()
        Me.LblNuHosts = New System.Windows.Forms.Label()
        Me.LblNuDir = New System.Windows.Forms.Label()
        Me.TBRed = New System.Windows.Forms.TextBox()
        Me.TBBroadcast = New System.Windows.Forms.TextBox()
        Me.TBDireccionUltima = New System.Windows.Forms.TextBox()
        Me.TBDireccionPrimera = New System.Windows.Forms.TextBox()
        Me.TBCantidadDirecciones = New System.Windows.Forms.TextBox()
        Me.TBNumeroEquipos = New System.Windows.Forms.TextBox()
        Me.LblMascaraSubred = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NUDCICDSub = New System.Windows.Forms.NumericUpDown()
        Me.CBMascaraSub4 = New System.Windows.Forms.ComboBox()
        Me.CBMascaraSub3 = New System.Windows.Forms.ComboBox()
        Me.CBMascaraSub2 = New System.Windows.Forms.ComboBox()
        Me.CBMascaraSub1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBMascaraSub = New System.Windows.Forms.RadioButton()
        Me.RBCICDSub = New System.Windows.Forms.RadioButton()
        CType(Me.NUDRed1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDRed2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDRed3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDRed4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBClaseRed.SuspendLayout()
        CType(Me.NUDcicd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBEleccionMascara.SuspendLayout()
        CType(Me.NUDCICDSub, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NUDRed1
        '
        Me.NUDRed1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.NUDRed1.Location = New System.Drawing.Point(150, 38)
        Me.NUDRed1.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NUDRed1.Name = "NUDRed1"
        Me.NUDRed1.Size = New System.Drawing.Size(66, 27)
        Me.NUDRed1.TabIndex = 0
        '
        'NUDRed2
        '
        Me.NUDRed2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.NUDRed2.Location = New System.Drawing.Point(241, 38)
        Me.NUDRed2.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NUDRed2.Name = "NUDRed2"
        Me.NUDRed2.Size = New System.Drawing.Size(66, 27)
        Me.NUDRed2.TabIndex = 1
        '
        'NUDRed3
        '
        Me.NUDRed3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.NUDRed3.Location = New System.Drawing.Point(332, 38)
        Me.NUDRed3.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NUDRed3.Name = "NUDRed3"
        Me.NUDRed3.Size = New System.Drawing.Size(66, 27)
        Me.NUDRed3.TabIndex = 2
        '
        'NUDRed4
        '
        Me.NUDRed4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.NUDRed4.Location = New System.Drawing.Point(423, 38)
        Me.NUDRed4.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NUDRed4.Name = "NUDRed4"
        Me.NUDRed4.Size = New System.Drawing.Size(66, 27)
        Me.NUDRed4.TabIndex = 3
        '
        'LblDireccionIP
        '
        Me.LblDireccionIP.AutoSize = True
        Me.LblDireccionIP.Location = New System.Drawing.Point(54, 41)
        Me.LblDireccionIP.Name = "LblDireccionIP"
        Me.LblDireccionIP.Size = New System.Drawing.Size(95, 20)
        Me.LblDireccionIP.TabIndex = 4
        Me.LblDireccionIP.Text = "Dirección IP :"
        '
        'RBClaseA
        '
        Me.RBClaseA.AutoSize = True
        Me.RBClaseA.Location = New System.Drawing.Point(13, 26)
        Me.RBClaseA.Name = "RBClaseA"
        Me.RBClaseA.Size = New System.Drawing.Size(40, 24)
        Me.RBClaseA.TabIndex = 5
        Me.RBClaseA.TabStop = True
        Me.RBClaseA.Text = "A"
        Me.RBClaseA.UseVisualStyleBackColor = True
        '
        'RBClaseC
        '
        Me.RBClaseC.AutoSize = True
        Me.RBClaseC.Location = New System.Drawing.Point(126, 26)
        Me.RBClaseC.Name = "RBClaseC"
        Me.RBClaseC.Size = New System.Drawing.Size(39, 24)
        Me.RBClaseC.TabIndex = 6
        Me.RBClaseC.TabStop = True
        Me.RBClaseC.Text = "C"
        Me.RBClaseC.UseVisualStyleBackColor = True
        '
        'RBClaseB
        '
        Me.RBClaseB.AutoSize = True
        Me.RBClaseB.Location = New System.Drawing.Point(70, 26)
        Me.RBClaseB.Name = "RBClaseB"
        Me.RBClaseB.Size = New System.Drawing.Size(39, 24)
        Me.RBClaseB.TabIndex = 7
        Me.RBClaseB.TabStop = True
        Me.RBClaseB.Text = "B"
        Me.RBClaseB.UseVisualStyleBackColor = True
        '
        'GBClaseRed
        '
        Me.GBClaseRed.Controls.Add(Me.RBClaseB)
        Me.GBClaseRed.Controls.Add(Me.RBClaseA)
        Me.GBClaseRed.Controls.Add(Me.RBClaseC)
        Me.GBClaseRed.Location = New System.Drawing.Point(637, 12)
        Me.GBClaseRed.Name = "GBClaseRed"
        Me.GBClaseRed.Size = New System.Drawing.Size(185, 59)
        Me.GBClaseRed.TabIndex = 8
        Me.GBClaseRed.TabStop = False
        Me.GBClaseRed.Text = "Clase"
        '
        'CBMascara1
        '
        Me.CBMascara1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.CBMascara1.FormattingEnabled = True
        Me.CBMascara1.Items.AddRange(New Object() {"0", "128", "192", "224", "240", "248", "252", "254", "255"})
        Me.CBMascara1.Location = New System.Drawing.Point(152, 102)
        Me.CBMascara1.Name = "CBMascara1"
        Me.CBMascara1.Size = New System.Drawing.Size(66, 28)
        Me.CBMascara1.TabIndex = 9
        '
        'CBMascara2
        '
        Me.CBMascara2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.CBMascara2.FormattingEnabled = True
        Me.CBMascara2.Items.AddRange(New Object() {"0", "128", "192", "224", "240", "248", "252", "254", "255"})
        Me.CBMascara2.Location = New System.Drawing.Point(243, 102)
        Me.CBMascara2.Name = "CBMascara2"
        Me.CBMascara2.Size = New System.Drawing.Size(66, 28)
        Me.CBMascara2.TabIndex = 10
        '
        'CBMascara3
        '
        Me.CBMascara3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.CBMascara3.FormattingEnabled = True
        Me.CBMascara3.Items.AddRange(New Object() {"0", "128", "192", "224", "240", "248", "252", "254", "255"})
        Me.CBMascara3.Location = New System.Drawing.Point(334, 102)
        Me.CBMascara3.Name = "CBMascara3"
        Me.CBMascara3.Size = New System.Drawing.Size(66, 28)
        Me.CBMascara3.TabIndex = 11
        '
        'CBMascara4
        '
        Me.CBMascara4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.CBMascara4.FormattingEnabled = True
        Me.CBMascara4.Items.AddRange(New Object() {"0", "128", "192", "224", "240", "248", "252", "254", "255"})
        Me.CBMascara4.Location = New System.Drawing.Point(425, 102)
        Me.CBMascara4.Name = "CBMascara4"
        Me.CBMascara4.Size = New System.Drawing.Size(66, 28)
        Me.CBMascara4.TabIndex = 12
        '
        'NUDcicd
        '
        Me.NUDcicd.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.NUDcicd.Location = New System.Drawing.Point(550, 103)
        Me.NUDcicd.Maximum = New Decimal(New Integer() {32, 0, 0, 0})
        Me.NUDcicd.Name = "NUDcicd"
        Me.NUDcicd.Size = New System.Drawing.Size(66, 27)
        Me.NUDcicd.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(501, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "CICD :"
        '
        'LblMascaraRed
        '
        Me.LblMascaraRed.AutoSize = True
        Me.LblMascaraRed.Location = New System.Drawing.Point(37, 106)
        Me.LblMascaraRed.Name = "LblMascaraRed"
        Me.LblMascaraRed.Size = New System.Drawing.Size(114, 20)
        Me.LblMascaraRed.TabIndex = 15
        Me.LblMascaraRed.Text = "Mascara de red:"
        '
        'GBEleccionMascara
        '
        Me.GBEleccionMascara.Controls.Add(Me.RBMascara)
        Me.GBEleccionMascara.Controls.Add(Me.RBcicd)
        Me.GBEleccionMascara.Location = New System.Drawing.Point(637, 77)
        Me.GBEleccionMascara.Name = "GBEleccionMascara"
        Me.GBEleccionMascara.Size = New System.Drawing.Size(176, 58)
        Me.GBEleccionMascara.TabIndex = 16
        Me.GBEleccionMascara.TabStop = False
        Me.GBEleccionMascara.Text = "Elección por"
        '
        'RBMascara
        '
        Me.RBMascara.AutoSize = True
        Me.RBMascara.Location = New System.Drawing.Point(5, 26)
        Me.RBMascara.Name = "RBMascara"
        Me.RBMascara.Size = New System.Drawing.Size(85, 24)
        Me.RBMascara.TabIndex = 18
        Me.RBMascara.TabStop = True
        Me.RBMascara.Text = "Mascara"
        Me.RBMascara.UseVisualStyleBackColor = True
        '
        'RBcicd
        '
        Me.RBcicd.AutoSize = True
        Me.RBcicd.Location = New System.Drawing.Point(107, 26)
        Me.RBcicd.Name = "RBcicd"
        Me.RBcicd.Size = New System.Drawing.Size(63, 24)
        Me.RBcicd.TabIndex = 17
        Me.RBcicd.TabStop = True
        Me.RBcicd.Text = "CICD"
        Me.RBcicd.UseVisualStyleBackColor = True
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCalcular.Font = New System.Drawing.Font("SERomanc", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnCalcular.Location = New System.Drawing.Point(434, 234)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(388, 120)
        Me.BtnCalcular.TabIndex = 17
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.OrangeRed
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLimpiar.Font = New System.Drawing.Font("SERomanc", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.Khaki
        Me.BtnLimpiar.Location = New System.Drawing.Point(28, 268)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(388, 53)
        Me.BtnLimpiar.TabIndex = 18
        Me.BtnLimpiar.Text = "Limpiar datos"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'LblDirRed
        '
        Me.LblDirRed.AutoSize = True
        Me.LblDirRed.Location = New System.Drawing.Point(84, 376)
        Me.LblDirRed.Name = "LblDirRed"
        Me.LblDirRed.Size = New System.Drawing.Size(101, 20)
        Me.LblDirRed.TabIndex = 19
        Me.LblDirRed.Text = "Dirección red:"
        '
        'LblDirBroadcast
        '
        Me.LblDirBroadcast.AutoSize = True
        Me.LblDirBroadcast.Location = New System.Drawing.Point(40, 424)
        Me.LblDirBroadcast.Name = "LblDirBroadcast"
        Me.LblDirBroadcast.Size = New System.Drawing.Size(145, 20)
        Me.LblDirBroadcast.TabIndex = 20
        Me.LblDirBroadcast.Text = "Dirección broadcast:"
        '
        'LblDirUltima
        '
        Me.LblDirUltima.AutoSize = True
        Me.LblDirUltima.Location = New System.Drawing.Point(334, 424)
        Me.LblDirUltima.Name = "LblDirUltima"
        Me.LblDirUltima.Size = New System.Drawing.Size(121, 20)
        Me.LblDirUltima.TabIndex = 21
        Me.LblDirUltima.Text = "Dirección última:"
        '
        'LblDirPrimera
        '
        Me.LblDirPrimera.AutoSize = True
        Me.LblDirPrimera.Location = New System.Drawing.Point(324, 376)
        Me.LblDirPrimera.Name = "LblDirPrimera"
        Me.LblDirPrimera.Size = New System.Drawing.Size(131, 20)
        Me.LblDirPrimera.TabIndex = 22
        Me.LblDirPrimera.Text = "Dirección primera:"
        '
        'LblNuHosts
        '
        Me.LblNuHosts.AutoSize = True
        Me.LblNuHosts.Location = New System.Drawing.Point(311, 473)
        Me.LblNuHosts.Name = "LblNuHosts"
        Me.LblNuHosts.Size = New System.Drawing.Size(144, 20)
        Me.LblNuHosts.TabIndex = 23
        Me.LblNuHosts.Text = "Número de equipos:"
        '
        'LblNuDir
        '
        Me.LblNuDir.AutoSize = True
        Me.LblNuDir.Location = New System.Drawing.Point(13, 473)
        Me.LblNuDir.Name = "LblNuDir"
        Me.LblNuDir.Size = New System.Drawing.Size(172, 20)
        Me.LblNuDir.TabIndex = 24
        Me.LblNuDir.Text = "Cantidad de direcciones:"
        '
        'TBRed
        '
        Me.TBRed.Enabled = False
        Me.TBRed.Location = New System.Drawing.Point(182, 373)
        Me.TBRed.Name = "TBRed"
        Me.TBRed.Size = New System.Drawing.Size(125, 27)
        Me.TBRed.TabIndex = 25
        '
        'TBBroadcast
        '
        Me.TBBroadcast.Enabled = False
        Me.TBBroadcast.Location = New System.Drawing.Point(182, 421)
        Me.TBBroadcast.Name = "TBBroadcast"
        Me.TBBroadcast.Size = New System.Drawing.Size(125, 27)
        Me.TBBroadcast.TabIndex = 26
        '
        'TBDireccionUltima
        '
        Me.TBDireccionUltima.Enabled = False
        Me.TBDireccionUltima.Location = New System.Drawing.Point(451, 421)
        Me.TBDireccionUltima.Name = "TBDireccionUltima"
        Me.TBDireccionUltima.Size = New System.Drawing.Size(125, 27)
        Me.TBDireccionUltima.TabIndex = 28
        '
        'TBDireccionPrimera
        '
        Me.TBDireccionPrimera.Enabled = False
        Me.TBDireccionPrimera.Location = New System.Drawing.Point(450, 373)
        Me.TBDireccionPrimera.Name = "TBDireccionPrimera"
        Me.TBDireccionPrimera.Size = New System.Drawing.Size(125, 27)
        Me.TBDireccionPrimera.TabIndex = 27
        '
        'TBCantidadDirecciones
        '
        Me.TBCantidadDirecciones.Enabled = False
        Me.TBCantidadDirecciones.Location = New System.Drawing.Point(182, 470)
        Me.TBCantidadDirecciones.Name = "TBCantidadDirecciones"
        Me.TBCantidadDirecciones.Size = New System.Drawing.Size(125, 27)
        Me.TBCantidadDirecciones.TabIndex = 30
        '
        'TBNumeroEquipos
        '
        Me.TBNumeroEquipos.Enabled = False
        Me.TBNumeroEquipos.Location = New System.Drawing.Point(451, 470)
        Me.TBNumeroEquipos.Name = "TBNumeroEquipos"
        Me.TBNumeroEquipos.Size = New System.Drawing.Size(125, 27)
        Me.TBNumeroEquipos.TabIndex = 29
        '
        'LblMascaraSubred
        '
        Me.LblMascaraSubred.AutoSize = True
        Me.LblMascaraSubred.Location = New System.Drawing.Point(15, 177)
        Me.LblMascaraSubred.Name = "LblMascaraSubred"
        Me.LblMascaraSubred.Size = New System.Drawing.Size(137, 20)
        Me.LblMascaraSubred.TabIndex = 37
        Me.LblMascaraSubred.Text = "Mascara de subred:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(499, 177)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 20)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "CICD :"
        '
        'NUDCICDSub
        '
        Me.NUDCICDSub.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.NUDCICDSub.Location = New System.Drawing.Point(548, 174)
        Me.NUDCICDSub.Maximum = New Decimal(New Integer() {32, 0, 0, 0})
        Me.NUDCICDSub.Name = "NUDCICDSub"
        Me.NUDCICDSub.Size = New System.Drawing.Size(66, 27)
        Me.NUDCICDSub.TabIndex = 35
        '
        'CBMascaraSub4
        '
        Me.CBMascaraSub4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.CBMascaraSub4.FormattingEnabled = True
        Me.CBMascaraSub4.Items.AddRange(New Object() {"0", "128", "192", "224", "240", "248", "252", "254", "255"})
        Me.CBMascaraSub4.Location = New System.Drawing.Point(423, 173)
        Me.CBMascaraSub4.Name = "CBMascaraSub4"
        Me.CBMascaraSub4.Size = New System.Drawing.Size(66, 28)
        Me.CBMascaraSub4.TabIndex = 34
        '
        'CBMascaraSub3
        '
        Me.CBMascaraSub3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.CBMascaraSub3.FormattingEnabled = True
        Me.CBMascaraSub3.Items.AddRange(New Object() {"0", "128", "192", "224", "240", "248", "252", "254", "255"})
        Me.CBMascaraSub3.Location = New System.Drawing.Point(332, 173)
        Me.CBMascaraSub3.Name = "CBMascaraSub3"
        Me.CBMascaraSub3.Size = New System.Drawing.Size(66, 28)
        Me.CBMascaraSub3.TabIndex = 33
        '
        'CBMascaraSub2
        '
        Me.CBMascaraSub2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.CBMascaraSub2.FormattingEnabled = True
        Me.CBMascaraSub2.Items.AddRange(New Object() {"0", "128", "192", "224", "240", "248", "252", "254", "255"})
        Me.CBMascaraSub2.Location = New System.Drawing.Point(241, 173)
        Me.CBMascaraSub2.Name = "CBMascaraSub2"
        Me.CBMascaraSub2.Size = New System.Drawing.Size(66, 28)
        Me.CBMascaraSub2.TabIndex = 32
        '
        'CBMascaraSub1
        '
        Me.CBMascaraSub1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.CBMascaraSub1.FormattingEnabled = True
        Me.CBMascaraSub1.Items.AddRange(New Object() {"0", "128", "192", "224", "240", "248", "252", "254", "255"})
        Me.CBMascaraSub1.Location = New System.Drawing.Point(150, 173)
        Me.CBMascaraSub1.Name = "CBMascaraSub1"
        Me.CBMascaraSub1.Size = New System.Drawing.Size(66, 28)
        Me.CBMascaraSub1.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBMascaraSub)
        Me.GroupBox1.Controls.Add(Me.RBCICDSub)
        Me.GroupBox1.Location = New System.Drawing.Point(637, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(176, 58)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elección por"
        '
        'RBMascaraSub
        '
        Me.RBMascaraSub.AutoSize = True
        Me.RBMascaraSub.Location = New System.Drawing.Point(5, 26)
        Me.RBMascaraSub.Name = "RBMascaraSub"
        Me.RBMascaraSub.Size = New System.Drawing.Size(85, 24)
        Me.RBMascaraSub.TabIndex = 18
        Me.RBMascaraSub.TabStop = True
        Me.RBMascaraSub.Text = "Mascara"
        Me.RBMascaraSub.UseVisualStyleBackColor = True
        '
        'RBCICDSub
        '
        Me.RBCICDSub.AutoSize = True
        Me.RBCICDSub.Location = New System.Drawing.Point(107, 26)
        Me.RBCICDSub.Name = "RBCICDSub"
        Me.RBCICDSub.Size = New System.Drawing.Size(63, 24)
        Me.RBCICDSub.TabIndex = 17
        Me.RBCICDSub.TabStop = True
        Me.RBCICDSub.Text = "CICD"
        Me.RBCICDSub.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ClientSize = New System.Drawing.Size(851, 518)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblMascaraSubred)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.NUDCICDSub)
        Me.Controls.Add(Me.CBMascaraSub4)
        Me.Controls.Add(Me.CBMascaraSub3)
        Me.Controls.Add(Me.CBMascaraSub2)
        Me.Controls.Add(Me.CBMascaraSub1)
        Me.Controls.Add(Me.TBCantidadDirecciones)
        Me.Controls.Add(Me.TBNumeroEquipos)
        Me.Controls.Add(Me.TBDireccionUltima)
        Me.Controls.Add(Me.TBDireccionPrimera)
        Me.Controls.Add(Me.TBBroadcast)
        Me.Controls.Add(Me.TBRed)
        Me.Controls.Add(Me.LblNuDir)
        Me.Controls.Add(Me.LblNuHosts)
        Me.Controls.Add(Me.LblDirPrimera)
        Me.Controls.Add(Me.LblDirUltima)
        Me.Controls.Add(Me.LblDirBroadcast)
        Me.Controls.Add(Me.LblDirRed)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.GBEleccionMascara)
        Me.Controls.Add(Me.LblMascaraRed)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NUDcicd)
        Me.Controls.Add(Me.CBMascara4)
        Me.Controls.Add(Me.CBMascara3)
        Me.Controls.Add(Me.CBMascara2)
        Me.Controls.Add(Me.CBMascara1)
        Me.Controls.Add(Me.GBClaseRed)
        Me.Controls.Add(Me.LblDireccionIP)
        Me.Controls.Add(Me.NUDRed4)
        Me.Controls.Add(Me.NUDRed3)
        Me.Controls.Add(Me.NUDRed2)
        Me.Controls.Add(Me.NUDRed1)
        Me.Name = "Form1"
        Me.Text = "Calculo redes"
        CType(Me.NUDRed1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDRed2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDRed3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDRed4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBClaseRed.ResumeLayout(False)
        Me.GBClaseRed.PerformLayout()
        CType(Me.NUDcicd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBEleccionMascara.ResumeLayout(False)
        Me.GBEleccionMascara.PerformLayout()
        CType(Me.NUDCICDSub, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NUDRed1 As NumericUpDown
    Friend WithEvents NUDRed2 As NumericUpDown
    Friend WithEvents NUDRed3 As NumericUpDown
    Friend WithEvents NUDRed4 As NumericUpDown
    Friend WithEvents LblDireccionIP As Label
    Friend WithEvents RBClaseA As RadioButton
    Friend WithEvents RBClaseC As RadioButton
    Friend WithEvents RBClaseB As RadioButton
    Friend WithEvents GBClaseRed As GroupBox
    Friend WithEvents CBMascara1 As ComboBox
    Friend WithEvents CBMascara2 As ComboBox
    Friend WithEvents CBMascara3 As ComboBox
    Friend WithEvents CBMascara4 As ComboBox
    Friend WithEvents NUDcicd As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents LblMascaraRed As Label
    Friend WithEvents GBEleccionMascara As GroupBox
    Friend WithEvents RBMascara As RadioButton
    Friend WithEvents RBcicd As RadioButton
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents LblDirRed As Label
    Friend WithEvents LblDirBroadcast As Label
    Friend WithEvents LblDirUltima As Label
    Friend WithEvents LblDirPrimera As Label
    Friend WithEvents LblNuHosts As Label
    Friend WithEvents LblNuDir As Label
    Friend WithEvents TBRed As TextBox
    Friend WithEvents TBBroadcast As TextBox
    Friend WithEvents TBDireccionUltima As TextBox
    Friend WithEvents TBDireccionPrimera As TextBox
    Friend WithEvents TBCantidadDirecciones As TextBox
    Friend WithEvents TBNumeroEquipos As TextBox
    Friend WithEvents LblMascaraSubred As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents NUDCICDSub As NumericUpDown
    Friend WithEvents CBMascaraSub4 As ComboBox
    Friend WithEvents CBMascaraSub3 As ComboBox
    Friend WithEvents CBMascaraSub2 As ComboBox
    Friend WithEvents CBMascaraSub1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBMascaraSub As RadioButton
    Friend WithEvents RBCICDSub As RadioButton
End Class
