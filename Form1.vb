Imports System.IO
Imports System.Security.AccessControl
Imports System.Xml
Imports System.Xml.Schema

Public Class Form1

    ''' <summary>
    '''  Subrutina que inicializa datos al cargar el formulario (ventana principal)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Si inicializa las opciones por defecto
        RBClaseA.Checked = True
        RBMascara.Checked = True
        RBMascaraSub.Checked = True
        RBNoSubredes.Checked = True

        ' Se oculta el panel de elección de la máscara de subred
        PnlSubred.Visible = False


        'Se establece los textos cuando se pasa por encima de un control
        Dim Ott As New ToolTip

        Ott.IsBalloon = True

        Ott.InitialDelay = 3000
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
        Ott.SetToolTip(RBNoSubredes, "No se trabajará con subredes")
        Ott.SetToolTip(RBSiSubredes, "Se trabajará con subredes")

        Ott.SetToolTip(TBBroadcast, "Dirección broadcast de la red")
        Ott.SetToolTip(TBCantidadDirecciones, "Número de direcciones que tiene la red")
        Ott.SetToolTip(TBDireccionPrimera, "Primera dirección útil de la red")
        Ott.SetToolTip(TBDireccionUltima, "Última dirección útil de la red")
        Ott.SetToolTip(TBNumeroEquipos, "Número de Equipos que puede haber en la red")
        Ott.SetToolTip(TBRed, "Dirección de la red")

        Ott.SetToolTip(GBClaseRed, "Grupo donde se selecciona la clase da la dirección")
        Ott.SetToolTip(GBEleccionMascara, "Se decide si la máscara de red se selecciona por valor de máscara o por valor cidr")

        Ott.SetToolTip(BtnCalcular, "Botón para realizar los calculos de los datos")
        Ott.SetToolTip(BtnLimpiar, "Resetea los valores por defecto de la entrada y vácia los elementos de sálida")
        Ott.SetToolTip(BtnCargar, "Cargar datos desde un fichero")
        Ott.SetToolTip(BtnGuardar, "Guardar los datos actuales en un fichero")

        Ott.SetToolTip(LblDireccionIP, "Elección de la dirección de red")
        Ott.SetToolTip(LblMascaraRed, "Elección de la máscara de red")
        Ott.SetToolTip(LblMascaraSubred, "Elección de la máscara de subred")

        Ott.SetToolTip(LblDirBroadcast, "Dirección de difusión de la red")
        Ott.SetToolTip(LblDirPrimera, "Primera dirección útil de la red")
        Ott.SetToolTip(LblDirRed, "Dirección de la red")
        Ott.SetToolTip(LblDirUltima, "Última dirección útil de la red")
        Ott.SetToolTip(LblNuDir, "Número de direcciones que tiene la red")
        Ott.SetToolTip(LblNuHosts, "Número de Equipos que puede haber en la red")
        Ott.SetToolTip(DGVSubRedes, "Tabla donde se mostrarán los datos de las subredes")




        ' Se establece el orden en que se pasa de un control a otro cuando se pulsa el tabulador
        Dim Ocontroles As Control() = {
        RBClaseA, RBClaseB, RBClaseC,
        RBNoSubredes, RBSiSubredes,
        NUDRed1, NUDRed2, NUDRed3, NUDRed4,
        CBMascara1, CBMascara2, CBMascara3, CBMascara4, NUDcidr,
        CBMascaraSub1, CBMascaraSub2, CBMascaraSub3, CBMascaraSub4, NUDCIDRSub,
        RBcidr, RBMascara,
        RBCIDRSub, RBMascaraSub,
        TBRed, TBBroadcast, TBDireccionPrimera, TBDireccionUltima, TBCantidadDirecciones, TBNumeroEquipos,
        BtnCalcular, BtnLimpiar, BtnCargar, BtnGuardar
        }

        For i = 0 To Ocontroles.Length - 1
            Ocontroles(i).TabStop = i
        Next i

    End Sub

    ' --------------------------------------------------------------------------------------------------------------
    ' --------------------------------------------------------------------------------------------------------------
    ' -------------------------------------  Eventos de los botones de accion  -------------------------------------
    ' --------------------------------------------------------------------------------------------------------------
    ' --------------------------------------------------------------------------------------------------------------

    ''' <summary>
    '''  Subrutina que se encargar de calcular los datos al producirse un click en el botón calcular
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        ' Declaración de variables
        Dim red As UInteger
        Dim mascara As UInteger
        Dim mascara_Subred As UInteger
        Dim listaDatos As String()
        Dim i As UInteger
        Dim salto As UInteger
        Dim final As UInteger
        Dim Onodo As New TreeNode


        ' se calcula la máscara de red en base al control CIDR de la máscara de red
        mascara = 0
        For i = 32 - NUDcidr.Value To 31
            mascara = mascara + 2 ^ i
        Next i

        ' se calcula la máscara de red en base al control CIDR de la máscara de red
        mascara_Subred = 0
        For i = 32 - NUDCIDRSub.Value To 31
            mascara_Subred = mascara_Subred + 2 ^ i
        Next i

        ' Se construye un número entero sin signo en base de los valores de los controladores numéricos de red
        red = (((NUDRed1.Value * 256) + NUDRed2.Value) * 256 + NUDRed3.Value) * 256 + NUDRed4.Value

        ' Se calcula los datos de la red
        listaDatos = Calculo_Red(red, mascara)

        ' Se pasa los datos a las cajas de texto correspodientes
        TBRed.Text = listaDatos(0)
        TBBroadcast.Text = listaDatos(1)
        TBDireccionPrimera.Text = listaDatos(2)
        TBDireccionUltima.Text = listaDatos(3)
        TBCantidadDirecciones.Text = listaDatos(4)
        TBNumeroEquipos.Text = listaDatos(5)

        ' Se construye una nueva entrada en el historial de redes calculadas
        Onodo.Text = listaDatos(0)
        Onodo.Nodes.Add(CBMascara1.SelectedItem + "." + CBMascara2.SelectedItem + "." + CBMascara3.SelectedItem + "." + CBMascara4.SelectedItem)

        ' Si no se ha especificado subredes se indica en un nodo sino se pone la máscara de subred
        If RBSiSubredes.Checked = False Then
            Onodo.Nodes.Add("Sin subredes")
        Else
            Onodo.Nodes.Add("Subredes: " + CBMascaraSub1.SelectedItem + "." + CBMascaraSub2.SelectedItem + "." + CBMascaraSub3.SelectedItem + "." + CBMascaraSub4.SelectedItem)
        End If
        TVDirecciones.Nodes.Add(Onodo)


        ' Si se ha especificado el cálculo de subredes se calculan y se introduce den el visor de subredes
        DGVSubRedes.Rows.Clear()
        If RBSiSubredes.Checked = True Then
            If mascara < mascara_Subred Then 'Se comprueba que se hace subnetting
                salto = 2 ^ (32 - NUDCIDRSub.Value) ' Cálculo del incremento por cada iteracción del bucle (tamaño de la subred)
                final = red Or (Not mascara) ' El número que queremos alcanzar (dirección de difusión)
                i = red
                Do
                    listaDatos = Calculo_Red(i, mascara_Subred)
                    DGVSubRedes.Rows.Add(listaDatos)
                    i = i + salto
                Loop While i < final
            End If
        End If


    End Sub

    ''' <summary>
    '''  Subrutina para limpiar los datos de entrada y de salida, por defecto no queremos borrar el historial
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click

        ' Se borra la salidas
        TBBroadcast.Text = ""
        TBCantidadDirecciones.Text = ""
        TBDireccionPrimera.Text = ""
        TBDireccionUltima.Text = ""
        TBNumeroEquipos.Text = ""
        TBRed.Text = ""

        DGVSubRedes.Rows.Clear()

        ' Se inicializa los selectores de entrada
        RBClaseA.Checked = True
        RBMascara.Checked = True
        RBMascaraSub.Checked = True

        ' Se fuerza a calcular los selectores de máscara

        RBMascara_CheckedChanged(sender, e)
        RBMascarasub_CheckedChanged(sender, e)

        CBMascara2.SelectedIndex = 0
        CBMascaraSub2.SelectedIndex = 0


    End Sub

    ''' <summary>
    ''' Subrutina para cargar los datos de entrada a partir de un archivo xml
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click

        Dim Documento As New XmlDocument
        Dim elemento As XmlNode
        Dim octetos As String()

        Dim nombre_archivo As String
        Dim oFichero As New OpenFileDialog
        Dim oResultado As DialogResult

        Dim OArchivo As FileInfo
        Dim Osecuridad As FileSecurity
        Dim OReglas As AuthorizationRuleCollection
        Dim OReglaAcceso As FileSystemAccessRule
        Dim permisoLectura As Boolean

        Dim i As Integer

        ' configuramos el cuadro de dialogo del archivo a cargar
        oFichero.Filter = "archivos de datos | *.xml"
        oFichero.Title = "Elección fichero a guardar"
        oFichero.Multiselect = False
        oFichero.CheckFileExists = True
        oFichero.CheckPathExists = True

        ' Obtenemos el nombre del archivo
        oResultado = oFichero.ShowDialog()

        ' Si no hemos aceptado o elegido un archivo abortamos la opración de cargar
        If oResultado <> DialogResult.OK Then Return
        If oFichero.FileName = "" Then Return

        nombre_archivo = oFichero.FileName

        ' Comprueba si exixte
        If File.Exists(nombre_archivo) = False Then
            MsgBox("Archivo seleccionado no existe")
            Return
        End If

        '   comprueba que se tiene los permisos de lectura
        OArchivo = New FileInfo(nombre_archivo) ' coge la información general del archivo

        Osecuridad = OArchivo.GetAccessControl() ' coge la información de seguridad del archivo

        OReglas = Osecuridad.GetAccessRules(True, True, GetType(System.Security.Principal.NTAccount)) ' Reglas para el usuario actual

        ' recorre las reglas en busca de los permisos de lectura o de lectura/ejecución
        permisoLectura = False
        For Each Oregla As AuthorizationRule In OReglas
            'conversión a reglas de acceso de archivos para poder leer los permisos de acceso
            OReglaAcceso = TryCast(Oregla, FileSystemAccessRule)
            ' Comprueba que el bit de lectura o el bit de lectura/ejecuión están activados
            If (OReglaAcceso.FileSystemRights And (FileSystemRights.Read Or FileSystemRights.ReadAndExecute)) > 0 Then
                ' comprueba que tenemos permitido el acceso
                If OReglaAcceso.AccessControlType = AccessControlType.Allow Then permisoLectura = True
            End If
        Next

        ' Si no tenemos los permisos de lectura nos lo indica y no carga los datos
        If permisoLectura = False Then
            MsgBox("No tienes permisos para leer el archivo seleccionado")
            Return
        End If

        ' leer el archivo
        Try
            Documento.Load(nombre_archivo)
        Catch ex As Exception
            MsgBox("No se ha realizado la carga de los datos por el siguiente error" + vbCrLf + ex.Message)
            Return
        End Try


        elemento = Documento.ChildNodes.Item(0).SelectNodes("direccion").Item(0)
        octetos = elemento.InnerText.Split(".")
        NUDRed1.Value = Convert.ToDecimal(octetos(0))
        NUDRed2.Value = Convert.ToDecimal(octetos(1))
        NUDRed3.Value = Convert.ToDecimal(octetos(2))
        NUDRed4.Value = Convert.ToDecimal(octetos(3))

        elemento = Documento.ChildNodes.Item(0).SelectNodes("mascara").Item(0)
        octetos = elemento.InnerText.Split(".")
        ' recorre los elementos de los desplegables y si coincide se selecciona
        For i = 0 To CBMascara1.Items.Count - 1
            If CBMascara1.Items.Item(i) = octetos(0) Then CBMascara1.SelectedIndex = i
            If CBMascara2.Items.Item(i) = octetos(1) Then CBMascara2.SelectedIndex = i
            If CBMascara3.Items.Item(i) = octetos(2) Then CBMascara3.SelectedIndex = i
            If CBMascara4.Items.Item(i) = octetos(3) Then CBMascara4.SelectedIndex = i
        Next i

        elemento = Documento.ChildNodes.Item(0).SelectNodes("cidr").Item(0)
        NUDcidr.Value = Convert.ToDecimal(elemento.InnerText)

        elemento = Documento.ChildNodes.Item(0).SelectNodes("mascaraSubRed").Item(0)
        octetos = elemento.InnerText.Split(".")
        ' recorre los elementos de los desplegables y si coincide se selecciona
        For i = 0 To CBMascaraSub1.Items.Count - 1
            If CBMascaraSub1.Items.Item(i) = octetos(0) Then CBMascaraSub1.SelectedIndex = i
            If CBMascaraSub2.Items.Item(i) = octetos(1) Then CBMascaraSub2.SelectedIndex = i
            If CBMascaraSub3.Items.Item(i) = octetos(2) Then CBMascaraSub3.SelectedIndex = i
            If CBMascaraSub4.Items.Item(i) = octetos(3) Then CBMascaraSub4.SelectedIndex = i
        Next i

        elemento = Documento.ChildNodes.Item(0).SelectNodes("cidrSubRed").Item(0)
        NUDCIDRSub.Value = Convert.ToDecimal(elemento.InnerText)


    End Sub

    ''' <summary>
    ''' Subrutina para guardar los datos de entrada a partir de un archivo xml
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Dim Documento As New XmlDocument
        Dim red, direccion, mascara, cidr, mascaraSubRed, cidrSubRed As XmlElement

        Dim nombre_archivo As String
        Dim oFichero As New SaveFileDialog
        Dim oResultado As DialogResult

        Dim OArchivo As FileInfo
        Dim ODirectorio As DirectoryInfo
        Dim Osecuridad As DirectorySecurity
        Dim OReglas As AuthorizationRuleCollection
        Dim OReglaAcceso As FileSystemAccessRule
        Dim permisoLectura As Boolean

        ' configuramos el cuadro de dialogo del archivo a guargar
        oFichero.Filter = ".archivos de datos | *.xml"
        oFichero.Title = "Elección fichero a guardar"
        oFichero.CheckPathExists = True

        ' Obtenemos el nombre del archivo
        oResultado = oFichero.ShowDialog()

        ' Si no hemos aceptado o elegido un archivo abortamos la opración de guargar
        If oResultado <> DialogResult.OK Then Return
        If oFichero.FileName = "" Then Return

        nombre_archivo = oFichero.FileName

        '   comprueba que se tiene los permisos de lectura

        OArchivo = New FileInfo(nombre_archivo) 'coge la información del archivo
        ODirectorio = OArchivo.Directory ' coge el directorio

        Osecuridad = ODirectorio.GetAccessControl() ' coge la información de seguridad del directorio

        OReglas = Osecuridad.GetAccessRules(True, True, GetType(System.Security.Principal.NTAccount)) ' Reglas para el directorio para el usuario actual

        ' recorre las reglas en busca de los permisos de lectura o de lectura/ejecución
        permisoLectura = False
        For Each Oregla As AuthorizationRule In OReglas
            'conversión a reglas de acceso de archivos para poder leer los permisos de acceso
            OReglaAcceso = TryCast(Oregla, FileSystemAccessRule)
            ' Comprueba que el bit de lectura o el bit de lectura/ejecuión están activados
            If (OReglaAcceso.FileSystemRights And (FileSystemRights.Write)) > 0 Then
                ' comprueba que tenemos permitido el acceso
                If OReglaAcceso.AccessControlType = AccessControlType.Allow Then permisoLectura = True
            End If
        Next


        ' Si no tenemos los permisos de lectura nos lo indica y no carga los datos
        If permisoLectura = False Then
            MsgBox("No tienes permisos para guardar el archivo en la carpeta seleccionada")
            Return
        End If

        ' Se monta el documento XML
        Documento.LoadXml("<red></red>")

        ' Se crea el elemento dirección con su dato
        direccion = Documento.CreateElement("direccion")
        direccion.InnerText = NUDRed1.Value.ToString + "." + NUDRed2.Value.ToString + "." +
                                      NUDRed3.Value.ToString + "." + NUDRed4.Value.ToString

        ' Se crea el elemento máscara con su dato
        mascara = Documento.CreateElement("mascara")
        mascara.InnerText = CBMascara1.SelectedItem.ToString + "." + CBMascara2.SelectedItem.ToString + "." +
                                      CBMascara3.SelectedItem.ToString + "." + CBMascara4.SelectedItem.ToString

        ' Se crea el elemento cidr con su dato
        cidr = Documento.CreateElement("cidr")
        cidr.InnerText = NUDcidr.Value.ToString

        ' Se crea el elemento máscara de subred con su dato
        mascaraSubRed = Documento.CreateElement("mascaraSubRed")
        mascaraSubRed.InnerText = CBMascaraSub1.SelectedItem.ToString + "." + CBMascaraSub1.SelectedItem.ToString + "." +
                                      CBMascaraSub1.SelectedItem.ToString + "." + CBMascaraSub1.SelectedItem.ToString

        ' Se crea el elemento cidr de subred con su dato
        cidrSubRed = Documento.CreateElement("cidrSubRed")
        cidrSubRed.InnerText = NUDcidr.Value.ToString

        ' agrega los elementos creados al documento
        red = Documento.DocumentElement

        red.AppendChild(direccion)
        red.AppendChild(mascara)
        red.AppendChild(cidr)
        red.AppendChild(mascaraSubRed)
        red.AppendChild(cidrSubRed)

        ' guarda el documento xml en el archivo seleccionado
        Try
            Documento.Save(nombre_archivo)
        Catch ex As Exception
            MsgBox("No se ha realizado el guardado de los datos por el siguiente error" + vbCrLf + ex.Message)
        End Try


    End Sub


    ' --------------------------------------------------------------------------------------------------------------
    ' --------------------------------------------------------------------------------------------------------------
    ' ----------------------------------  Eventos para el cambio de clase de red  ----------------------------------
    ' --------------------------------------------------------------------------------------------------------------
    ' --------------------------------------------------------------------------------------------------------------

    ''' <summary>
    ''' Subrutina detecta si se cambia el estado del selector de clase A
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RBClaseA_CheckedChanged(sender As Object, e As EventArgs) Handles RBClaseA.CheckedChanged
        'Clase A:  10.0.0.0 a 10.255.255.255 (8 bits red, 24 bits hosts)

        ' Si esta seleccionado se pone los datos por defecto en sus controles correspodientes,
        ' asignandoles los valores mínimos
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

    ''' <summary>
    ''' Subrutina detecta si se cambia el estado del selector de clase B
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RBClaseB_CheckedChanged(sender As Object, e As EventArgs) Handles RBClaseB.CheckedChanged
        'Clase B:  172.16.0.0 a 172.31.255.255 (16 bits red, 16 bits hosts)

        ' Si esta seleccionado se pone los datos por defecto en sus controles correspodientes,
        ' asignandoles los valores mínimos
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

    ''' <summary>
    ''' Subrutina detecta si se cambia el estado del selector de clase C
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RBClaseC_CheckedChanged(sender As Object, e As EventArgs) Handles RBClaseC.CheckedChanged
        'Clase C:  192.168.0.0 a 192.168.255.255 (24 bits red, 8 bits hosts)

        ' Si esta seleccionado se pone los datos por defecto en sus controles correspodientes,
        ' asignandoles los valores mínimos
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


    ''' <summary>
    ''' Subrutina para gestionar la activación del selector de cidr de la máscara
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RBcidr_CheckedChanged(sender As Object, e As EventArgs) Handles RBcidr.CheckedChanged

        ' si el selector está activo se sedactiva los selectores de octetos y se activa el control cidr
        If RBcidr.Checked = True Then

            CBMascara1.Enabled = False
            CBMascara2.Enabled = False
            CBMascara3.Enabled = False
            CBMascara4.Enabled = False
            NUDcidr.Enabled = True

        End If

    End Sub

    ''' <summary>
    ''' Subrutina de gestion del selector de mascara de red
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RBMascara_CheckedChanged(sender As Object, e As EventArgs) Handles RBMascara.CheckedChanged

        ' si se activa el selector de selección por máscara se actualizarán los controles desplegables de la mácara de red
        ' y se activarán los que se pueda seleccionar según el valor del anterior
        If RBMascara.Checked = True Then

            NUDcidr.Enabled = False
            Select Case NUDcidr.Value
                Case < 8 ' la máscara solo afecta al octeto con más peso
                    CBMascara1.SelectedIndex = NUDcidr.Value
                Case 8 To 16 ' la máscara afecta a los dos octetos con más peso
                    CBMascara1.SelectedIndex = 8
                    CBMascara2.SelectedIndex = NUDcidr.Value - 8
                Case 17 To 24 ' la máscara afecta a los tres octetos con más peso
                    CBMascara1.SelectedIndex = 8
                    CBMascara2.SelectedIndex = 8
                    CBMascara3.SelectedIndex = NUDcidr.Value - 16
                Case > 24 ' la máscara afecta a los todos octetos
                    CBMascara1.SelectedIndex = 8
                    CBMascara2.SelectedIndex = 8
                    CBMascara3.SelectedIndex = 8
                    CBMascara4.SelectedIndex = NUDcidr.Value - 24
            End Select

        End If

        ' Activa los selectores que se pueden utilizar -> Los octetos con valor 255 y el sguiente al último con ese valor
        CBMascara1.Enabled = True

        If CBMascara1.SelectedIndex = 8 Then CBMascara2.Enabled = True Else CBMascara2.Enabled = False

        If CBMascara2.SelectedIndex = 8 Then CBMascara3.Enabled = True Else CBMascara3.Enabled = False

        If CBMascara3.SelectedIndex = 8 Then CBMascara4.Enabled = True Else CBMascara4.Enabled = False



    End Sub

    ''' <summary>
    ''' Subrutina que controla el cambio de valor del control numerico del CIDR de la máscara dered
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NUDcidr_ValueChanged(sender As Object, e As EventArgs) Handles NUDcidr.ValueChanged

        ' Se actualizarán los valores de los controles desplegables de la red dependiendo del valor del control de CIDR
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

        ' No se premitirá que las subredes tengan una máscara de red o CIDR menor que la máscara de red
        NUDCIDRSub.Minimum = NUDcidr.Value

    End Sub

    ''' <summary>
    ''' Subrutina que gestiona el cambio en el primer selector de la máscara de red
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CBMascara1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMascara1.SelectedIndexChanged

        ' Si se ha seleccionado 255 permitir seleccionar el siguiente selector
        If CBMascara1.SelectedIndex = 8 Then CBMascara2.Enabled = True Else CBMascara2.Enabled = False

        ' Si se cambia la máscara de esté selector a cualquier valor los demás octetos deben de tomar valor 0
        CBMascara2.SelectedIndex = 0
        CBMascara3.Enabled = False
        CBMascara3.SelectedIndex = 0
        CBMascara4.Enabled = False
        CBMascara4.SelectedIndex = 0

        ' Se calcula el valor CIDR
        NUDcidr.Value = CBMascara1.SelectedIndex + CBMascara2.SelectedIndex + CBMascara3.SelectedIndex + CBMascara4.SelectedIndex

    End Sub

    ''' <summary>
    ''' Subrutina que gestiona el cambio en el segundo selector de la máscara de red
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CBMascara2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMascara2.SelectedIndexChanged

        ' Si se ha seleccionado 255 permitir seleccionar el siguiente selector
        If CBMascara2.SelectedIndex = 8 Then CBMascara3.Enabled = True Else CBMascara3.Enabled = False

        ' Si se cambia la máscara de esté selector a cualquier valor los octetos con menos peso tomar el valor 0
        CBMascara3.SelectedIndex = 0
        CBMascara4.Enabled = False
        CBMascara4.SelectedIndex = 0

        ' Se calcula el valor CIDR
        NUDcidr.Value = CBMascara1.SelectedIndex + CBMascara2.SelectedIndex + CBMascara3.SelectedIndex + CBMascara4.SelectedIndex

    End Sub

    ''' <summary>
    ''' Subrutina que gestiona el cambio en el tercer selector de la máscara de red
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CBMascara3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMascara3.SelectedIndexChanged

        ' Si se ha seleccionado 255 permitir seleccionar el último selector
        If CBMascara3.SelectedIndex = 8 Then CBMascara4.Enabled = True Else CBMascara4.Enabled = False

        ' Si se cambia la máscara de esté selector a cualquier valor el octeto con menos peso deben de ser 0
        CBMascara4.SelectedIndex = 0

        ' Se calcula el valor CIDR
        NUDcidr.Value = CBMascara1.SelectedIndex + CBMascara2.SelectedIndex + CBMascara3.SelectedIndex + CBMascara4.SelectedIndex

    End Sub

    ''' <summary>
    ''' Subrutina que gestiona el cambio en el último selector de la máscara de red
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CBMascara4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMascara4.SelectedIndexChanged

        ' Se calcula el valor CIDR
        NUDcidr.Value = CBMascara1.SelectedIndex + CBMascara2.SelectedIndex + CBMascara3.SelectedIndex + CBMascara4.SelectedIndex

    End Sub




    ' --------------------------------------------------------------------------------------------------------------
    ' --------------------------------------------------------------------------------------------------------------
    ' -------------------------------  Eventos para el cambio de la mascara de subred  --------------------------------
    ' --------------------------------------------------------------------------------------------------------------
    ' --------------------------------------------------------------------------------------------------------------


    ''' <summary>
    ''' Subrutina que controla la selección si de subredes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RBSubredes_CheckedChanged(sender As Object, e As EventArgs) Handles RBNoSubredes.CheckedChanged, RBSiSubredes.CheckedChanged

        If RBSiSubredes.Checked = True Then PnlSubred.Visible = True Else PnlSubred.Visible = False

    End Sub

    ''' <summary>
    ''' Subrutina que contrala la selección de la máscacara de subred por CIDR
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RBcidrSub_CheckedChanged(sender As Object, e As EventArgs) Handles RBCIDRSub.CheckedChanged

        ' Si el control está activó se desactivará los controles desplegables y se activa el control númerico
        If RBCIDRSub.Checked = True Then

            CBMascaraSub1.Enabled = False
            CBMascaraSub2.Enabled = False
            CBMascaraSub3.Enabled = False
            CBMascaraSub4.Enabled = False
            NUDCIDRSub.Enabled = True

        End If


    End Sub

    ''' <summary>
    ''' Subrutina que controla el selector de la máscara de subred por los valores de la máscara
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RBMascarasub_CheckedChanged(sender As Object, e As EventArgs) Handles RBMascaraSub.CheckedChanged

        If RBMascaraSub.Checked = True Then

            'Se estable que control desplegable estará activo dependiendo del valor del control del anterior octeto
            CBMascaraSub1.Enabled = True
            If CBMascaraSub1.SelectedIndex = 8 Then CBMascaraSub2.Enabled = True Else CBMascaraSub2.Enabled = False

            If CBMascaraSub2.SelectedIndex = 8 Then CBMascaraSub3.Enabled = True Else CBMascaraSub3.Enabled = False

            If CBMascaraSub3.SelectedIndex = 8 Then CBMascaraSub4.Enabled = True Else CBMascaraSub4.Enabled = False

            ' Se desactiva el controlador númerico del CIDR
            NUDCIDRSub.Enabled = False

            ' Se actualizarán los valores de los controles desplegables de las subredes dependiendo del valor del cotrol de CIDR
            Select Case NUDCIDRSub.Value
                Case < 8 ' Solo afecta al primer octeto
                    CBMascaraSub1.SelectedIndex = NUDCIDRSub.Value
                Case 8 To 16 ' Afecta al primer y segundo octeto
                    CBMascaraSub1.SelectedIndex = 8
                    CBMascaraSub2.SelectedIndex = NUDCIDRSub.Value - 8
                    CBMascaraSub3.SelectedIndex = 0
                    CBMascaraSub4.SelectedIndex = 0

                Case 17 To 24 ' Afecta a los tres primeros octetos
                    CBMascaraSub1.SelectedIndex = 8
                    CBMascaraSub2.SelectedIndex = 8
                    CBMascaraSub3.SelectedIndex = NUDCIDRSub.Value - 16
                    CBMascaraSub4.SelectedIndex = 0

                Case > 24 ' Afecta a todos los octetos
                    CBMascaraSub1.SelectedIndex = 8
                    CBMascaraSub2.SelectedIndex = 8
                    CBMascaraSub3.SelectedIndex = 8
                    CBMascaraSub4.SelectedIndex = NUDCIDRSub.Value - 24
            End Select

        End If

    End Sub

    ''' <summary>
    ''' Subrutina que controla el selector de la máscara de subred por valor CIDR
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NUDcidrsub_ValueChanged(sender As Object, e As EventArgs) Handles NUDCIDRSub.ValueChanged

        ' Se actualiza los valores de los menus desplegables
        Select Case NUDCIDRSub.Value
            Case 0 To 8
                CBMascaraSub1.SelectedIndex = NUDCIDRSub.Value
                CBMascaraSub2.SelectedIndex = 0
                CBMascaraSub3.SelectedIndex = 0
                CBMascaraSub4.SelectedIndex = 0
            Case 9 To 16
                CBMascaraSub1.SelectedIndex = 8
                CBMascaraSub2.SelectedIndex = NUDCIDRSub.Value - 8
                CBMascaraSub3.SelectedIndex = 0
                CBMascaraSub4.SelectedIndex = 0
            Case 17 To 24
                CBMascaraSub1.SelectedIndex = 8
                CBMascaraSub2.SelectedIndex = 8
                CBMascaraSub3.SelectedIndex = NUDCIDRSub.Value - 16
                CBMascaraSub4.SelectedIndex = 0
            Case > 24
                CBMascaraSub1.SelectedIndex = 8
                CBMascaraSub2.SelectedIndex = 8
                CBMascaraSub3.SelectedIndex = 8
                CBMascaraSub4.SelectedIndex = NUDCIDRSub.Value - 24
        End Select

    End Sub

    ''' <summary>
    ''' Subrutina que gestiona el cambio en el primer selector de la máscara de subred
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CBMascarasub1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMascaraSub1.SelectedIndexChanged

        Dim valor As Byte

        ' Se calcula el valor CIDR
        valor = CBMascaraSub1.SelectedIndex + CBMascaraSub2.SelectedIndex + CBMascaraSub3.SelectedIndex + CBMascaraSub4.SelectedIndex

        ' No se permite que la máscara de subred sea menor que la máscara de red
        If valor < NUDcidr.Value Then
            CBMascaraSub1.SelectedIndex = CBMascara1.SelectedIndex
            Return
        End If

        ' Si toma el valor 255 se permite utilizar el controlador desplegable del segundo octeto
        If CBMascaraSub1.SelectedIndex = 8 Then CBMascaraSub2.Enabled = True Else CBMascaraSub2.Enabled = False

        ' Si se cambia la máscara de esté selector a cualquier valor los demás octetos deben de tomar valor 0
        CBMascaraSub2.SelectedIndex = 0
        CBMascaraSub3.Enabled = False
        CBMascaraSub3.SelectedIndex = 0
        CBMascaraSub4.Enabled = False
        CBMascaraSub4.SelectedIndex = 0

        ' Se pasa el valor del CIDR al controlador númerico
        NUDCIDRSub.Value = valor

    End Sub

    ''' <summary>
    ''' Subrutina que gestiona el cambio en el segundo selector de la máscara de subred
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CBMascarasub2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMascaraSub2.SelectedIndexChanged

        Dim valor As Byte

        ' Se calcula el valor CIDR
        valor = CBMascaraSub1.SelectedIndex + CBMascaraSub2.SelectedIndex + CBMascaraSub3.SelectedIndex + CBMascaraSub4.SelectedIndex

        ' No se permite que la máscara de subred sea menor que la máscara de red
        If valor < NUDcidr.Value Then
            CBMascaraSub2.SelectedIndex = CBMascara2.SelectedIndex
            Return
        End If

        If CBMascaraSub2.SelectedIndex = 8 Then CBMascaraSub3.Enabled = True Else CBMascaraSub3.Enabled = False

        ' Si se cambia la máscara de esté selector a cualquier valor los octetos de menos peso deben de tomar valor 0
        CBMascaraSub3.SelectedIndex = 0
        CBMascaraSub4.Enabled = False
        CBMascaraSub4.SelectedIndex = 0

        ' Se pasa el valor del CIDR al controlador númerico
        NUDCIDRSub.Value = valor

    End Sub

    ''' <summary>
    ''' Subrutina que gestiona el cambio en el tercer selector de la máscara de subred
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CBMascarasub3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMascaraSub3.SelectedIndexChanged

        Dim valor As Byte

        ' Se calcula el valor CIDR
        valor = CBMascaraSub1.SelectedIndex + CBMascaraSub2.SelectedIndex + CBMascaraSub3.SelectedIndex + CBMascaraSub4.SelectedIndex

        ' No se permite que la máscara de subred sea menor que la máscara de red
        If valor < NUDcidr.Value Then
            CBMascaraSub3.SelectedIndex = CBMascara3.SelectedIndex
            Return
        End If

        ' S
        If CBMascaraSub3.SelectedIndex = 8 Then CBMascaraSub4.Enabled = True Else CBMascaraSub4.Enabled = False

        ' Si se cambia la máscara de esté selector a cualquier valor el octeto con menos peso deben de ser 0
        CBMascaraSub4.SelectedIndex = 0

        ' Se pasa el valor del CIDR al controlador númerico
        NUDCIDRSub.Value = valor

    End Sub

    ''' <summary>
    ''' Subrutina que gestiona el cambio en el cuarto selector de la máscara de subred
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CBMascarasub4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMascaraSub4.SelectedIndexChanged

        Dim valor As Byte

        ' Se calcula el valor CIDR
        valor = CBMascaraSub1.SelectedIndex + CBMascaraSub2.SelectedIndex + CBMascaraSub3.SelectedIndex + CBMascaraSub4.SelectedIndex

        ' No se permite que la máscara de subred sea menor que la máscara de red
        If valor < NUDcidr.Value Then
            CBMascaraSub4.SelectedIndex = CBMascara4.SelectedIndex
            Return
        End If

        ' Se pasa el valor del CIDR al controlador númerico
        NUDCIDRSub.Value = valor

    End Sub



    ' --------------------------------------------------------------------------------------------------------------
    ' --------------------------------------------------------------------------------------------------------------
    ' -------------------------------------------  Funciones axiliares  --------------------------------------------
    ' --------------------------------------------------------------------------------------------------------------
    ' --------------------------------------------------------------------------------------------------------------


    Private Function Calculo_Red(pRed As UInt32, pMascara As UInt32) As String()
        Dim Resultados As New List(Of String)
        Dim dir_Red As UInt32
        Dim dir_Difusion As UInt32
        Dim dir_A As UInt32
        Dim dir_B As UInt32
        Dim nu_dir As UInt32
        Dim nu_hosts As UInt32
        Dim octetos As Byte()

        dir_Red = pRed And pMascara
        dir_Difusion = pRed Or (Not pMascara)
        dir_A = dir_Red + 1
        dir_B = dir_Difusion - 1

        nu_dir = dir_Difusion - dir_Red
        nu_hosts = dir_B - dir_A

        Resultados.Clear()

        octetos = BitConverter.GetBytes(dir_Red)
        Resultados.Add(octetos(3).ToString + "." + octetos(2).ToString + "." + octetos(1).ToString + "." + octetos(0).ToString)

        octetos = BitConverter.GetBytes(dir_Difusion)
        Resultados.Add(octetos(3).ToString + "." + octetos(2).ToString + "." + octetos(1).ToString + "." + octetos(0).ToString)

        octetos = BitConverter.GetBytes(dir_A)
        Resultados.Add(octetos(3).ToString + "." + octetos(2).ToString + "." + octetos(1).ToString + "." + octetos(0).ToString)

        octetos = BitConverter.GetBytes(dir_B)
        Resultados.Add(octetos(3).ToString + "." + octetos(2).ToString + "." + octetos(1).ToString + "." + octetos(0).ToString)

        Resultados.Add(nu_dir.ToString)
        Resultados.Add(nu_hosts.ToString)

        Return Resultados.ToArray
    End Function



End Class
