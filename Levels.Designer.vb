<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Levels
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnLvl1 = New System.Windows.Forms.Button()
        Me.BtnLvl2 = New System.Windows.Forms.Button()
        Me.BtnLvl3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BtnLvl4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnLvl1
        '
        Me.BtnLvl1.FlatAppearance.BorderSize = 3
        Me.BtnLvl1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLvl1.Location = New System.Drawing.Point(293, 153)
        Me.BtnLvl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnLvl1.Name = "BtnLvl1"
        Me.BtnLvl1.Size = New System.Drawing.Size(87, 68)
        Me.BtnLvl1.TabIndex = 0
        Me.BtnLvl1.Text = "1"
        Me.BtnLvl1.UseVisualStyleBackColor = True
        '
        'BtnLvl2
        '
        Me.BtnLvl2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLvl2.Location = New System.Drawing.Point(444, 153)
        Me.BtnLvl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnLvl2.Name = "BtnLvl2"
        Me.BtnLvl2.Size = New System.Drawing.Size(87, 68)
        Me.BtnLvl2.TabIndex = 1
        Me.BtnLvl2.Text = "2"
        Me.BtnLvl2.UseVisualStyleBackColor = True
        '
        'BtnLvl3
        '
        Me.BtnLvl3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLvl3.Location = New System.Drawing.Point(575, 153)
        Me.BtnLvl3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnLvl3.Name = "BtnLvl3"
        Me.BtnLvl3.Size = New System.Drawing.Size(87, 68)
        Me.BtnLvl3.TabIndex = 2
        Me.BtnLvl3.Text = "3"
        Me.BtnLvl3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(454, 295)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(197, 68)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Goto Main Screen"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'BtnLvl4
        '
        Me.BtnLvl4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLvl4.Location = New System.Drawing.Point(717, 153)
        Me.BtnLvl4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnLvl4.Name = "BtnLvl4"
        Me.BtnLvl4.Size = New System.Drawing.Size(87, 68)
        Me.BtnLvl4.TabIndex = 4
        Me.BtnLvl4.Text = "4"
        Me.BtnLvl4.UseVisualStyleBackColor = True
        '
        'Levels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Dungeon_run.My.Resources.Resource1.wall
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.BtnLvl4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.BtnLvl3)
        Me.Controls.Add(Me.BtnLvl2)
        Me.Controls.Add(Me.BtnLvl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Levels"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnLvl1 As Button
    Friend WithEvents BtnLvl2 As Button
    Friend WithEvents BtnLvl3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents BtnLvl4 As Button
End Class
