<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnagraficheDaa
    Inherits FunzioniIntegra.BaseForm

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Overloads Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnagraficheDaa))
        Dim Style25 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style26 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style27 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style28 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style29 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style30 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style31 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style32 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style33 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style34 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style35 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style36 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style37 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style38 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style39 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style40 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style41 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style42 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style43 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style44 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style45 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style46 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style47 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style48 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnFirst = New System.Windows.Forms.ToolStripButton
        Me.BtnPrev = New System.Windows.Forms.ToolStripButton
        Me.BtnAdd = New System.Windows.Forms.ToolStripButton
        Me.BtnDel = New System.Windows.Forms.ToolStripButton
        Me.BtnNext = New System.Windows.Forms.ToolStripButton
        Me.BtnLast = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.DropTipoDestinazione = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.DropStatoMembro = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.DropLingua = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.DBGridAnagrafica = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.ContextMenuGridAnagrafica = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextAnagItem_Manuali = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextAnagItem_Importate = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextAnagItem_CopiaInSpeditori = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextAnagItem_CopiaInDestinatari = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextAnagItem_CopiaInAziendeDiTrasporto = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextAnagItem_CopiaInTraportatori = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextAnagItem_CopiaInGaranti = New System.Windows.Forms.ToolStripMenuItem
        Me.DBGridDestinazione = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LblAnagHidden = New System.Windows.Forms.Label
        Me.CmbAnagHidden = New FlexGroup.C1ComboBoxIntegrav2
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbDeposito = New FlexGroup.C1ComboBoxIntegrav2
        Me.GroupFilter = New System.Windows.Forms.GroupBox
        Me.TxtFilterCodice = New FunzioniIntegra.TextBoxIntegra
        Me.TxtFilterId = New FunzioniIntegra.TextBoxIntegra
        Me.TxtFilterAccisa = New FunzioniIntegra.TextBoxIntegra
        Me.TxtFilterPiva = New FunzioniIntegra.TextBoxIntegra
        Me.TxtFilterDenominazione = New FunzioniIntegra.TextBoxIntegra
        Me.LblFilterPiva = New System.Windows.Forms.Label
        Me.BtnCancelFilter = New System.Windows.Forms.Button
        Me.BtnApplyFilter = New System.Windows.Forms.Button
        Me.LblFilterAccisa = New System.Windows.Forms.Label
        Me.LblFilterCodice = New System.Windows.Forms.Label
        Me.LblFilterDenominazione = New System.Windows.Forms.Label
        Me.LblFilterId = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbTipoAnagrafica = New FlexGroup.C1ComboBoxIntegrav2
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DropTipoDestinazione, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropStatoMembro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropLingua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGridAnagrafica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuGridAnagrafica.SuspendLayout()
        CType(Me.DBGridDestinazione, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.CmbAnagHidden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbDeposito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupFilter.SuspendLayout()
        CType(Me.CmbTipoAnagrafica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 654)
        Me.StatusBar1.Size = New System.Drawing.Size(1047, 22)
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Width = 641
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.Text = "NUM"
        '
        'StatusBarPanel6
        '
        Me.StatusBarPanel6.Text = "13/01/2011 09.21.17"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnFirst, Me.BtnPrev, Me.BtnAdd, Me.BtnDel, Me.BtnNext, Me.BtnLast, Me.toolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1047, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnFirst
        '
        Me.BtnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnFirst.Image = CType(resources.GetObject("BtnFirst.Image"), System.Drawing.Image)
        Me.BtnFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(23, 22)
        Me.BtnFirst.Text = "Prima"
        '
        'BtnPrev
        '
        Me.BtnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnPrev.Image = CType(resources.GetObject("BtnPrev.Image"), System.Drawing.Image)
        Me.BtnPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(23, 22)
        Me.BtnPrev.Text = "Precedente"
        '
        'BtnAdd
        '
        Me.BtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(23, 22)
        '
        'BtnDel
        '
        Me.BtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnDel.Image = CType(resources.GetObject("BtnDel.Image"), System.Drawing.Image)
        Me.BtnDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(23, 22)
        Me.BtnDel.Text = "Elimina"
        '
        'BtnNext
        '
        Me.BtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(23, 22)
        Me.BtnNext.Text = "Successiva"
        '
        'BtnLast
        '
        Me.BtnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnLast.Image = CType(resources.GetObject("BtnLast.Image"), System.Drawing.Image)
        Me.BtnLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(23, 22)
        Me.BtnLast.Text = "Ultima"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 110)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DropTipoDestinazione)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DropStatoMembro)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DropLingua)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DBGridAnagrafica)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DBGridDestinazione)
        Me.SplitContainer1.Size = New System.Drawing.Size(1047, 544)
        Me.SplitContainer1.SplitterDistance = 315
        Me.SplitContainer1.TabIndex = 6
        '
        'DropTipoDestinazione
        '
        Me.DropTipoDestinazione.AllowColMove = True
        Me.DropTipoDestinazione.AllowColSelect = True
        Me.DropTipoDestinazione.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.DropTipoDestinazione.AlternatingRows = False
        Me.DropTipoDestinazione.CaptionStyle = Style25
        Me.DropTipoDestinazione.ColumnCaptionHeight = 17
        Me.DropTipoDestinazione.ColumnFooterHeight = 17
        Me.DropTipoDestinazione.DisplayMember = "FullDescrizione"
        Me.DropTipoDestinazione.EvenRowStyle = Style26
        Me.DropTipoDestinazione.FetchRowStyles = False
        Me.DropTipoDestinazione.FooterStyle = Style27
        Me.DropTipoDestinazione.HeadingStyle = Style28
        Me.DropTipoDestinazione.HighLightRowStyle = Style29
        Me.DropTipoDestinazione.Images.Add(CType(resources.GetObject("DropTipoDestinazione.Images"), System.Drawing.Image))
        Me.DropTipoDestinazione.Location = New System.Drawing.Point(656, 53)
        Me.DropTipoDestinazione.Name = "DropTipoDestinazione"
        Me.DropTipoDestinazione.OddRowStyle = Style30
        Me.DropTipoDestinazione.RecordSelectorStyle = Style31
        Me.DropTipoDestinazione.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.DropTipoDestinazione.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.DropTipoDestinazione.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.DropTipoDestinazione.ScrollTips = False
        Me.DropTipoDestinazione.Size = New System.Drawing.Size(223, 97)
        Me.DropTipoDestinazione.Style = Style32
        Me.DropTipoDestinazione.TabIndex = 12
        Me.DropTipoDestinazione.TabStop = False
        Me.DropTipoDestinazione.Text = "DropTipoDestinazione"
        Me.DropTipoDestinazione.ValueMember = "Codice_Tabella"
        Me.DropTipoDestinazione.ValueTranslate = True
        Me.DropTipoDestinazione.Visible = False
        Me.DropTipoDestinazione.PropBag = resources.GetString("DropTipoDestinazione.PropBag")
        '
        'DropStatoMembro
        '
        Me.DropStatoMembro.AllowColMove = True
        Me.DropStatoMembro.AllowColSelect = True
        Me.DropStatoMembro.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.DropStatoMembro.AlternatingRows = False
        Me.DropStatoMembro.CaptionStyle = Style33
        Me.DropStatoMembro.ColumnCaptionHeight = 17
        Me.DropStatoMembro.ColumnFooterHeight = 17
        Me.DropStatoMembro.DisplayMember = "Codice_Tabella"
        Me.DropStatoMembro.EvenRowStyle = Style34
        Me.DropStatoMembro.FetchRowStyles = False
        Me.DropStatoMembro.FooterStyle = Style35
        Me.DropStatoMembro.HeadingStyle = Style36
        Me.DropStatoMembro.HighLightRowStyle = Style37
        Me.DropStatoMembro.Images.Add(CType(resources.GetObject("DropStatoMembro.Images"), System.Drawing.Image))
        Me.DropStatoMembro.Location = New System.Drawing.Point(198, 53)
        Me.DropStatoMembro.Name = "DropStatoMembro"
        Me.DropStatoMembro.OddRowStyle = Style38
        Me.DropStatoMembro.RecordSelectorStyle = Style39
        Me.DropStatoMembro.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.DropStatoMembro.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.DropStatoMembro.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.DropStatoMembro.ScrollTips = False
        Me.DropStatoMembro.Size = New System.Drawing.Size(223, 97)
        Me.DropStatoMembro.Style = Style40
        Me.DropStatoMembro.TabIndex = 11
        Me.DropStatoMembro.TabStop = False
        Me.DropStatoMembro.Text = "DropFormatoTipo"
        Me.DropStatoMembro.ValueMember = "Codice_Tabella"
        Me.DropStatoMembro.Visible = False
        Me.DropStatoMembro.PropBag = resources.GetString("DropStatoMembro.PropBag")
        '
        'DropLingua
        '
        Me.DropLingua.AllowColMove = True
        Me.DropLingua.AllowColSelect = True
        Me.DropLingua.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.DropLingua.AlternatingRows = False
        Me.DropLingua.CaptionStyle = Style41
        Me.DropLingua.ColumnCaptionHeight = 17
        Me.DropLingua.ColumnFooterHeight = 17
        Me.DropLingua.DisplayMember = "Codice_Tabella"
        Me.DropLingua.EvenRowStyle = Style42
        Me.DropLingua.FetchRowStyles = False
        Me.DropLingua.FooterStyle = Style43
        Me.DropLingua.HeadingStyle = Style44
        Me.DropLingua.HighLightRowStyle = Style45
        Me.DropLingua.Images.Add(CType(resources.GetObject("DropLingua.Images"), System.Drawing.Image))
        Me.DropLingua.Location = New System.Drawing.Point(427, 53)
        Me.DropLingua.Name = "DropLingua"
        Me.DropLingua.OddRowStyle = Style46
        Me.DropLingua.RecordSelectorStyle = Style47
        Me.DropLingua.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.DropLingua.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.DropLingua.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.DropLingua.ScrollTips = False
        Me.DropLingua.Size = New System.Drawing.Size(223, 97)
        Me.DropLingua.Style = Style48
        Me.DropLingua.TabIndex = 10
        Me.DropLingua.TabStop = False
        Me.DropLingua.Text = "DropFormatoTipo"
        Me.DropLingua.ValueMember = "Codice_Tabella"
        Me.DropLingua.Visible = False
        Me.DropLingua.PropBag = resources.GetString("DropLingua.PropBag")
        '
        'DBGridAnagrafica
        '
        Me.DBGridAnagrafica.AllowAddNew = True
        Me.DBGridAnagrafica.AllowColMove = False
        Me.DBGridAnagrafica.AllowColSelect = False
        Me.DBGridAnagrafica.AllowDelete = True
        Me.DBGridAnagrafica.ContextMenuStrip = Me.ContextMenuGridAnagrafica
        Me.DBGridAnagrafica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DBGridAnagrafica.ExtendRightColumn = True
        Me.DBGridAnagrafica.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGridAnagrafica.Images.Add(CType(resources.GetObject("DBGridAnagrafica.Images"), System.Drawing.Image))
        Me.DBGridAnagrafica.Location = New System.Drawing.Point(0, 0)
        Me.DBGridAnagrafica.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None
        Me.DBGridAnagrafica.Name = "DBGridAnagrafica"
        Me.DBGridAnagrafica.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGridAnagrafica.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGridAnagrafica.PreviewInfo.ZoomFactor = 75
        Me.DBGridAnagrafica.PrintInfo.PageSettings = CType(resources.GetObject("DBGridAnagrafica.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGridAnagrafica.Size = New System.Drawing.Size(1047, 315)
        Me.DBGridAnagrafica.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.DBGridAnagrafica.TabIndex = 1
        Me.DBGridAnagrafica.Text = "C1TrueDBGrid2"
        Me.DBGridAnagrafica.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.DBGridAnagrafica.PropBag = resources.GetString("DBGridAnagrafica.PropBag")
        '
        'ContextMenuGridAnagrafica
        '
        Me.ContextMenuGridAnagrafica.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContextAnagItem_Manuali, Me.ContextAnagItem_Importate, Me.ContextAnagItem_CopiaInSpeditori, Me.ContextAnagItem_CopiaInDestinatari, Me.ContextAnagItem_CopiaInAziendeDiTrasporto, Me.ContextAnagItem_CopiaInTraportatori, Me.ContextAnagItem_CopiaInGaranti})
        Me.ContextMenuGridAnagrafica.Name = "ContextMenuGridAnagrafica"
        Me.ContextMenuGridAnagrafica.Size = New System.Drawing.Size(221, 158)
        '
        'ContextAnagItem_Manuali
        '
        Me.ContextAnagItem_Manuali.Name = "ContextAnagItem_Manuali"
        Me.ContextAnagItem_Manuali.Size = New System.Drawing.Size(220, 22)
        Me.ContextAnagItem_Manuali.Text = "Sposta in ""Manuali"""
        '
        'ContextAnagItem_Importate
        '
        Me.ContextAnagItem_Importate.Name = "ContextAnagItem_Importate"
        Me.ContextAnagItem_Importate.Size = New System.Drawing.Size(220, 22)
        Me.ContextAnagItem_Importate.Text = "Sposta in ""Importate"""
        '
        'ContextAnagItem_CopiaInSpeditori
        '
        Me.ContextAnagItem_CopiaInSpeditori.Name = "ContextAnagItem_CopiaInSpeditori"
        Me.ContextAnagItem_CopiaInSpeditori.Size = New System.Drawing.Size(220, 22)
        Me.ContextAnagItem_CopiaInSpeditori.Text = "Copia in ""Speditori"""
        '
        'ContextAnagItem_CopiaInDestinatari
        '
        Me.ContextAnagItem_CopiaInDestinatari.Name = "ContextAnagItem_CopiaInDestinatari"
        Me.ContextAnagItem_CopiaInDestinatari.Size = New System.Drawing.Size(220, 22)
        Me.ContextAnagItem_CopiaInDestinatari.Text = "Copia in ""Destinatari"""
        '
        'ContextAnagItem_CopiaInAziendeDiTrasporto
        '
        Me.ContextAnagItem_CopiaInAziendeDiTrasporto.Name = "ContextAnagItem_CopiaInAziendeDiTrasporto"
        Me.ContextAnagItem_CopiaInAziendeDiTrasporto.Size = New System.Drawing.Size(220, 22)
        Me.ContextAnagItem_CopiaInAziendeDiTrasporto.Text = "Copia in ""Aziende di trasporto"""
        '
        'ContextAnagItem_CopiaInTraportatori
        '
        Me.ContextAnagItem_CopiaInTraportatori.Name = "ContextAnagItem_CopiaInTraportatori"
        Me.ContextAnagItem_CopiaInTraportatori.Size = New System.Drawing.Size(220, 22)
        Me.ContextAnagItem_CopiaInTraportatori.Text = "Copia in ""Trasportatori"""
        '
        'ContextAnagItem_CopiaInGaranti
        '
        Me.ContextAnagItem_CopiaInGaranti.Name = "ContextAnagItem_CopiaInGaranti"
        Me.ContextAnagItem_CopiaInGaranti.Size = New System.Drawing.Size(220, 22)
        Me.ContextAnagItem_CopiaInGaranti.Text = "Copia in ""Garanti"""
        '
        'DBGridDestinazione
        '
        Me.DBGridDestinazione.AllowAddNew = True
        Me.DBGridDestinazione.AllowColMove = False
        Me.DBGridDestinazione.AllowColSelect = False
        Me.DBGridDestinazione.AllowDelete = True
        Me.DBGridDestinazione.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DBGridDestinazione.ExtendRightColumn = True
        Me.DBGridDestinazione.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGridDestinazione.Images.Add(CType(resources.GetObject("DBGridDestinazione.Images"), System.Drawing.Image))
        Me.DBGridDestinazione.Location = New System.Drawing.Point(0, 0)
        Me.DBGridDestinazione.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None
        Me.DBGridDestinazione.Name = "DBGridDestinazione"
        Me.DBGridDestinazione.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGridDestinazione.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGridDestinazione.PreviewInfo.ZoomFactor = 75
        Me.DBGridDestinazione.PrintInfo.PageSettings = CType(resources.GetObject("DBGridDestinazione.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGridDestinazione.Size = New System.Drawing.Size(1047, 225)
        Me.DBGridDestinazione.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.DBGridDestinazione.TabIndex = 2
        Me.DBGridDestinazione.Text = "C1TrueDBGrid2"
        Me.DBGridDestinazione.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.DBGridDestinazione.PropBag = resources.GetString("DBGridDestinazione.PropBag")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblAnagHidden)
        Me.Panel1.Controls.Add(Me.CmbAnagHidden)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CmbDeposito)
        Me.Panel1.Controls.Add(Me.GroupFilter)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CmbTipoAnagrafica)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1047, 85)
        Me.Panel1.TabIndex = 7
        '
        'LblAnagHidden
        '
        Me.LblAnagHidden.AutoSize = True
        Me.LblAnagHidden.Location = New System.Drawing.Point(7, 61)
        Me.LblAnagHidden.Name = "LblAnagHidden"
        Me.LblAnagHidden.Size = New System.Drawing.Size(66, 13)
        Me.LblAnagHidden.TabIndex = 23
        Me.LblAnagHidden.Text = "Provenienza"
        '
        'CmbAnagHidden
        '
        Me.CmbAnagHidden.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CmbAnagHidden.AllowColMove = False
        Me.CmbAnagHidden.AllowSort = False
        Me.CmbAnagHidden.AutoSelect = True
        Me.CmbAnagHidden.Caption = ""
        Me.CmbAnagHidden.CaptionHeight = 17
        Me.CmbAnagHidden.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CmbAnagHidden.ColumnCaptionHeight = 17
        Me.CmbAnagHidden.ColumnFooterHeight = 17
        Me.CmbAnagHidden.ColumnHeaders = False
        Me.CmbAnagHidden.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CmbAnagHidden.ContentHeight = 15
        Me.CmbAnagHidden.DataMode = C1.Win.C1List.DataModeEnum.AddItem
        Me.CmbAnagHidden.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CmbAnagHidden.DisplayMember = "descrizione"
        Me.CmbAnagHidden.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CmbAnagHidden.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAnagHidden.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbAnagHidden.EditorHeight = 15
        Me.CmbAnagHidden.FocusBackColor = System.Drawing.Color.LightBlue
        Me.CmbAnagHidden.FocusForeColor = System.Drawing.Color.Black
        Me.CmbAnagHidden.Images.Add(CType(resources.GetObject("CmbAnagHidden.Images"), System.Drawing.Image))
        Me.CmbAnagHidden.ItemHeight = 15
        Me.CmbAnagHidden.KeyPressFormat = Nothing
        Me.CmbAnagHidden.LimitToList = True
        Me.CmbAnagHidden.Location = New System.Drawing.Point(77, 56)
        Me.CmbAnagHidden.MatchEntryTimeout = CType(2000, Long)
        Me.CmbAnagHidden.MaxDropDownItems = CType(5, Short)
        Me.CmbAnagHidden.MaxLength = 32767
        Me.CmbAnagHidden.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CmbAnagHidden.Name = "CmbAnagHidden"
        Me.CmbAnagHidden.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CmbAnagHidden.Size = New System.Drawing.Size(242, 21)
        Me.CmbAnagHidden.StatusBar = Nothing
        Me.CmbAnagHidden.StatusBarLenght = Nothing
        Me.CmbAnagHidden.StatusBarText = Nothing
        Me.CmbAnagHidden.StatusBarType = Nothing
        Me.CmbAnagHidden.TabIndex = 22
        Me.CmbAnagHidden.ValueMember = "Hidden"
        Me.CmbAnagHidden.PropBag = resources.GetString("CmbAnagHidden.PropBag")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Deposito"
        '
        'CmbDeposito
        '
        Me.CmbDeposito.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CmbDeposito.AllowColMove = False
        Me.CmbDeposito.AllowSort = False
        Me.CmbDeposito.AutoSelect = True
        Me.CmbDeposito.Caption = ""
        Me.CmbDeposito.CaptionHeight = 17
        Me.CmbDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CmbDeposito.ColumnCaptionHeight = 17
        Me.CmbDeposito.ColumnFooterHeight = 17
        Me.CmbDeposito.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CmbDeposito.ContentHeight = 15
        Me.CmbDeposito.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CmbDeposito.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CmbDeposito.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbDeposito.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbDeposito.EditorHeight = 15
        Me.CmbDeposito.FocusBackColor = System.Drawing.Color.LightBlue
        Me.CmbDeposito.FocusForeColor = System.Drawing.Color.Black
        Me.CmbDeposito.Images.Add(CType(resources.GetObject("CmbDeposito.Images"), System.Drawing.Image))
        Me.CmbDeposito.ItemHeight = 15
        Me.CmbDeposito.KeyPressFormat = Nothing
        Me.CmbDeposito.LimitToList = True
        Me.CmbDeposito.Location = New System.Drawing.Point(76, 2)
        Me.CmbDeposito.MatchEntryTimeout = CType(2000, Long)
        Me.CmbDeposito.MaxDropDownItems = CType(5, Short)
        Me.CmbDeposito.MaxLength = 32767
        Me.CmbDeposito.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CmbDeposito.Name = "CmbDeposito"
        Me.CmbDeposito.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CmbDeposito.Size = New System.Drawing.Size(243, 21)
        Me.CmbDeposito.StatusBar = Nothing
        Me.CmbDeposito.StatusBarLenght = Nothing
        Me.CmbDeposito.StatusBarText = Nothing
        Me.CmbDeposito.StatusBarType = Nothing
        Me.CmbDeposito.TabIndex = 4
        Me.CmbDeposito.PropBag = resources.GetString("CmbDeposito.PropBag")
        '
        'GroupFilter
        '
        Me.GroupFilter.Controls.Add(Me.TxtFilterCodice)
        Me.GroupFilter.Controls.Add(Me.TxtFilterId)
        Me.GroupFilter.Controls.Add(Me.TxtFilterAccisa)
        Me.GroupFilter.Controls.Add(Me.TxtFilterPiva)
        Me.GroupFilter.Controls.Add(Me.TxtFilterDenominazione)
        Me.GroupFilter.Controls.Add(Me.LblFilterPiva)
        Me.GroupFilter.Controls.Add(Me.BtnCancelFilter)
        Me.GroupFilter.Controls.Add(Me.BtnApplyFilter)
        Me.GroupFilter.Controls.Add(Me.LblFilterAccisa)
        Me.GroupFilter.Controls.Add(Me.LblFilterCodice)
        Me.GroupFilter.Controls.Add(Me.LblFilterDenominazione)
        Me.GroupFilter.Controls.Add(Me.LblFilterId)
        Me.GroupFilter.Location = New System.Drawing.Point(331, 3)
        Me.GroupFilter.Name = "GroupFilter"
        Me.GroupFilter.Size = New System.Drawing.Size(501, 71)
        Me.GroupFilter.TabIndex = 3
        Me.GroupFilter.TabStop = False
        Me.GroupFilter.Text = "Filtri"
        '
        'TxtFilterCodice
        '
        Me.TxtFilterCodice.FocusBackColor = System.Drawing.Color.LightBlue
        Me.TxtFilterCodice.FocusForeColor = System.Drawing.Color.Black
        Me.TxtFilterCodice.KeyPressFormat = Nothing
        Me.TxtFilterCodice.Location = New System.Drawing.Point(56, 43)
        Me.TxtFilterCodice.Name = "TxtFilterCodice"
        Me.TxtFilterCodice.Size = New System.Drawing.Size(61, 20)
        Me.TxtFilterCodice.StatusBar = Nothing
        Me.TxtFilterCodice.StatusBarLenght = Nothing
        Me.TxtFilterCodice.StatusBarText = Nothing
        Me.TxtFilterCodice.StatusBarType = Nothing
        Me.TxtFilterCodice.TabIndex = 16
        '
        'TxtFilterId
        '
        Me.TxtFilterId.FocusBackColor = System.Drawing.Color.LightBlue
        Me.TxtFilterId.FocusForeColor = System.Drawing.Color.Black
        Me.TxtFilterId.KeyPressFormat = ""
        Me.TxtFilterId.Location = New System.Drawing.Point(56, 20)
        Me.TxtFilterId.Name = "TxtFilterId"
        Me.TxtFilterId.Size = New System.Drawing.Size(61, 20)
        Me.TxtFilterId.StatusBar = Me.StatusBar1
        Me.TxtFilterId.StatusBarLenght = "5"
        Me.TxtFilterId.StatusBarText = "Identificativo univoco del record in anagrafica"
        Me.TxtFilterId.StatusBarType = "NUM"
        Me.TxtFilterId.TabIndex = 15
        Me.TxtFilterId.ValidatingType = GetType(Integer)
        '
        'TxtFilterAccisa
        '
        Me.TxtFilterAccisa.FocusBackColor = System.Drawing.Color.LightBlue
        Me.TxtFilterAccisa.FocusForeColor = System.Drawing.Color.Black
        Me.TxtFilterAccisa.KeyPressFormat = Nothing
        Me.TxtFilterAccisa.Location = New System.Drawing.Point(165, 42)
        Me.TxtFilterAccisa.Name = "TxtFilterAccisa"
        Me.TxtFilterAccisa.Size = New System.Drawing.Size(61, 20)
        Me.TxtFilterAccisa.StatusBar = Nothing
        Me.TxtFilterAccisa.StatusBarLenght = Nothing
        Me.TxtFilterAccisa.StatusBarText = Nothing
        Me.TxtFilterAccisa.StatusBarType = Nothing
        Me.TxtFilterAccisa.TabIndex = 18
        '
        'TxtFilterPiva
        '
        Me.TxtFilterPiva.FocusBackColor = System.Drawing.Color.LightBlue
        Me.TxtFilterPiva.FocusForeColor = System.Drawing.Color.Black
        Me.TxtFilterPiva.KeyPressFormat = Nothing
        Me.TxtFilterPiva.Location = New System.Drawing.Point(165, 20)
        Me.TxtFilterPiva.Name = "TxtFilterPiva"
        Me.TxtFilterPiva.Size = New System.Drawing.Size(61, 20)
        Me.TxtFilterPiva.StatusBar = Nothing
        Me.TxtFilterPiva.StatusBarLenght = Nothing
        Me.TxtFilterPiva.StatusBarText = Nothing
        Me.TxtFilterPiva.StatusBarType = Nothing
        Me.TxtFilterPiva.TabIndex = 17
        '
        'TxtFilterDenominazione
        '
        Me.TxtFilterDenominazione.FocusBackColor = System.Drawing.Color.LightBlue
        Me.TxtFilterDenominazione.FocusForeColor = System.Drawing.Color.Black
        Me.TxtFilterDenominazione.KeyPressFormat = Nothing
        Me.TxtFilterDenominazione.Location = New System.Drawing.Point(316, 20)
        Me.TxtFilterDenominazione.Name = "TxtFilterDenominazione"
        Me.TxtFilterDenominazione.Size = New System.Drawing.Size(100, 20)
        Me.TxtFilterDenominazione.StatusBar = Nothing
        Me.TxtFilterDenominazione.StatusBarLenght = Nothing
        Me.TxtFilterDenominazione.StatusBarText = Nothing
        Me.TxtFilterDenominazione.StatusBarType = Nothing
        Me.TxtFilterDenominazione.TabIndex = 19
        '
        'LblFilterPiva
        '
        Me.LblFilterPiva.AutoSize = True
        Me.LblFilterPiva.Location = New System.Drawing.Point(125, 23)
        Me.LblFilterPiva.Name = "LblFilterPiva"
        Me.LblFilterPiva.Size = New System.Drawing.Size(34, 13)
        Me.LblFilterPiva.TabIndex = 11
        Me.LblFilterPiva.Text = "P.IVA"
        '
        'BtnCancelFilter
        '
        Me.BtnCancelFilter.Location = New System.Drawing.Point(422, 40)
        Me.BtnCancelFilter.Name = "BtnCancelFilter"
        Me.BtnCancelFilter.Size = New System.Drawing.Size(73, 23)
        Me.BtnCancelFilter.TabIndex = 21
        Me.BtnCancelFilter.Text = "Annulla"
        Me.BtnCancelFilter.UseVisualStyleBackColor = True
        '
        'BtnApplyFilter
        '
        Me.BtnApplyFilter.Location = New System.Drawing.Point(422, 15)
        Me.BtnApplyFilter.Name = "BtnApplyFilter"
        Me.BtnApplyFilter.Size = New System.Drawing.Size(73, 23)
        Me.BtnApplyFilter.TabIndex = 20
        Me.BtnApplyFilter.Text = "Applica"
        Me.BtnApplyFilter.UseVisualStyleBackColor = True
        '
        'LblFilterAccisa
        '
        Me.LblFilterAccisa.AutoSize = True
        Me.LblFilterAccisa.Location = New System.Drawing.Point(120, 45)
        Me.LblFilterAccisa.Name = "LblFilterAccisa"
        Me.LblFilterAccisa.Size = New System.Drawing.Size(39, 13)
        Me.LblFilterAccisa.TabIndex = 7
        Me.LblFilterAccisa.Text = "Accisa"
        '
        'LblFilterCodice
        '
        Me.LblFilterCodice.AutoSize = True
        Me.LblFilterCodice.Location = New System.Drawing.Point(10, 45)
        Me.LblFilterCodice.Name = "LblFilterCodice"
        Me.LblFilterCodice.Size = New System.Drawing.Size(40, 13)
        Me.LblFilterCodice.TabIndex = 5
        Me.LblFilterCodice.Text = "Codice"
        '
        'LblFilterDenominazione
        '
        Me.LblFilterDenominazione.AutoSize = True
        Me.LblFilterDenominazione.Location = New System.Drawing.Point(232, 23)
        Me.LblFilterDenominazione.Name = "LblFilterDenominazione"
        Me.LblFilterDenominazione.Size = New System.Drawing.Size(80, 13)
        Me.LblFilterDenominazione.TabIndex = 3
        Me.LblFilterDenominazione.Text = "Denominazione"
        '
        'LblFilterId
        '
        Me.LblFilterId.AutoSize = True
        Me.LblFilterId.Location = New System.Drawing.Point(34, 23)
        Me.LblFilterId.Name = "LblFilterId"
        Me.LblFilterId.Size = New System.Drawing.Size(16, 13)
        Me.LblFilterId.TabIndex = 1
        Me.LblFilterId.Text = "Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Anagrafica"
        '
        'CmbTipoAnagrafica
        '
        Me.CmbTipoAnagrafica.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CmbTipoAnagrafica.AllowColMove = False
        Me.CmbTipoAnagrafica.AllowSort = False
        Me.CmbTipoAnagrafica.AutoSelect = True
        Me.CmbTipoAnagrafica.Caption = ""
        Me.CmbTipoAnagrafica.CaptionHeight = 17
        Me.CmbTipoAnagrafica.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CmbTipoAnagrafica.ColumnCaptionHeight = 17
        Me.CmbTipoAnagrafica.ColumnFooterHeight = 17
        Me.CmbTipoAnagrafica.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CmbTipoAnagrafica.ContentHeight = 15
        Me.CmbTipoAnagrafica.DataMode = C1.Win.C1List.DataModeEnum.AddItem
        Me.CmbTipoAnagrafica.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CmbTipoAnagrafica.DisplayMember = "descrizione"
        Me.CmbTipoAnagrafica.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CmbTipoAnagrafica.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTipoAnagrafica.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbTipoAnagrafica.EditorHeight = 15
        Me.CmbTipoAnagrafica.FocusBackColor = System.Drawing.Color.LightBlue
        Me.CmbTipoAnagrafica.FocusForeColor = System.Drawing.Color.Black
        Me.CmbTipoAnagrafica.Images.Add(CType(resources.GetObject("CmbTipoAnagrafica.Images"), System.Drawing.Image))
        Me.CmbTipoAnagrafica.ItemHeight = 15
        Me.CmbTipoAnagrafica.KeyPressFormat = Nothing
        Me.CmbTipoAnagrafica.LimitToList = True
        Me.CmbTipoAnagrafica.Location = New System.Drawing.Point(76, 29)
        Me.CmbTipoAnagrafica.MatchEntryTimeout = CType(2000, Long)
        Me.CmbTipoAnagrafica.MaxDropDownItems = CType(5, Short)
        Me.CmbTipoAnagrafica.MaxLength = 32767
        Me.CmbTipoAnagrafica.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CmbTipoAnagrafica.Name = "CmbTipoAnagrafica"
        Me.CmbTipoAnagrafica.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CmbTipoAnagrafica.Size = New System.Drawing.Size(243, 21)
        Me.CmbTipoAnagrafica.StatusBar = Nothing
        Me.CmbTipoAnagrafica.StatusBarLenght = Nothing
        Me.CmbTipoAnagrafica.StatusBarText = Nothing
        Me.CmbTipoAnagrafica.StatusBarType = Nothing
        Me.CmbTipoAnagrafica.TabIndex = 0
        Me.CmbTipoAnagrafica.ValueMember = "codice"
        Me.CmbTipoAnagrafica.PropBag = resources.GetString("CmbTipoAnagrafica.PropBag")
        '
        'AnagraficheDaa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1047, 676)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "AnagraficheDaa"
        Me.Text = "Anagrafiche DAA"
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.ToolStrip1, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DropTipoDestinazione, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropStatoMembro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropLingua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGridAnagrafica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuGridAnagrafica.ResumeLayout(False)
        CType(Me.DBGridDestinazione, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CmbAnagHidden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbDeposito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupFilter.ResumeLayout(False)
        Me.GroupFilter.PerformLayout()
        CType(Me.CmbTipoAnagrafica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnPrev As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DBGridAnagrafica As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C1Combo1 As C1.Win.C1List.C1Combo
    'Friend WithEvents CmbTipoAnagrafica As C1.Win.C1List.C1Combo
    Friend WithEvents CmbTipoAnagrafica As FlexGroup.C1ComboBoxIntegraV2
    Friend WithEvents DBGridDestinazione As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupFilter As System.Windows.Forms.GroupBox
    Friend WithEvents LblFilterAccisa As System.Windows.Forms.Label
    Friend WithEvents LblFilterCodice As System.Windows.Forms.Label
    Friend WithEvents LblFilterDenominazione As System.Windows.Forms.Label
    Friend WithEvents LblFilterId As System.Windows.Forms.Label
    Friend WithEvents BtnApplyFilter As System.Windows.Forms.Button
    Friend WithEvents BtnCancelFilter As System.Windows.Forms.Button
    Friend WithEvents LblFilterPiva As System.Windows.Forms.Label
    Friend WithEvents TxtFilterDenominazione As FunzioniIntegra.TextBoxIntegra
    Friend WithEvents TxtFilterPiva As FunzioniIntegra.TextBoxIntegra
    Friend WithEvents TxtFilterCodice As FunzioniIntegra.TextBoxIntegra
    Friend WithEvents TxtFilterId As FunzioniIntegra.TextBoxIntegra
    Friend WithEvents TxtFilterAccisa As FunzioniIntegra.TextBoxIntegra
    Friend WithEvents DropLingua As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents DropStatoMembro As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    'Friend WithEvents CmbDeposito As C1.Win.C1List.C1Combo
    Friend WithEvents CmbDeposito As FlexGroup.C1ComboBoxIntegraV2
    Friend WithEvents LblAnagHidden As System.Windows.Forms.Label
    'Friend WithEvents CmbAnagHidden As C1.Win.C1List.C1Combo
    Friend WithEvents CmbAnagHidden As FlexGroup.C1ComboBoxIntegraV2
    Friend WithEvents ContextMenuGridAnagrafica As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ContextAnagItem_Manuali As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextAnagItem_Importate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextAnagItem_CopiaInSpeditori As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextAnagItem_CopiaInDestinatari As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextAnagItem_CopiaInAziendeDiTrasporto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextAnagItem_CopiaInTraportatori As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextAnagItem_CopiaInGaranti As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DropTipoDestinazione As C1.Win.C1TrueDBGrid.C1TrueDBDropdown

End Class
