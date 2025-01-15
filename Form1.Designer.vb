<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer


    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        login = New Button()
        cancel = New Button()
        TB1 = New TextBox()
        TB2 = New TextBox()
        SuspendLayout()

        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Menu
        Label1.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.InfoText
        Label1.Location = New Point(379, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 25)
        Label1.TabIndex = 0
        Label1.Text = "Authentification"

        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label2.Location = New Point(103, 151)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 25)
        Label2.TabIndex = 1
        Label2.Text = "Nom Utilisateur"

        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label3.Location = New Point(103, 258)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 25)
        Label3.TabIndex = 2
        Label3.Text = "Mot De Passe"

        login.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        login.Location = New Point(498, 366)
        login.Name = "login"
        login.Size = New Size(128, 29)
        login.TabIndex = 3
        login.Text = "Se Connecter"
        login.UseVisualStyleBackColor = True

        cancel.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        cancel.Location = New Point(302, 366)
        cancel.Name = "cancel"
        cancel.Size = New Size(141, 29)
        cancel.TabIndex = 4
        cancel.Text = "Annuler"
        cancel.UseVisualStyleBackColor = True

        TB1.Location = New Point(302, 151)
        TB1.Name = "TB1"
        TB1.Size = New Size(324, 27)
        TB1.TabIndex = 5

        TB2.Location = New Point(302, 259)
        TB2.Name = "TB2"
        TB2.Size = New Size(324, 27)
        TB2.TabIndex = 6

        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GrayText
        ClientSize = New Size(797, 450)
        Controls.Add(TB2)
        Controls.Add(TB1)
        Controls.Add(cancel)
        Controls.Add(login)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents login As Button
    Friend WithEvents cancel As Button
    Friend WithEvents TB1 As TextBox
    Friend WithEvents TB2 As TextBox

End Class
