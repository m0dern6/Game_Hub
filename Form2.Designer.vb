<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnCostumes = New System.Windows.Forms.Button()
        Me.BtnLevel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(425, 395)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(217, 75)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BtnCostumes
        '
        Me.BtnCostumes.Location = New System.Drawing.Point(425, 284)
        Me.BtnCostumes.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCostumes.Name = "BtnCostumes"
        Me.BtnCostumes.Size = New System.Drawing.Size(217, 75)
        Me.BtnCostumes.TabIndex = 5
        Me.BtnCostumes.Text = "Costumes"
        Me.BtnCostumes.UseVisualStyleBackColor = True
        '
        'BtnLevel
        '
        Me.BtnLevel.Location = New System.Drawing.Point(425, 176)
        Me.BtnLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLevel.Name = "BtnLevel"
        Me.BtnLevel.Size = New System.Drawing.Size(217, 75)
        Me.BtnLevel.TabIndex = 4
        Me.BtnLevel.Text = "Levels"
        Me.BtnLevel.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Dungeon_run.My.Resources.Resource1.The_Dungeon_Run_Logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BtnCostumes)
        Me.Controls.Add(Me.BtnLevel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnCostumes As Button
    Friend WithEvents BtnLevel As Button
End Class
