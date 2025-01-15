<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        label1 = New Label()
        btnAddFlight = New Button()
        btnEditFlight = New Button()
        btnDeleteFlight = New Button()
        btnLogout = New Button()
        dgvFlights = New DataGridView()
        CType(dgvFlights, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        label1.Location = New Point(274, 49)
        label1.Name = "label1"
        label1.Size = New Size(246, 28)
        label1.TabIndex = 0
        label1.Text = "Interface Administrateur"
        ' 
        ' btnAddFlight
        ' 
        btnAddFlight.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnAddFlight.Location = New Point(69, 351)
        btnAddFlight.Name = "btnAddFlight"
        btnAddFlight.Size = New Size(123, 29)
        btnAddFlight.TabIndex = 1
        btnAddFlight.Text = "Ajouter un vol"
        ' 
        ' btnEditFlight
        ' 
        btnEditFlight.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnEditFlight.Location = New Point(234, 351)
        btnEditFlight.Name = "btnEditFlight"
        btnEditFlight.Size = New Size(141, 29)
        btnEditFlight.TabIndex = 2
        btnEditFlight.Text = "Modifier un vol"
        btnEditFlight.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteFlight
        ' 
        btnDeleteFlight.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnDeleteFlight.Location = New Point(411, 351)
        btnDeleteFlight.Name = "btnDeleteFlight"
        btnDeleteFlight.Size = New Size(145, 29)
        btnDeleteFlight.TabIndex = 3
        btnDeleteFlight.Text = "Supprimer un vol"
        btnDeleteFlight.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnLogout.Location = New Point(582, 351)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(123, 29)
        btnLogout.TabIndex = 4
        btnLogout.Text = "Déconnexion"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' dgvFlights
        ' 
        dgvFlights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFlights.Location = New Point(47, 125)
        dgvFlights.Name = "dgvFlights"
        dgvFlights.RowHeadersWidth = 51
        dgvFlights.Size = New Size(698, 188)
        dgvFlights.TabIndex = 5
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.WindowFrame
        ClientSize = New Size(800, 450)
        Controls.Add(dgvFlights)
        Controls.Add(btnLogout)
        Controls.Add(btnDeleteFlight)
        Controls.Add(btnEditFlight)
        Controls.Add(btnAddFlight)
        Controls.Add(label1)
        Name = "Form2"
        Text = "Form2"
        CType(dgvFlights, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents btnAddFlight As Button
    Friend WithEvents btnEditFlight As Button
    Friend WithEvents btnDeleteFlight As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents dgvFlights As DataGridView
End Class