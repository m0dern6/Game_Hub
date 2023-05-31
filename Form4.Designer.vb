<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEnemey = New System.Windows.Forms.Timer(Me.components)
        Me.tmrShoot = New System.Windows.Forms.Timer(Me.components)
        Me.ScoreTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.BtnRestart = New System.Windows.Forms.Button()
        Me.Plane = New System.Windows.Forms.PictureBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        CType(Me.Plane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrRight
        '
        '
        'tmrLeft
        '
        '
        'tmrEnemey
        '
        '
        'tmrShoot
        '
        Me.tmrShoot.Interval = 1
        '
        'ScoreTimer
        '
        Me.ScoreTimer.Interval = 1000
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ScoreLabel.Location = New System.Drawing.Point(15, 11)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(70, 25)
        Me.ScoreLabel.TabIndex = 4
        Me.ScoreLabel.Text = "Score:"
        '
        'BtnRestart
        '
        Me.BtnRestart.ForeColor = System.Drawing.Color.Black
        Me.BtnRestart.Location = New System.Drawing.Point(202, 310)
        Me.BtnRestart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRestart.Name = "BtnRestart"
        Me.BtnRestart.Size = New System.Drawing.Size(177, 81)
        Me.BtnRestart.TabIndex = 5
        Me.BtnRestart.Text = "Restart"
        Me.BtnRestart.UseVisualStyleBackColor = True
        Me.BtnRestart.Visible = False
        '
        'Plane
        '
        Me.Plane.Image = Global.Dungeon_run.My.Resources.Resource1.player
        Me.Plane.Location = New System.Drawing.Point(263, 530)
        Me.Plane.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Plane.Name = "Plane"
        Me.Plane.Size = New System.Drawing.Size(71, 57)
        Me.Plane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Plane.TabIndex = 3
        Me.Plane.TabStop = False
        '
        'BtnExit
        '
        Me.BtnExit.ForeColor = System.Drawing.Color.Black
        Me.BtnExit.Location = New System.Drawing.Point(202, 406)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(177, 81)
        Me.BtnExit.TabIndex = 6
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        Me.BtnExit.Visible = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(552, 618)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.BtnRestart)
        Me.Controls.Add(Me.Plane)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(570, 665)
        Me.MinimumSize = New System.Drawing.Size(570, 665)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.Plane, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrEnemey As Timer
    Friend WithEvents tmrShoot As Timer
    Friend WithEvents ScoreTimer As Timer
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents BtnRestart As Button
    Friend WithEvents Plane As PictureBox
    Friend WithEvents BtnExit As Button
End Class
