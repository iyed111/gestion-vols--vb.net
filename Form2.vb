Public Class Form2
    Private FlightsTable As New DataTable()

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Interface Administrateur"
        Me.Size = New Size(800, 600)
        InitializeFlightTable()
        dgvFlights.DataSource = FlightsTable
        LoadFlightsFromFile()
    End Sub

    Private Sub InitializeFlightTable()
        FlightsTable.Columns.Add("Numéro de vol", GetType(String))
        FlightsTable.Columns.Add("Destination", GetType(String))
        FlightsTable.Columns.Add("Date et Heure", GetType(DateTime))
        FlightsTable.Columns.Add("Nombre de places", GetType(Integer))
        FlightsTable.Columns.Add("Prix", GetType(Decimal))
        FlightsTable.Columns.Add("AddedByAdmin", GetType(Boolean))
    End Sub

    Private Sub LoadFlightsFromFile()
        If IO.File.Exists("flights.txt") Then
            FlightsTable.Clear()
            Try
                Using reader As New IO.StreamReader("flights.txt")
                    While Not reader.EndOfStream
                        Dim line As String = reader.ReadLine()
                        Dim parts = line.Split(";"c)
                        If parts.Length = 6 Then
                            FlightsTable.Rows.Add(parts(0), parts(1), DateTime.Parse(parts(2)), Integer.Parse(parts(3)), Decimal.Parse(parts(4)), Boolean.Parse(parts(5)))
                        Else
                            FlightsTable.Rows.Add(parts(0), parts(1), DateTime.Parse(parts(2)), Integer.Parse(parts(3)), Decimal.Parse(parts(4)), True)
                        End If
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Erreur lors du chargement des vols : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Public Sub SaveFlightsToFile()
        Try
            Using writer As New IO.StreamWriter("flights.txt", False)
                For Each row As DataRow In FlightsTable.Rows
                    writer.WriteLine($"{row("Numéro de vol")};{row("Destination")};{row("Date et Heure")};{row("Nombre de places")};{row("Prix")};{row("AddedByAdmin")}")
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur lors de la sauvegarde des vols : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetFlights() As DataTable
        Return FlightsTable
    End Function

    Private Sub btnAddFlight_Click(sender As Object, e As EventArgs) Handles btnAddFlight.Click
        Dim flightNumber As String = InputBox("Entrez le numéro de vol :")
        Dim destination As String = InputBox("Entrez la destination :")
        Dim dateTime As DateTime = DateTime.Parse(InputBox("Entrez la date et l'heure (format : AAAA-MM-JJ HH:MM) :"))
        Dim seats As Integer = Integer.Parse(InputBox("Entrez le nombre de places :"))
        Dim price As Decimal = Decimal.Parse(InputBox("Entrez le prix :"))

        FlightsTable.Rows.Add(flightNumber, destination, dateTime, seats, price, True)
        SaveFlightsToFile()
    End Sub

    Private Sub btnDeleteFlight_Click(sender As Object, e As EventArgs) Handles btnDeleteFlight.Click
        If dgvFlights.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In dgvFlights.SelectedRows
                dgvFlights.Rows.Remove(row)
            Next
            SaveFlightsToFile()
        Else
            MessageBox.Show("Veuillez sélectionner un vol à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEditFlight_Click(sender As Object, e As EventArgs) Handles btnEditFlight.Click
        If dgvFlights.SelectedRows.Count = 1 Then
            Dim selectedRow As DataGridViewRow = dgvFlights.SelectedRows(0)
            Dim flightNumber As String = InputBox("Modifiez le numéro de vol :", , selectedRow.Cells("Numéro de vol").Value.ToString())
            Dim destination As String = InputBox("Modifiez la destination :", , selectedRow.Cells("Destination").Value.ToString())
            Dim dateTime As DateTime = DateTime.Parse(InputBox("Modifiez la date et l'heure (format : AAAA-MM-JJ HH:MM) :", , selectedRow.Cells("Date et Heure").Value.ToString()))
            Dim seats As Integer = Integer.Parse(InputBox("Modifiez le nombre de places :", , selectedRow.Cells("Nombre de places").Value.ToString()))
            Dim price As Decimal = Decimal.Parse(InputBox("Modifiez le prix :", , selectedRow.Cells("Prix").Value.ToString()))

            selectedRow.Cells("Numéro de vol").Value = flightNumber
            selectedRow.Cells("Destination").Value = destination
            selectedRow.Cells("Date et Heure").Value = dateTime
            selectedRow.Cells("Nombre de places").Value = seats
            selectedRow.Cells("Prix").Value = price

            SaveFlightsToFile()
        Else
            MessageBox.Show("Veuillez sélectionner un vol à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        MessageBox.Show("Déconnexion réussie.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim loginForm As New Form1()
        loginForm.Show()
        Me.Close()
    End Sub
End Class