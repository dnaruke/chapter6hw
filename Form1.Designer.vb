<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCornMaze
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
        Me.picMaze = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lstTimes = New System.Windows.Forms.ListBox()
        Me.btnTimes = New System.Windows.Forms.Button()
        Me.lblAvgCompletionTime = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picMaze, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picMaze
        '
        Me.picMaze.Image = Global.chapter6hw.My.Resources.Resources.Maze
        Me.picMaze.Location = New System.Drawing.Point(79, 66)
        Me.picMaze.Name = "picMaze"
        Me.picMaze.Size = New System.Drawing.Size(252, 212)
        Me.picMaze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMaze.TabIndex = 0
        Me.picMaze.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(95, 28)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(221, 22)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Race through the Corn Maze"
        '
        'lstTimes
        '
        Me.lstTimes.FormattingEnabled = True
        Me.lstTimes.ItemHeight = 16
        Me.lstTimes.Location = New System.Drawing.Point(79, 318)
        Me.lstTimes.Name = "lstTimes"
        Me.lstTimes.Size = New System.Drawing.Size(252, 116)
        Me.lstTimes.TabIndex = 2
        '
        'btnTimes
        '
        Me.btnTimes.BackColor = System.Drawing.Color.Orange
        Me.btnTimes.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimes.Location = New System.Drawing.Point(79, 284)
        Me.btnTimes.Name = "btnTimes"
        Me.btnTimes.Size = New System.Drawing.Size(239, 28)
        Me.btnTimes.TabIndex = 3
        Me.btnTimes.Text = "Enter in completion times"
        Me.btnTimes.UseVisualStyleBackColor = False
        '
        'lblAvgCompletionTime
        '
        Me.lblAvgCompletionTime.BackColor = System.Drawing.Color.Orange
        Me.lblAvgCompletionTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgCompletionTime.Location = New System.Drawing.Point(12, 452)
        Me.lblAvgCompletionTime.Name = "lblAvgCompletionTime"
        Me.lblAvgCompletionTime.Size = New System.Drawing.Size(387, 28)
        Me.lblAvgCompletionTime.TabIndex = 4
        Me.lblAvgCompletionTime.Text = "Average completion time for the team is"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(411, 28)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmCornMaze
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 506)
        Me.Controls.Add(Me.lblAvgCompletionTime)
        Me.Controls.Add(Me.btnTimes)
        Me.Controls.Add(Me.lstTimes)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picMaze)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCornMaze"
        Me.Text = "Corn Maze Average Time"
        CType(Me.picMaze, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picMaze As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lstTimes As ListBox
    Friend WithEvents btnTimes As Button
    Friend WithEvents lblAvgCompletionTime As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
