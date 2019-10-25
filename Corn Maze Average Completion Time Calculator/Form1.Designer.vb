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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picCornMaze = New System.Windows.Forms.PictureBox()
        Me.btnTimes = New System.Windows.Forms.Button()
        Me.lblAvgCompletionTime = New System.Windows.Forms.Label()
        Me.lstTimes = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picCornMaze, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(82, 31)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(250, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Race through the Corn Maze"
        '
        'picCornMaze
        '
        Me.picCornMaze.Image = Global.Corn_Maze_Average_Completion_Time_Calculator.My.Resources.Resources.Maze
        Me.picCornMaze.Location = New System.Drawing.Point(84, 65)
        Me.picCornMaze.Name = "picCornMaze"
        Me.picCornMaze.Size = New System.Drawing.Size(246, 202)
        Me.picCornMaze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCornMaze.TabIndex = 1
        Me.picCornMaze.TabStop = False
        '
        'btnTimes
        '
        Me.btnTimes.BackColor = System.Drawing.Color.DarkOrange
        Me.btnTimes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimes.Location = New System.Drawing.Point(53, 274)
        Me.btnTimes.Name = "btnTimes"
        Me.btnTimes.Size = New System.Drawing.Size(308, 35)
        Me.btnTimes.TabIndex = 3
        Me.btnTimes.Text = "Enter in completion times"
        Me.btnTimes.UseVisualStyleBackColor = False
        '
        'lblAvgCompletionTime
        '
        Me.lblAvgCompletionTime.BackColor = System.Drawing.Color.DarkOrange
        Me.lblAvgCompletionTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgCompletionTime.Location = New System.Drawing.Point(12, 436)
        Me.lblAvgCompletionTime.Name = "lblAvgCompletionTime"
        Me.lblAvgCompletionTime.Size = New System.Drawing.Size(390, 44)
        Me.lblAvgCompletionTime.TabIndex = 4
        Me.lblAvgCompletionTime.Text = "Average completion time for the the team is"
        '
        'lstTimes
        '
        Me.lstTimes.FormattingEnabled = True
        Me.lstTimes.ItemHeight = 16
        Me.lstTimes.Location = New System.Drawing.Point(86, 325)
        Me.lstTimes.Name = "lstTimes"
        Me.lstTimes.Size = New System.Drawing.Size(242, 84)
        Me.lstTimes.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(414, 28)
        Me.MenuStrip1.TabIndex = 6
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
        Me.ClientSize = New System.Drawing.Size(414, 489)
        Me.Controls.Add(Me.lstTimes)
        Me.Controls.Add(Me.lblAvgCompletionTime)
        Me.Controls.Add(Me.btnTimes)
        Me.Controls.Add(Me.picCornMaze)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCornMaze"
        Me.Text = "Corn Maze Average Time"
        CType(Me.picCornMaze, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents picCornMaze As PictureBox
    Friend WithEvents btnTimes As Button
    Friend WithEvents lblAvgCompletionTime As Label
    Friend WithEvents lstTimes As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
