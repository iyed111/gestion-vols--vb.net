Public Class Form3

    Private form2Instance As Form2
    Private Flights As New DataTable()

    Public Sub New(form2Instance As Form2)
        InitializeComponent()
        Me.form2Instance = form2Instance
    End Sub

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Interface Utilisateur"
        Me.Size = New Size(800, 600)

        Flights.Columns.Add("Numéro de vol", GetType(String))
        Flights.Columns.Add("Destination", GetType(String))
        Flights.Columns.Add("Date et Heure", GetType(DateTime))
        Flights.Columns.Add("Nombre de places", GetType(Integer))
        Flights.Columns.Add("Prix", GetType(Decimal))

        Flights.Rows.Add("V001", "Paris", DateTime.Now.AddDays(1), 100, 150D)
        Flights.Rows.Add("V002", "Londres", DateTime.Now.AddDays(2), 50, 200D)
        Flights.Rows.Add("V003", "New York", DateTime.Now.AddDays(3), 30, 500D)
        Flights.Rows.Add("V004", "Tokyo", DateTime.Now.AddDays(4), 20, 700D)

        DgvAvailableFlights.DataSource = Flights
        DgvAvailableFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Try
            Dim destination As String = InputBox("Entrez la destination :", "Recherche de vols")
            Dim dateInput As String = InputBox("Entrez la date (format : JJ/MM/AAAA) :", "Recherche de vols")
            Dim dateFilter As DateTime

            Dim filter As String = ""

            If Not String.IsNullOrWhiteSpace(destination) Then
                filter &= $"[Destination] LIKE '%{destination}%'"
            End If

            If DateTime.TryParse(dateInput, dateFilter) Then
                If filter <> "" Then filter &= " AND "
                filter &= $"CONVERT([Date et Heure], 'System.String') LIKE '%{dateFilter.ToShortDateString()}%'"
            End If

            If Flights.Rows.Count > 0 Then
                Dim filteredRows = Flights.Select(filter)
                If filteredRows.Length > 0 Then
                    Dim filteredTable As DataTable = Flights.Clone()
                    For Each row As DataRow In filteredRows
                        filteredTable.ImportRow(row)
                    Next
                    DgvAvailableFlights.DataSource = filteredTable
                Else
                    MessageBox.Show("Aucun vol correspondant trouvé.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DgvAvailableFlights.DataSource = Flights
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Une erreur est survenue lors de la recherche." & Environment.NewLine & ex.Message,
                            "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles BtnReserve.Click
        Try
            If DgvAvailableFlights.SelectedRows.Count > 0 Then
                Dim selectedRow As DataRow = CType(DgvAvailableFlights.SelectedRows(0).DataBoundItem, DataRowView).Row

                Dim clientName As String = InputBox("Entrez le nom du client :", "Réservation")
                If String.IsNullOrWhiteSpace(clientName) Then
                    MessageBox.Show("Le nom du client est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim clientSurName As String = InputBox("Entrez le prenom du client :", "Réservation")
                If String.IsNullOrWhiteSpace(clientSurName) Then
                    MessageBox.Show("Le prenom du client est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim clientPhone As String = InputBox("Entrez le numéro de téléphone :", "Réservation")
                If String.IsNullOrWhiteSpace(clientPhone) Then
                    MessageBox.Show("Le numéro de téléphone est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim availableSeats As Integer = Convert.ToInt32(selectedRow("Nombre de places"))
                If availableSeats > 0 Then
                    selectedRow("Nombre de places") = availableSeats - 1

                    Dim receipt As String = $"Réservation réussie !{Environment.NewLine}" &
                                            $"Nom : {clientName}{Environment.NewLine}" &
                                            $"Prénom : {clientSurName}{Environment.NewLine}" &
                                            $"Téléphone : {clientPhone}{Environment.NewLine}" &
                                            $"Vol : {selectedRow("Numéro de vol")}{Environment.NewLine}" &
                                            $"Destination : {selectedRow("Destination")}{Environment.NewLine}" &
                                            $"Date : {selectedRow("Date et Heure")}{Environment.NewLine}" &
                                            $"Prix : {selectedRow("Prix")}{Environment.NewLine}"

                    MessageBox.Show(receipt, "Reçu de réservation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Aucune place disponible pour ce vol.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Veuillez sélectionner un vol à réserver.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Une erreur est survenue lors de la réservation." & Environment.NewLine & ex.Message,
                            "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        MessageBox.Show("Déconnexion réussie.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim loginForm As New Form1()
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub DgvAvailableFlights_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAvailableFlights.CellContentClick
    End Sub
End Class