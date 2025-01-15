<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DgvAvailableFlights = New System.Windows.Forms.DataGridView()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnReserve = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DgvAvailableFlights, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.DgvAvailableFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAvailableFlights.Location = New System.Drawing.Point(95, 110)
        Me.DgvAvailableFlights.Name = "DgvAvailableFlights"
        Me.DgvAvailableFlights.RowHeadersWidth = 51
        Me.DgvAvailableFlights.Size = New System.Drawing.Size(580, 188)
        Me.DgvAvailableFlights.TabIndex = 0
        Me.BtnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
        Me.BtnSearch.Location = New System.Drawing.Point(119, 347)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(156, 29)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.Text = "Rechercher un vol"
        Me.BtnSearch.UseVisualStyleBackColor = True
        Me.BtnReserve.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
        Me.BtnReserve.Location = New System.Drawing.Point(313, 347)
        Me.BtnReserve.Name = "BtnReserve"
        Me.BtnReserve.Size = New System.Drawing.Size(146, 29)
        Me.BtnReserve.TabIndex = 2
        Me.BtnReserve.Text = "Réserver un vol"
        Me.BtnReserve.UseVisualStyleBackColor = True
        Me.BtnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
        Me.BtnLogout.Location = New System.Drawing.Point(504, 347)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(125, 29)
        Me.BtnLogout.TabIndex = 3
        Me.BtnLogout.Text = "Déconnexion"
        Me.BtnLogout.UseVisualStyleBackColor = True

        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0F, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(273, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 28)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Interface Utilisateur"

        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0F, 20.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.BtnReserve)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.DgvAvailableFlights)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DgvAvailableFlights, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents DgvAvailableFlights As DataGridView
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnReserve As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents Label2 As Label
End Class