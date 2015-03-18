<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dg = New System.Windows.Forms.DataGridView
        Me.rompath = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.originalcoverpath = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSearchRom = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.btnSearchCovers = New System.Windows.Forms.Button
        Me.renamedcoverpath = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnSearchRenamed = New System.Windows.Forms.Button
        Me.btnAnalize = New System.Windows.Forms.Button
        Me.btnExecute = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.sttbProg = New System.Windows.Forms.ToolStripProgressBar
        Me.sttbTxt = New System.Windows.Forms.ToolStripStatusLabel
        Me.rom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cover = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.match = New System.Windows.Forms.DataGridViewCheckBoxColumn
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rom, Me.cover, Me.match})
        Me.dg.Location = New System.Drawing.Point(12, 12)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(905, 447)
        Me.dg.TabIndex = 0
        '
        'rompath
        '
        Me.rompath.Location = New System.Drawing.Point(138, 468)
        Me.rompath.Name = "rompath"
        Me.rompath.Size = New System.Drawing.Size(520, 20)
        Me.rompath.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 471)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Roms Path:"
        '
        'originalcoverpath
        '
        Me.originalcoverpath.Location = New System.Drawing.Point(138, 494)
        Me.originalcoverpath.Name = "originalcoverpath"
        Me.originalcoverpath.Size = New System.Drawing.Size(520, 20)
        Me.originalcoverpath.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 497)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Original Covers Path:"
        '
        'btnSearchRom
        '
        Me.btnSearchRom.Location = New System.Drawing.Point(664, 466)
        Me.btnSearchRom.Name = "btnSearchRom"
        Me.btnSearchRom.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchRom.TabIndex = 4
        Me.btnSearchRom.Text = "Search"
        Me.btnSearchRom.UseVisualStyleBackColor = True
        '
        'btnSearchCovers
        '
        Me.btnSearchCovers.Location = New System.Drawing.Point(664, 492)
        Me.btnSearchCovers.Name = "btnSearchCovers"
        Me.btnSearchCovers.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchCovers.TabIndex = 5
        Me.btnSearchCovers.Text = "Search"
        Me.btnSearchCovers.UseVisualStyleBackColor = True
        '
        'renamedcoverpath
        '
        Me.renamedcoverpath.Location = New System.Drawing.Point(138, 520)
        Me.renamedcoverpath.Name = "renamedcoverpath"
        Me.renamedcoverpath.Size = New System.Drawing.Size(520, 20)
        Me.renamedcoverpath.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 523)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Renamed Covers Path:"
        '
        'btnSearchRenamed
        '
        Me.btnSearchRenamed.Location = New System.Drawing.Point(664, 518)
        Me.btnSearchRenamed.Name = "btnSearchRenamed"
        Me.btnSearchRenamed.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchRenamed.TabIndex = 6
        Me.btnSearchRenamed.Text = "Search"
        Me.btnSearchRenamed.UseVisualStyleBackColor = True
        '
        'btnAnalize
        '
        Me.btnAnalize.Location = New System.Drawing.Point(842, 490)
        Me.btnAnalize.Name = "btnAnalize"
        Me.btnAnalize.Size = New System.Drawing.Size(75, 23)
        Me.btnAnalize.TabIndex = 7
        Me.btnAnalize.Text = "Analize"
        Me.btnAnalize.UseVisualStyleBackColor = True
        '
        'btnExecute
        '
        Me.btnExecute.Location = New System.Drawing.Point(842, 517)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(75, 23)
        Me.btnExecute.TabIndex = 8
        Me.btnExecute.Text = "Execute"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sttbProg, Me.sttbTxt})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 548)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(923, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'sttbProg
        '
        Me.sttbProg.AutoSize = False
        Me.sttbProg.Name = "sttbProg"
        Me.sttbProg.Size = New System.Drawing.Size(250, 16)
        '
        'sttbTxt
        '
        Me.sttbTxt.AutoSize = False
        Me.sttbTxt.Name = "sttbTxt"
        Me.sttbTxt.Size = New System.Drawing.Size(655, 17)
        '
        'rom
        '
        Me.rom.DataPropertyName = "rom"
        Me.rom.HeaderText = "rom"
        Me.rom.Name = "rom"
        Me.rom.ReadOnly = True
        Me.rom.Width = 395
        '
        'cover
        '
        Me.cover.DataPropertyName = "cover"
        Me.cover.HeaderText = "cover"
        Me.cover.Name = "cover"
        Me.cover.ReadOnly = True
        Me.cover.Width = 395
        '
        'match
        '
        Me.match.DataPropertyName = "match"
        Me.match.FalseValue = "N"
        Me.match.HeaderText = "match"
        Me.match.IndeterminateValue = "N"
        Me.match.Name = "match"
        Me.match.ReadOnly = True
        Me.match.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.match.TrueValue = "S"
        Me.match.Width = 40
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 570)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.btnAnalize)
        Me.Controls.Add(Me.btnSearchRenamed)
        Me.Controls.Add(Me.btnSearchCovers)
        Me.Controls.Add(Me.btnSearchRom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.renamedcoverpath)
        Me.Controls.Add(Me.originalcoverpath)
        Me.Controls.Add(Me.rompath)
        Me.Controls.Add(Me.dg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Cover Renamer for WiiFlow By Marcelo Medeiros"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents rompath As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents originalcoverpath As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSearchRom As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnSearchCovers As System.Windows.Forms.Button
    Friend WithEvents renamedcoverpath As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSearchRenamed As System.Windows.Forms.Button
    Friend WithEvents btnAnalize As System.Windows.Forms.Button
    Friend WithEvents btnExecute As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents sttbProg As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents sttbTxt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents rom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cover As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents match As System.Windows.Forms.DataGridViewCheckBoxColumn

End Class
