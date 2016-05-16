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
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.txtKeyBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKeyBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKeyBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKeyBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKeyBox5 = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblNoTries = New System.Windows.Forms.Label()
        Me.lblNoOfTriesOutput = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVerify
        '
        Me.btnVerify.Location = New System.Drawing.Point(132, 92)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(75, 23)
        Me.btnVerify.TabIndex = 1
        Me.btnVerify.Text = "&Verify"
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'txtKeyBox1
        '
        Me.txtKeyBox1.Location = New System.Drawing.Point(12, 39)
        Me.txtKeyBox1.Name = "txtKeyBox1"
        Me.txtKeyBox1.Size = New System.Drawing.Size(56, 20)
        Me.txtKeyBox1.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(425, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "---"
        '
        'txtKeyBox2
        '
        Me.txtKeyBox2.Location = New System.Drawing.Point(97, 38)
        Me.txtKeyBox2.Name = "txtKeyBox2"
        Me.txtKeyBox2.Size = New System.Drawing.Size(56, 20)
        Me.txtKeyBox2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "---"
        '
        'txtKeyBox3
        '
        Me.txtKeyBox3.Location = New System.Drawing.Point(183, 38)
        Me.txtKeyBox3.Name = "txtKeyBox3"
        Me.txtKeyBox3.Size = New System.Drawing.Size(56, 20)
        Me.txtKeyBox3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(245, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "---"
        '
        'txtKeyBox4
        '
        Me.txtKeyBox4.Location = New System.Drawing.Point(268, 39)
        Me.txtKeyBox4.Name = "txtKeyBox4"
        Me.txtKeyBox4.Size = New System.Drawing.Size(56, 20)
        Me.txtKeyBox4.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(331, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "---"
        '
        'txtKeyBox5
        '
        Me.txtKeyBox5.Location = New System.Drawing.Point(353, 39)
        Me.txtKeyBox5.Name = "txtKeyBox5"
        Me.txtKeyBox5.Size = New System.Drawing.Size(56, 20)
        Me.txtKeyBox5.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(248, 91)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblNoTries
        '
        Me.lblNoTries.AutoSize = True
        Me.lblNoTries.Location = New System.Drawing.Point(12, 128)
        Me.lblNoTries.Name = "lblNoTries"
        Me.lblNoTries.Size = New System.Drawing.Size(150, 13)
        Me.lblNoTries.TabIndex = 12
        Me.lblNoTries.Text = "Number of validation attempts:"
        '
        'lblNoOfTriesOutput
        '
        Me.lblNoOfTriesOutput.AutoSize = True
        Me.lblNoOfTriesOutput.Location = New System.Drawing.Point(163, 128)
        Me.lblNoOfTriesOutput.Name = "lblNoOfTriesOutput"
        Me.lblNoOfTriesOutput.Size = New System.Drawing.Size(16, 13)
        Me.lblNoOfTriesOutput.TabIndex = 13
        Me.lblNoOfTriesOutput.Text = "..."
        '
        'Form1
        '
        Me.AcceptButton = Me.btnVerify
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 147)
        Me.Controls.Add(Me.lblNoOfTriesOutput)
        Me.Controls.Add(Me.lblNoTries)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtKeyBox5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtKeyBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtKeyBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKeyBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtKeyBox1)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVerify As System.Windows.Forms.Button
    Friend WithEvents txtKeyBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKeyBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKeyBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKeyBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtKeyBox5 As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblNoTries As System.Windows.Forms.Label
    Friend WithEvents lblNoOfTriesOutput As System.Windows.Forms.Label

End Class
