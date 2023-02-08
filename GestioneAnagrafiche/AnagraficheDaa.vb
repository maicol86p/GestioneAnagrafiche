Imports FunzioniIntegra
Imports System.Data.SqlClient
Imports Integra.WebAcsi
Imports System.Windows.Forms
Imports System.ComponentModel
Imports Integra.WebAcsi.Database
Imports C1.Win.C1TrueDBGrid
Imports System.Data


Public Class AnagraficheDaa
    Inherits BaseForm

    ReadOnly Property TipoAnagrafica()
        Get
            TipoAnagrafica = CmbTipoAnagrafica.SelectedValue
        End Get
    End Property

    ReadOnly Property Deposito()
        Get
            Deposito = CmbDeposito.SelectedValue
        End Get
    End Property

    ReadOnly Property AnagHidden() As Boolean
        Get
            AnagHidden = False
            If CmbAnagHidden.SelectedValue = "1" Then
                AnagHidden = True
            End If
        End Get
    End Property

    ReadOnly Property CurrentAnagId() As Integer
        Get
            Dim anagraficaId As Integer = 0
            Dim anagraficaIdString As String = ""
            'anagraficaIdString = DBGridAnagrafica.Item(DBGridAnagrafica.Bookmark, "Id")
            anagraficaIdString = DBGridAnagrafica.Columns("Id").Value
            If String.IsNullOrEmpty(anagraficaIdString) Then
                anagraficaIdString = "0"
            End If
            If Not Integer.TryParse(anagraficaIdString, anagraficaId) Then
                anagraficaId = 0
            End If
            Return anagraficaId
        End Get
    End Property


    Private Sub AnagraficheDaa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.Form_Load(sender, e)

        Database.ConnString = Globali.databaseManager.getConnectionString()
        PgnUserCurrent.UserName = Globali.utente
        PgnUserCurrent.AccessCode = Globali.codiceSocieta

        loadComboDeposito()
        loadCmbTipoAnagrafica()
        loadCmbAnagHidden()
        loadGridAnagrafica()
        loadDropLingua()
        loadDropStatoMembro()
        loadDropTipoDestinazione()

        If CType(CmbDeposito.DataSource, DataTable).Rows.Count = 1 Then
            CmbDeposito.Text = CType(CmbDeposito.DataSource, DataTable).Rows(0)(0)
            loadDropLingua()
            loadDropStatoMembro()
            loadDropTipoDestinazione()
        End If
    End Sub

    Sub loadCmbAnagHidden()
        CmbAnagHidden.HoldFields()
        CmbAnagHidden.AddItem("0;Manuali")   'inserite dall utente
        CmbAnagHidden.AddItem("1;Importate") 'importate con messaggi (anag incomplete)
        'CmbAnagHidden.AddItem("2;Tutte")     'tutte
    End Sub

    Sub loadCmbTipoAnagrafica()
        CmbTipoAnagrafica.HoldFields()
        CmbTipoAnagrafica.AddItem("S;Speditore")
        CmbTipoAnagrafica.AddItem("D;Destinatari")
        CmbTipoAnagrafica.AddItem("T;Aziende di trasporto") 'no dettagli
        CmbTipoAnagrafica.AddItem("P;Trasportatori")        'no dettagli
        CmbTipoAnagrafica.AddItem("G;Garanti")
    End Sub

    Sub loadComboDeposito()
        Try
            Dim qtmDeposito As QueryTableManager
            Dim sql As String

            CmbDeposito.HoldFields()

            sql = "Select  accisada, deposito " _
            & " From tabella_accise_utenti " _
            & " WHERE codsoc = '" & FunzioniIntegra.Globali.codiceSocieta & "' "
            qtmDeposito = Dbm.getQueryTableManager(sql)
            CmbDeposito.ValueMember = "accisada"
            CmbDeposito.DisplayMember = "accisada"
            CmbDeposito.DataSource = qtmDeposito.Table
            CmbDeposito.Rebind(True)

        Catch ex As Exception
            GestioneErrori.erroreStandard(ex)
        End Try
    End Sub

    Sub loadDropLingua()
        Try
            Dim man As New DaaAcciseManager(Me.Deposito)
            Dim filter As New DaaAcciseFilter()
            filter.Tipo_Tabella = "T001"    'tabella codici lingue
            filter.Visibile = Utility.TristateBool.True

            Dim ds As New BindingList(Of DaaAccise)(man.GetByFilter(filter, ""))
            DropLingua.SetDataBinding(ds, "", True)
            'DropLingua.Rebind(True)
        Catch ex As Exception
            GestioneErrori.erroreStandard(ex)
        End Try
    End Sub

    Sub loadDropTipoDestinazione()
        Try

            Dim man As New DaaAcciseManager(Me.Deposito)
            Dim filter As New DaaAcciseFilter()
            filter.Tipo_Tabella = "T015"    'codici destinazione
            'filter.Visibile = Utility.TristateBool.True

            Dim ds As New BindingList(Of DaaAccise)(man.GetByFilter(filter, ""))
            ds.Add(New DaaAccise())
            DropTipoDestinazione.SetDataBinding(ds, "", True)
        Catch ex As Exception
            GestioneErrori.erroreStandard(ex)
        End Try
    End Sub

    Sub loadDropStatoMembro()
        Try
            Dim man As New DaaAcciseManager(Me.Deposito)
            Dim filter As New DaaAcciseFilter()
            filter.Tipo_Tabella = "T004"    'tabella stati membro
            filter.Visibile = Utility.TristateBool.True

            Dim ds As New BindingList(Of DaaAccise)(man.GetByFilter(filter, ""))
            DropStatoMembro.SetDataBinding(ds, "", True)
            'DropStatoMembro.Rebind(True)
        Catch ex As Exception
            GestioneErrori.erroreStandard(ex)
        End Try
    End Sub

    Sub loadGridAnagrafica()
        loadGridAnagrafica("")
    End Sub

    Sub loadGridAnagrafica(ByVal sort As String)
        Try
            'nascondo tipo destinazione se la tipologia non è destinatario
            If Me.TipoAnagrafica = "D" Then
                DBGridAnagrafica.Splits(0).DisplayColumns("TipoDestinazione").Visible = True
            Else
                DBGridAnagrafica.Splits(0).DisplayColumns("TipoDestinazione").Visible = False
            End If

            If String.IsNullOrEmpty(Me.TipoAnagrafica) Then
                DBGridAnagrafica.Visible = False
            Else
                DBGridAnagrafica.Visible = True
            End If

            Dim listaCampi = getCampiDestinazione(Me.TipoAnagrafica)
            Dim man As New DaaAnagraficaManager(FunzioniIntegra.Globali.codiceSocieta)
            Dim filter As New DaaAnagraficaFilter()
            filter.Tipo = Me.TipoAnagrafica
            filter.Hidden = Me.AnagHidden
            'Select Case CmbAnagHidden.SelectedValue
            '    Case "1"
            '        filter.Hidden = Utility.TristateBool.True
            '    Case "0"
            '        filter.Hidden = Utility.TristateBool.False
            '    Case Else
            '        filter.Hidden = Utility.TristateBool.NotSet
            'End Select

            Dim intParam = 0
            If Integer.TryParse(TxtFilterId.Text, intParam) Then
                filter.IdLike = intParam.ToString()
            End If
            filter.CodiceIdentificativoLike = TxtFilterCodice.Text
            filter.PartitaIvaLike = TxtFilterPiva.Text
            filter.CodiceAccisaLike = TxtFilterAccisa.Text
            filter.DenominazioneLike = TxtFilterDenominazione.Text


            Dim ds As New BindingList(Of DaaAnagrafica)(man.GetByFilter(filter, sort))
            DBGridAnagrafica.SetDataBinding(ds, "", True)


            For Each item As C1.Win.C1TrueDBGrid.C1DisplayColumn In DBGridDestinazione.Splits(0).DisplayColumns
                If listaCampi.Contains(item.DataColumn.DataField.ToLower()) _
                    Or listaCampi.Contains(item.DataColumn.Caption.ToLower()) Then
                    item.Visible = True
                Else
                    item.Visible = False
                End If
            Next

            DBGridAnagrafica.Rebind(True)

        Catch ex As Exception
            GestioneErrori.erroreStandard(ex)
        End Try
    End Sub

    ''' <summary>
    ''' carica la grid destinazione a seconda della grid anagrafica
    ''' </summary>
    ''' <remarks></remarks>
    Sub loadGridDestinazione()
        Try
            Dim listaCampi = getCampiDestinazione(Me.TipoAnagrafica)
            Dim showGridDestinazione As Boolean = False

            If Me.CurrentAnagId > 0 Then
                showGridDestinazione = True
                If Me.TipoAnagrafica = "T" Or Me.TipoAnagrafica = "P" Then
                    'trasporto e trasportatori non hanno dettagli
                    showGridDestinazione = False
                End If
            End If
            DBGridDestinazione.Visible = showGridDestinazione

            Dim man As New DaaAnagraficaManager(FunzioniIntegra.Globali.codiceSocieta)
            Dim ds As New BindingList(Of DaaAnagraficaDest)(man.GetByKey(Me.CurrentAnagId).Destinazioni)
            DBGridDestinazione.SetDataBinding(ds, "", True)

            For Each item As C1.Win.C1TrueDBGrid.C1DisplayColumn In DBGridDestinazione.Splits(0).DisplayColumns
                If listaCampi.Contains(item.DataColumn.DataField.ToLower()) _
                    Or listaCampi.Contains(item.DataColumn.Caption.ToLower()) Then
                    item.Visible = True
                Else
                    item.Visible = False
                End If
            Next

            DBGridDestinazione.Rebind(True)

        Catch ex As Exception
            GestioneErrori.erroreStandard(ex)
        End Try
    End Sub


    Private Function getCampiDestinazione(ByVal tipoAnagrafica As String) As List(Of String)
        Dim listaCampi As New List(Of String)

        listaCampi.Add("idanagrafica")
        listaCampi.Add("codiceufficio")
        listaCampi.Add("codiceautoritaspedizione")
        listaCampi.Add("id")
        listaCampi.Add("codsoc")
        listaCampi.Add("codiceidentificativo")
        listaCampi.Add("partitaiva")
        listaCampi.Add("codiceaccisa")
        listaCampi.Add("denominazione")
        listaCampi.Add("indirizzo")
        listaCampi.Add("numerocivico")
        listaCampi.Add("cap")
        listaCampi.Add("citta")
        listaCampi.Add("linguadescrizione")
        listaCampi.Add("tipo")
        'listaCampi.Add("codicestatomembro")
        listaCampi.Add("certificatoesenzione")

        Select Case tipoAnagrafica.ToUpper()
            Case "S"
                listaCampi.Remove("codiceaccisa")
                listaCampi.Remove("partitaiva")
                'listaCampi.Remove("codicestatomembro")
                listaCampi.Remove("certificatoesenzione")
            Case "D"
                listaCampi.Remove("codiceaccisa")
                listaCampi.Remove("partitaiva")
                'listaCampi.Remove("codicestatomembro")
                listaCampi.Remove("certificatoesenzione")
            Case "T"
                listaCampi.Remove("codiceaccisa")
                listaCampi.Remove("partitaiva")
                'listaCampi.Remove("codicestatomembro")
                listaCampi.Remove("certificatoesenzione")

        End Select

        getCampiDestinazione = listaCampi
    End Function

    Private Sub CmbDeposito_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDeposito.Change
        loadDropLingua()
        loadDropStatoMembro()
    End Sub


    Private Sub DBGridAnagrafica_OnAddNew(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBGridAnagrafica.OnAddNew
        DBGridAnagrafica.Columns("Id").Value = 0   'per identificare nuova riga
        DBGridAnagrafica.Columns("CodiceStatoMembro").Value = "IT"   'default
        DBGridAnagrafica.Columns("LinguaDescrizione").Value = "it"   'default
    End Sub

    Private Sub DBGridAnagrafica_RowColChange(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles DBGridAnagrafica.RowColChange
        loadGridDestinazione()
    End Sub

    Private Sub DBGrid_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DBGridAnagrafica.MouseClick, DBGridDestinazione.MouseClick, ContextMenuGridAnagrafica.MouseClick
        Try
            If CType(sender, C1TrueDBGrid).Row > -1 Then
                CType(sender, C1TrueDBGrid).SelectedRows.Add(CType(sender, C1TrueDBGrid).Row)
            End If
        Catch
        End Try
    End Sub

    Private Sub DBGridAnagrafica_BeforeUpdate(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles DBGridAnagrafica.BeforeUpdate
        Dim man As New DaaAnagraficaManager(Globali.codiceSocieta)
        Dim row As New DaaAnagrafica()
        Try
            Dim ds As BindingList(Of DaaAnagrafica) = DBGridAnagrafica.DataSource
            row = ds(DBGridAnagrafica.Bookmark)

            If String.IsNullOrEmpty(row.LinguaDescrizione) Then
                row.LinguaDescrizione = "it"
            End If

            If row.Id > 0 Then
                man.Update(row, True)
            Else
                row.Tipo = Me.TipoAnagrafica
                row.Hidden = Me.AnagHidden
                man.Insert(row)
            End If

        Catch ex As Exception
            e.Cancel = True
            GestioneErrori.erroreStandard(ex)
        End Try

    End Sub

    Protected Sub DBGridAnagrafica_BeforeDelete(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles DBGridAnagrafica.BeforeDelete
        If MsgBox("Cancellare il record?", MsgBoxStyle.YesNo + vbQuestion, "Conferma cancellazione") = MsgBoxResult.No Then
            e.Cancel = True
        Else
            Try
                Dim man As New DaaAnagraficaManager(Globali.codiceSocieta)
                Dim row As New DaaAnagrafica()
                Dim ds As BindingList(Of DaaAnagrafica) = DBGridAnagrafica.DataSource
                row = ds(DBGridAnagrafica.Row)
                man.DeleteById(row.Id)
            Catch ex As Exception
                e.Cancel = True
                GestioneErrori.erroreStandard(ex)
            End Try
        End If
    End Sub

    Private Sub DBGridAnagrafica_HeadClick(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles DBGridAnagrafica.HeadClick
        Dim dc As C1.Win.C1TrueDBGrid.C1DisplayColumn = DBGridAnagrafica.Splits(0).DisplayColumns(e.ColIndex)
        Dim newsort As SortDir = SortDir.None
        Select Case CType(dc.DataColumn.Tag, SortDir)
            Case SortDir.None, SortDir.Desc
                newsort = SortDir.Asc
            Case Else
                newsort = SortDir.Desc
        End Select

        Dim col As C1.Win.C1TrueDBGrid.C1DisplayColumn
        For Each col In Me.DBGridAnagrafica.Splits(0).DisplayColumns
            col.DataColumn.Tag = SortDir.None
        Next col

        Dim sortCondition As String = dc.DataColumn.DataField + " "
        sortCondition += IIf(newsort = SortDir.Desc, "DESC", "")

        loadGridAnagrafica(sortCondition)
        dc.DataColumn.Tag = newsort
    End Sub

    Private Sub DBGridDestinazione_BeforeUpdate(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles DBGridDestinazione.BeforeUpdate
        Dim man As New DaaAnagraficaDestManager()
        Dim row As New DaaAnagraficaDest()
        Try
            Dim ds As BindingList(Of DaaAnagraficaDest) = DBGridDestinazione.DataSource
            row = ds(DBGridDestinazione.Bookmark)

            If String.IsNullOrEmpty(row.LinguaDescrizione) Then
                row.LinguaDescrizione = "it"
            End If

            If row.Id > 0 Then
                man.Update(row)
            Else
                man.Insert(row)
            End If
        Catch ex As Exception
            e.Cancel = True
            GestioneErrori.erroreStandard(ex)
        End Try

    End Sub

    Private Sub DBGridDestinazione_BeforeDelete(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles DBGridDestinazione.BeforeDelete
        If MsgBox("Cancellare il record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Conferma cancellazione") = MsgBoxResult.No Then
            e.Cancel = True
        Else
            Try
                Dim man As New DaaAnagraficaDestManager()
                Dim row As New DaaAnagraficaDest()
                Dim ds As BindingList(Of DaaAnagraficaDest) = DBGridDestinazione.DataSource
                row = ds(DBGridDestinazione.Row)
                man.DeleteById(row.Id)
            Catch ex As Exception
                e.Cancel = True
                GestioneErrori.erroreStandard(ex)
            End Try
        End If
    End Sub

    Private Sub DBGridDestinazione_OnAddNew(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBGridDestinazione.OnAddNew
        DBGridDestinazione.Columns("Id").Value = 0   'per identificare nuova riga
        DBGridDestinazione.Columns("IdAnagrafica").Value = DBGridAnagrafica.Columns(0).Value
    End Sub

    Private Sub CmbTipoAnagrafica_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTipoAnagrafica.Change
        loadGridAnagrafica()
        loadGridDestinazione()
    End Sub

    Private Sub CmbAnagHidden_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAnagHidden.Change
        loadGridAnagrafica()
        loadGridDestinazione()
    End Sub

    Private Sub BtnApplyFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnApplyFilter.Click
        loadGridAnagrafica()
    End Sub

    Private Sub BtnCancelFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelFilter.Click
        TxtFilterId.Text = ""
        TxtFilterAccisa.Text = ""
        TxtFilterCodice.Text = ""
        TxtFilterDenominazione.Text = ""
        TxtFilterPiva.Text = ""
        loadGridAnagrafica()
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim ds As BindingList(Of DaaAnagrafica) = DBGridAnagrafica.DataSource
        DBGridAnagrafica.Focus()
        DBGridAnagrafica.Row = ds.Count

    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        DBGridAnagrafica.Focus()
        DBGridAnagrafica.Row += 1
    End Sub

    Private Sub BtnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrev.Click
        DBGridAnagrafica.Focus()
        DBGridAnagrafica.Row -= 1
    End Sub

    Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
        DBGridAnagrafica.Focus()
        DBGridAnagrafica.Row = 0
    End Sub

    Private Sub BtnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click
        Dim ds As BindingList(Of DaaAnagrafica) = DBGridAnagrafica.DataSource
        DBGridAnagrafica.Focus()
        If ds.Count > 0 Then
            DBGridAnagrafica.Row = ds.Count - 1
        End If
    End Sub

    Private Sub BtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click
        Try
            Dim grid = DBGridAnagrafica
            Dim cancel As C1.Win.C1TrueDBGrid.CancelEventArgs
            DBGridAnagrafica_BeforeDelete(grid, cancel)
            grid.Delete()
        Catch ex As Exception
            'GestioneErrori.erroreStandard(ex)
        End Try
    End Sub

    Private Sub ContextAnagItem_Importate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextAnagItem_Importate.Click
        changeAnagHiddenMode(Me.CurrentAnagId, True)
    End Sub

    Private Sub ContextAnagItem_Manuali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextAnagItem_Manuali.Click
        changeAnagHiddenMode(Me.CurrentAnagId, False)
    End Sub

    Private Sub ContextAnagItem_CopiaInSpeditori_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextAnagItem_CopiaInSpeditori.Click
        copyAnag(Me.CurrentAnagId, "S")
    End Sub

    Private Sub ContextAnagItem_CopiaInDestinatari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextAnagItem_CopiaInDestinatari.Click
        copyAnag(Me.CurrentAnagId, "D")
    End Sub

    Private Sub ContextAnagItem_CopiaInAziendeDiTrasporto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextAnagItem_CopiaInAziendeDiTrasporto.Click
        copyAnag(Me.CurrentAnagId, "T")
    End Sub

    Private Sub ContextAnagItem_CopiaInTraportatori_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextAnagItem_CopiaInTraportatori.Click
        copyAnag(Me.CurrentAnagId, "P")
    End Sub

    Private Sub ContextAnagItem_CopiaInGaranti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextAnagItem_CopiaInGaranti.Click
        copyAnag(Me.CurrentAnagId, "G")
    End Sub

    ''' <summary>
    ''' duplica un'anagrafica (e le eventuali dest)
    ''' </summary>
    ''' <param name="anagId">id anagrafica di origine</param>
    ''' <param name="tipoAnagDest">tipo anagrafica di destinazione</param>
    ''' <remarks></remarks>
    Private Sub copyAnag(ByVal anagId As Integer, ByVal tipoAnagDest As String)
        Try
            Dim man As New DaaAnagraficaManager(FunzioniIntegra.Globali.codiceSocieta)
            Dim anag As New DaaAnagrafica()
            anag = man.GetByKey(anagId)
            anag.Id = 0
            anag.Tipo = tipoAnagDest
            anag = man.Insert(anag, False)

            Dim manDest As New DaaAnagraficaDestManager()
            For Each anagDest As DaaAnagraficaDest In man.GetByKey(anagId).Destinazioni
                anagDest.IdAnagrafica = anag.Id
                anagDest.Id = 0
                anagDest = manDest.Insert(anagDest, False)
            Next
        Catch ex As Exception
            GestioneErrori.erroreStandard(ex)
        End Try
    End Sub

    Private Function changeAnagHiddenMode(ByVal anagId As Integer, ByVal hidden As Boolean) As Boolean
        Try
            Dim man As New DaaAnagraficaManager(FunzioniIntegra.Globali.codiceSocieta)
            Dim item As New DaaAnagrafica()
            If (anagId > 0) Then
                item = man.GetByKey(anagId)
                item.Hidden = hidden
                man.Update(item, True)
                loadGridAnagrafica()
            End If
        Catch ex1 As DuplicateNameException
            GestioneErrori.erroreStandard(ex1, "Esiste già un record con questo identificativo")
        Catch ex2 As Exception
            GestioneErrori.erroreStandard(ex2)
        End Try
        Return True
    End Function

    Private Sub DBGridAnagrafica_SelChange(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles DBGridAnagrafica.SelChange
        loadGridDestinazione()
    End Sub
End Class
