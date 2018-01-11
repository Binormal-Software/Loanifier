<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoanCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoanCalculator))
        Me.LoanAmountTextBox = New System.Windows.Forms.TextBox()
        Me.YearlyInterestTextBox = New System.Windows.Forms.TextBox()
        Me.YearTextBox = New System.Windows.Forms.TextBox()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearEntriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewEntryToolButton = New System.Windows.Forms.ToolStripButton()
        Me.CalculateToolButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolButton = New System.Windows.Forms.ToolStripButton()
        Me.LoanTypeCheckBox = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoanAmountTextBox
        '
        Me.LoanAmountTextBox.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoanAmountTextBox.Location = New System.Drawing.Point(165, 90)
        Me.LoanAmountTextBox.Name = "LoanAmountTextBox"
        Me.LoanAmountTextBox.Size = New System.Drawing.Size(100, 30)
        Me.LoanAmountTextBox.TabIndex = 0
        '
        'YearlyInterestTextBox
        '
        Me.YearlyInterestTextBox.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearlyInterestTextBox.Location = New System.Drawing.Point(165, 140)
        Me.YearlyInterestTextBox.Name = "YearlyInterestTextBox"
        Me.YearlyInterestTextBox.Size = New System.Drawing.Size(100, 30)
        Me.YearlyInterestTextBox.TabIndex = 1
        '
        'YearTextBox
        '
        Me.YearTextBox.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearTextBox.Location = New System.Drawing.Point(165, 190)
        Me.YearTextBox.Name = "YearTextBox"
        Me.YearTextBox.Size = New System.Drawing.Size(100, 30)
        Me.YearTextBox.TabIndex = 2
        '
        'DisplayListBox
        '
        Me.DisplayListBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.DisplayListBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 20
        Me.DisplayListBox.Location = New System.Drawing.Point(305, 28)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(527, 475)
        Me.DisplayListBox.TabIndex = 3
        '
        'CalculateButton
        '
        Me.CalculateButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateButton.Location = New System.Drawing.Point(117, 294)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(148, 42)
        Me.CalculateButton.TabIndex = 4
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(16, 294)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(95, 42)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Loan Amount: $"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Yearly Interest:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Years:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MidnightBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(832, 28)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.ClearEntriesToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.FileToolStripMenuItem.Text = "&Function"
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue
        Me.CalculateToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CalculateToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C"
        Me.CalculateToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.CalculateToolStripMenuItem.Text = "Calculate"
        '
        'ClearEntriesToolStripMenuItem
        '
        Me.ClearEntriesToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClearEntriesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearEntriesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ClearEntriesToolStripMenuItem.Name = "ClearEntriesToolStripMenuItem"
        Me.ClearEntriesToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.ClearEntriesToolStripMenuItem.Text = "&Clear Entries"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(125, 26)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.MidnightBlue
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewEntryToolButton, Me.CalculateToolButton, Me.ToolStripSeparator1, Me.ExitToolButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(305, 47)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewEntryToolButton
        '
        Me.NewEntryToolButton.ForeColor = System.Drawing.Color.White
        Me.NewEntryToolButton.Image = CType(resources.GetObject("NewEntryToolButton.Image"), System.Drawing.Image)
        Me.NewEntryToolButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewEntryToolButton.Name = "NewEntryToolButton"
        Me.NewEntryToolButton.Size = New System.Drawing.Size(80, 44)
        Me.NewEntryToolButton.Text = "New Entry"
        Me.NewEntryToolButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.NewEntryToolButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CalculateToolButton
        '
        Me.CalculateToolButton.ForeColor = System.Drawing.Color.White
        Me.CalculateToolButton.Image = CType(resources.GetObject("CalculateToolButton.Image"), System.Drawing.Image)
        Me.CalculateToolButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CalculateToolButton.Name = "CalculateToolButton"
        Me.CalculateToolButton.Size = New System.Drawing.Size(74, 44)
        Me.CalculateToolButton.Text = "Calculate"
        Me.CalculateToolButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.CalculateToolButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 47)
        '
        'ExitToolButton
        '
        Me.ExitToolButton.ForeColor = System.Drawing.Color.White
        Me.ExitToolButton.Image = CType(resources.GetObject("ExitToolButton.Image"), System.Drawing.Image)
        Me.ExitToolButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExitToolButton.Name = "ExitToolButton"
        Me.ExitToolButton.Size = New System.Drawing.Size(37, 44)
        Me.ExitToolButton.Text = "Exit"
        Me.ExitToolButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.ExitToolButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LoanTypeCheckBox
        '
        Me.LoanTypeCheckBox.AutoSize = True
        Me.LoanTypeCheckBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoanTypeCheckBox.Location = New System.Drawing.Point(16, 243)
        Me.LoanTypeCheckBox.Name = "LoanTypeCheckBox"
        Me.LoanTypeCheckBox.Size = New System.Drawing.Size(225, 24)
        Me.LoanTypeCheckBox.TabIndex = 12
        Me.LoanTypeCheckBox.Text = "Simple Loan (not compound)"
        Me.LoanTypeCheckBox.UseVisualStyleBackColor = True
        '
        'LoanCalculator
        '
        Me.AcceptButton = Me.CalculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(832, 503)
        Me.Controls.Add(Me.LoanTypeCheckBox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.YearTextBox)
        Me.Controls.Add(Me.YearlyInterestTextBox)
        Me.Controls.Add(Me.LoanAmountTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(850, 400)
        Me.Name = "LoanCalculator"
        Me.Text = "Loanify Loan Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoanAmountTextBox As TextBox
    Friend WithEvents YearlyInterestTextBox As TextBox
    Friend WithEvents YearTextBox As TextBox
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearEntriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ExitToolButton As ToolStripButton
    Friend WithEvents NewEntryToolButton As ToolStripButton
    Friend WithEvents CalculateToolButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents LoanTypeCheckBox As CheckBox
End Class
