<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataconnectDataSet = New Dungeon_run.DataconnectDataSet()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBoxSearch = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table1TableAdapter = New Dungeon_run.DataconnectDataSetTableAdapters.Table1TableAdapter()
        Me.PicExit = New System.Windows.Forms.PictureBox()
        Me.PicDelete = New System.Windows.Forms.PictureBox()
        Me.PicSave = New System.Windows.Forms.PictureBox()
        Me.PicAdd = New System.Windows.Forms.PictureBox()
        Me.PicNext = New System.Windows.Forms.PictureBox()
        Me.PicPrevious = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataconnectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPrevious, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 360)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Contact No", True))
        Me.TextBox5.Location = New System.Drawing.Point(153, 282)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(137, 22)
        Me.TextBox5.TabIndex = 9
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.DataconnectDataSet
        '
        'DataconnectDataSet
        '
        Me.DataconnectDataSet.DataSetName = "DataconnectDataSet"
        Me.DataconnectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Address", True))
        Me.TextBox4.Location = New System.Drawing.Point(153, 226)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(137, 22)
        Me.TextBox4.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Password", True))
        Me.TextBox3.Location = New System.Drawing.Point(153, 164)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox3.Size = New System.Drawing.Size(137, 22)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Username", True))
        Me.TextBox2.Location = New System.Drawing.Point(153, 114)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(137, 22)
        Me.TextBox2.TabIndex = 6
        '
        'TextID
        '
        Me.TextID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "ID", True))
        Me.TextID.Location = New System.Drawing.Point(153, 54)
        Me.TextID.Name = "TextID"
        Me.TextID.Size = New System.Drawing.Size(137, 22)
        Me.TextID.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contact No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'PictureBoxSearch
        '
        Me.PictureBoxSearch.Image = Global.Dungeon_run.My.Resources.Resource1.Search
        Me.PictureBoxSearch.Location = New System.Drawing.Point(858, 16)
        Me.PictureBoxSearch.Name = "PictureBoxSearch"
        Me.PictureBoxSearch.Size = New System.Drawing.Size(62, 41)
        Me.PictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSearch.TabIndex = 10
        Me.PictureBoxSearch.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(512, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(657, 349)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Preview"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactNoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Table1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(17, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(634, 319)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.Width = 125
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.Width = 125
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.Width = 125
        '
        'ContactNoDataGridViewTextBoxColumn
        '
        Me.ContactNoDataGridViewTextBoxColumn.DataPropertyName = "Contact No"
        Me.ContactNoDataGridViewTextBoxColumn.HeaderText = "Contact No"
        Me.ContactNoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ContactNoDataGridViewTextBoxColumn.Name = "ContactNoDataGridViewTextBoxColumn"
        Me.ContactNoDataGridViewTextBoxColumn.Width = 125
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'PicExit
        '
        Me.PicExit.Image = Global.Dungeon_run.My.Resources.Resource1._Exit
        Me.PicExit.Location = New System.Drawing.Point(432, 431)
        Me.PicExit.Name = "PicExit"
        Me.PicExit.Size = New System.Drawing.Size(52, 46)
        Me.PicExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicExit.TabIndex = 7
        Me.PicExit.TabStop = False
        '
        'PicDelete
        '
        Me.PicDelete.Image = Global.Dungeon_run.My.Resources.Resource1.Delete
        Me.PicDelete.Location = New System.Drawing.Point(358, 431)
        Me.PicDelete.Name = "PicDelete"
        Me.PicDelete.Size = New System.Drawing.Size(52, 46)
        Me.PicDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicDelete.TabIndex = 6
        Me.PicDelete.TabStop = False
        '
        'PicSave
        '
        Me.PicSave.Image = Global.Dungeon_run.My.Resources.Resource1.Save
        Me.PicSave.Location = New System.Drawing.Point(270, 431)
        Me.PicSave.Name = "PicSave"
        Me.PicSave.Size = New System.Drawing.Size(52, 46)
        Me.PicSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSave.TabIndex = 5
        Me.PicSave.TabStop = False
        '
        'PicAdd
        '
        Me.PicAdd.Image = Global.Dungeon_run.My.Resources.Resource1.Add
        Me.PicAdd.Location = New System.Drawing.Point(188, 431)
        Me.PicAdd.Name = "PicAdd"
        Me.PicAdd.Size = New System.Drawing.Size(52, 46)
        Me.PicAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicAdd.TabIndex = 4
        Me.PicAdd.TabStop = False
        '
        'PicNext
        '
        Me.PicNext.Image = Global.Dungeon_run.My.Resources.Resource1._Next
        Me.PicNext.Location = New System.Drawing.Point(103, 431)
        Me.PicNext.Name = "PicNext"
        Me.PicNext.Size = New System.Drawing.Size(52, 46)
        Me.PicNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicNext.TabIndex = 3
        Me.PicNext.TabStop = False
        '
        'PicPrevious
        '
        Me.PicPrevious.Image = Global.Dungeon_run.My.Resources.Resource1.Previous
        Me.PicPrevious.Location = New System.Drawing.Point(20, 431)
        Me.PicPrevious.Name = "PicPrevious"
        Me.PicPrevious.Size = New System.Drawing.Size(52, 46)
        Me.PicPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicPrevious.TabIndex = 2
        Me.PicPrevious.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(691, 26)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(161, 22)
        Me.txtSearch.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(547, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Search By Username:"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 514)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.PictureBoxSearch)
        Me.Controls.Add(Me.PicExit)
        Me.Controls.Add(Me.PicDelete)
        Me.Controls.Add(Me.PicSave)
        Me.Controls.Add(Me.PicAdd)
        Me.Controls.Add(Me.PicNext)
        Me.Controls.Add(Me.PicPrevious)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataconnectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPrevious, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataconnectDataSet As DataconnectDataSet
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As DataconnectDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PicPrevious As PictureBox
    Friend WithEvents PicNext As PictureBox
    Friend WithEvents PicAdd As PictureBox
    Friend WithEvents PicSave As PictureBox
    Friend WithEvents PicDelete As PictureBox
    Friend WithEvents PicExit As PictureBox
    Friend WithEvents PictureBoxSearch As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label6 As Label
End Class
