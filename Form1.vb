Public Class Form1
    Private Users As Dictionary(Of String, Tuple(Of String, String)) = New Dictionary(Of String, Tuple(Of String, String)) From {
        {"admin", New Tuple(Of String, String)("admin123", "Admin")},
        {"user", New Tuple(Of String, String)("user123", "Utilisateur")}
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Connexion"
        TB2.PasswordChar = "*"c
    End Sub

    Private Sub LoginClick(sender As Object, e As EventArgs) Handles login.Click
        Dim username As String = TB1.Text
        Dim password As String = TB2.Text

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Veuillez entrer un nom d'utilisateur et un mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim userInfo As Tuple(Of String, String) = Nothing
        If Users.TryGetValue(username, userInfo) AndAlso userInfo.Item1 = password Then
            Dim role As String = userInfo.Item2
            MessageBox.Show($"Bienvenue {username}! Vous êtes connecté en tant que {role}.", "Connexion réussie", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If role = "Admin" Then
                Dim form2 As New Form2()
                form2.Show()
                Me.Hide()
            ElseIf role = "Utilisateur" Then
                Dim form3 As New Form3(New Form2())
                form3.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CancelClick(sender As Object, e As EventArgs) Handles cancel.Click
        Application.Exit()
    End Sub
End Class