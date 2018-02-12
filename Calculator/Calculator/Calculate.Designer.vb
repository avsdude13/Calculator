<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculator))
        Me.ClearAllButton = New System.Windows.Forms.Button()
        Me.SignButton = New System.Windows.Forms.Button()
        Me.PercentButton = New System.Windows.Forms.Button()
        Me.DivisionButton = New System.Windows.Forms.Button()
        Me.MultiplicationButton = New System.Windows.Forms.Button()
        Me.ButtonNine = New System.Windows.Forms.Button()
        Me.ButtonEight = New System.Windows.Forms.Button()
        Me.ButtonSeven = New System.Windows.Forms.Button()
        Me.SubtractionButton = New System.Windows.Forms.Button()
        Me.ButtonSix = New System.Windows.Forms.Button()
        Me.ButtonFive = New System.Windows.Forms.Button()
        Me.ButtonFour = New System.Windows.Forms.Button()
        Me.PlusButton = New System.Windows.Forms.Button()
        Me.ButtonThree = New System.Windows.Forms.Button()
        Me.ButtonTwo = New System.Windows.Forms.Button()
        Me.ButtonOne = New System.Windows.Forms.Button()
        Me.EqualButton = New System.Windows.Forms.Button()
        Me.DecimalButton = New System.Windows.Forms.Button()
        Me.ButtonZero = New System.Windows.Forms.Button()
        Me.Display = New System.Windows.Forms.RichTextBox()
        Me.SquareRootButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.InverseButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendToFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SquareButton = New System.Windows.Forms.Button()
        Me.CosButton = New System.Windows.Forms.Button()
        Me.TanButton = New System.Windows.Forms.Button()
        Me.SinButton = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClearAllButton
        '
        Me.ClearAllButton.BackColor = System.Drawing.Color.Silver
        Me.ClearAllButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearAllButton.Location = New System.Drawing.Point(12, 170)
        Me.ClearAllButton.Name = "ClearAllButton"
        Me.ClearAllButton.Size = New System.Drawing.Size(53, 42)
        Me.ClearAllButton.TabIndex = 1
        Me.ClearAllButton.Text = "&CE"
        Me.ToolTip1.SetToolTip(Me.ClearAllButton, "Clear All")
        Me.ClearAllButton.UseVisualStyleBackColor = False
        '
        'SignButton
        '
        Me.SignButton.BackColor = System.Drawing.Color.Silver
        Me.SignButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignButton.Location = New System.Drawing.Point(130, 170)
        Me.SignButton.Name = "SignButton"
        Me.SignButton.Size = New System.Drawing.Size(53, 42)
        Me.SignButton.TabIndex = 2
        Me.SignButton.Text = "+/-"
        Me.ToolTip1.SetToolTip(Me.SignButton, "Change Sign")
        Me.SignButton.UseVisualStyleBackColor = False
        '
        'PercentButton
        '
        Me.PercentButton.BackColor = System.Drawing.Color.Silver
        Me.PercentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercentButton.Location = New System.Drawing.Point(130, 218)
        Me.PercentButton.Name = "PercentButton"
        Me.PercentButton.Size = New System.Drawing.Size(53, 42)
        Me.PercentButton.TabIndex = 3
        Me.PercentButton.Text = "%"
        Me.ToolTip1.SetToolTip(Me.PercentButton, "Percent")
        Me.PercentButton.UseVisualStyleBackColor = False
        '
        'DivisionButton
        '
        Me.DivisionButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DivisionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DivisionButton.Location = New System.Drawing.Point(189, 218)
        Me.DivisionButton.Name = "DivisionButton"
        Me.DivisionButton.Size = New System.Drawing.Size(53, 42)
        Me.DivisionButton.TabIndex = 4
        Me.DivisionButton.Text = "÷"
        Me.DivisionButton.UseVisualStyleBackColor = False
        '
        'MultiplicationButton
        '
        Me.MultiplicationButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MultiplicationButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiplicationButton.Location = New System.Drawing.Point(189, 266)
        Me.MultiplicationButton.Name = "MultiplicationButton"
        Me.MultiplicationButton.Size = New System.Drawing.Size(53, 42)
        Me.MultiplicationButton.TabIndex = 8
        Me.MultiplicationButton.Text = "x"
        Me.MultiplicationButton.UseVisualStyleBackColor = False
        '
        'ButtonNine
        '
        Me.ButtonNine.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonNine.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNine.Location = New System.Drawing.Point(130, 266)
        Me.ButtonNine.Name = "ButtonNine"
        Me.ButtonNine.Size = New System.Drawing.Size(53, 42)
        Me.ButtonNine.TabIndex = 7
        Me.ButtonNine.Text = "&9"
        Me.ButtonNine.UseVisualStyleBackColor = False
        '
        'ButtonEight
        '
        Me.ButtonEight.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonEight.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEight.Location = New System.Drawing.Point(71, 266)
        Me.ButtonEight.Name = "ButtonEight"
        Me.ButtonEight.Size = New System.Drawing.Size(53, 42)
        Me.ButtonEight.TabIndex = 6
        Me.ButtonEight.Text = "&8"
        Me.ButtonEight.UseVisualStyleBackColor = False
        '
        'ButtonSeven
        '
        Me.ButtonSeven.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonSeven.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSeven.Location = New System.Drawing.Point(12, 266)
        Me.ButtonSeven.Name = "ButtonSeven"
        Me.ButtonSeven.Size = New System.Drawing.Size(53, 42)
        Me.ButtonSeven.TabIndex = 5
        Me.ButtonSeven.Text = "&7"
        Me.ButtonSeven.UseVisualStyleBackColor = False
        '
        'SubtractionButton
        '
        Me.SubtractionButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SubtractionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubtractionButton.Location = New System.Drawing.Point(189, 314)
        Me.SubtractionButton.Name = "SubtractionButton"
        Me.SubtractionButton.Size = New System.Drawing.Size(53, 42)
        Me.SubtractionButton.TabIndex = 12
        Me.SubtractionButton.Text = "-"
        Me.SubtractionButton.UseVisualStyleBackColor = False
        '
        'ButtonSix
        '
        Me.ButtonSix.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonSix.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSix.Location = New System.Drawing.Point(130, 314)
        Me.ButtonSix.Name = "ButtonSix"
        Me.ButtonSix.Size = New System.Drawing.Size(53, 42)
        Me.ButtonSix.TabIndex = 11
        Me.ButtonSix.Text = "&6"
        Me.ButtonSix.UseVisualStyleBackColor = False
        '
        'ButtonFive
        '
        Me.ButtonFive.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonFive.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFive.Location = New System.Drawing.Point(71, 314)
        Me.ButtonFive.Name = "ButtonFive"
        Me.ButtonFive.Size = New System.Drawing.Size(53, 42)
        Me.ButtonFive.TabIndex = 10
        Me.ButtonFive.Text = "&5"
        Me.ButtonFive.UseVisualStyleBackColor = False
        '
        'ButtonFour
        '
        Me.ButtonFour.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonFour.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFour.Location = New System.Drawing.Point(12, 314)
        Me.ButtonFour.Name = "ButtonFour"
        Me.ButtonFour.Size = New System.Drawing.Size(53, 42)
        Me.ButtonFour.TabIndex = 9
        Me.ButtonFour.Text = "&4"
        Me.ButtonFour.UseVisualStyleBackColor = False
        '
        'PlusButton
        '
        Me.PlusButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PlusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlusButton.Location = New System.Drawing.Point(189, 362)
        Me.PlusButton.Name = "PlusButton"
        Me.PlusButton.Size = New System.Drawing.Size(53, 42)
        Me.PlusButton.TabIndex = 16
        Me.PlusButton.Text = "+"
        Me.PlusButton.UseVisualStyleBackColor = False
        '
        'ButtonThree
        '
        Me.ButtonThree.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonThree.Location = New System.Drawing.Point(130, 362)
        Me.ButtonThree.Name = "ButtonThree"
        Me.ButtonThree.Size = New System.Drawing.Size(53, 42)
        Me.ButtonThree.TabIndex = 15
        Me.ButtonThree.Text = "&3"
        Me.ButtonThree.UseVisualStyleBackColor = False
        '
        'ButtonTwo
        '
        Me.ButtonTwo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTwo.Location = New System.Drawing.Point(71, 362)
        Me.ButtonTwo.Name = "ButtonTwo"
        Me.ButtonTwo.Size = New System.Drawing.Size(53, 42)
        Me.ButtonTwo.TabIndex = 14
        Me.ButtonTwo.Text = "&2"
        Me.ButtonTwo.UseVisualStyleBackColor = False
        '
        'ButtonOne
        '
        Me.ButtonOne.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOne.Location = New System.Drawing.Point(12, 362)
        Me.ButtonOne.Name = "ButtonOne"
        Me.ButtonOne.Size = New System.Drawing.Size(53, 42)
        Me.ButtonOne.TabIndex = 13
        Me.ButtonOne.Text = "&1"
        Me.ButtonOne.UseVisualStyleBackColor = False
        '
        'EqualButton
        '
        Me.EqualButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EqualButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EqualButton.Location = New System.Drawing.Point(189, 410)
        Me.EqualButton.Name = "EqualButton"
        Me.EqualButton.Size = New System.Drawing.Size(53, 42)
        Me.EqualButton.TabIndex = 19
        Me.EqualButton.Text = "="
        Me.EqualButton.UseVisualStyleBackColor = False
        '
        'DecimalButton
        '
        Me.DecimalButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DecimalButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecimalButton.Location = New System.Drawing.Point(130, 410)
        Me.DecimalButton.Name = "DecimalButton"
        Me.DecimalButton.Size = New System.Drawing.Size(53, 42)
        Me.DecimalButton.TabIndex = 18
        Me.DecimalButton.Text = "&."
        Me.DecimalButton.UseVisualStyleBackColor = False
        '
        'ButtonZero
        '
        Me.ButtonZero.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonZero.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonZero.Location = New System.Drawing.Point(12, 410)
        Me.ButtonZero.Name = "ButtonZero"
        Me.ButtonZero.Size = New System.Drawing.Size(112, 42)
        Me.ButtonZero.TabIndex = 17
        Me.ButtonZero.Text = "&0"
        Me.ButtonZero.UseVisualStyleBackColor = False
        '
        'Display
        '
        Me.Display.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Display.Location = New System.Drawing.Point(12, 33)
        Me.Display.Name = "Display"
        Me.Display.ReadOnly = True
        Me.Display.Size = New System.Drawing.Size(230, 83)
        Me.Display.TabIndex = 0
        Me.Display.Text = ""
        '
        'SquareRootButton
        '
        Me.SquareRootButton.BackColor = System.Drawing.Color.Silver
        Me.SquareRootButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SquareRootButton.Location = New System.Drawing.Point(71, 218)
        Me.SquareRootButton.Name = "SquareRootButton"
        Me.SquareRootButton.Size = New System.Drawing.Size(53, 42)
        Me.SquareRootButton.TabIndex = 22
        Me.SquareRootButton.Text = "√"
        Me.ToolTip1.SetToolTip(Me.SquareRootButton, "Square Root")
        Me.SquareRootButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.Silver
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(71, 170)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(53, 42)
        Me.ClearButton.TabIndex = 20
        Me.ClearButton.Text = "&C"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear")
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.Silver
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(189, 169)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(53, 42)
        Me.DeleteButton.TabIndex = 23
        Me.DeleteButton.Text = "←"
        Me.ToolTip1.SetToolTip(Me.DeleteButton, "Delete")
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'InverseButton
        '
        Me.InverseButton.BackColor = System.Drawing.Color.Silver
        Me.InverseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InverseButton.Location = New System.Drawing.Point(191, 122)
        Me.InverseButton.Name = "InverseButton"
        Me.InverseButton.Size = New System.Drawing.Size(53, 42)
        Me.InverseButton.TabIndex = 24
        Me.InverseButton.Text = "1/x"
        Me.ToolTip1.SetToolTip(Me.InverseButton, "Inverse")
        Me.InverseButton.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(256, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintResultsToolStripMenuItem, Me.SendToFileToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintResultsToolStripMenuItem
        '
        Me.PrintResultsToolStripMenuItem.Name = "PrintResultsToolStripMenuItem"
        Me.PrintResultsToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.PrintResultsToolStripMenuItem.Text = "&Print Results"
        '
        'SendToFileToolStripMenuItem
        '
        Me.SendToFileToolStripMenuItem.Name = "SendToFileToolStripMenuItem"
        Me.SendToFileToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SendToFileToolStripMenuItem.Text = "&Send to File"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(136, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'SquareButton
        '
        Me.SquareButton.BackColor = System.Drawing.Color.Silver
        Me.SquareButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SquareButton.Location = New System.Drawing.Point(12, 218)
        Me.SquareButton.Name = "SquareButton"
        Me.SquareButton.Size = New System.Drawing.Size(53, 42)
        Me.SquareButton.TabIndex = 29
        Me.SquareButton.Text = "^2"
        Me.ToolTip1.SetToolTip(Me.SquareButton, "Square")
        Me.SquareButton.UseVisualStyleBackColor = False
        '
        'CosButton
        '
        Me.CosButton.BackColor = System.Drawing.Color.Silver
        Me.CosButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CosButton.Location = New System.Drawing.Point(71, 122)
        Me.CosButton.Name = "CosButton"
        Me.CosButton.Size = New System.Drawing.Size(53, 42)
        Me.CosButton.TabIndex = 28
        Me.CosButton.Text = "&Cos"
        Me.ToolTip1.SetToolTip(Me.CosButton, "Cos in Radians")
        Me.CosButton.UseVisualStyleBackColor = False
        '
        'TanButton
        '
        Me.TanButton.BackColor = System.Drawing.Color.Silver
        Me.TanButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TanButton.Location = New System.Drawing.Point(130, 122)
        Me.TanButton.Name = "TanButton"
        Me.TanButton.Size = New System.Drawing.Size(53, 42)
        Me.TanButton.TabIndex = 27
        Me.TanButton.Text = "&Tan"
        Me.ToolTip1.SetToolTip(Me.TanButton, "Tan in Radians")
        Me.TanButton.UseVisualStyleBackColor = False
        '
        'SinButton
        '
        Me.SinButton.BackColor = System.Drawing.Color.Silver
        Me.SinButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SinButton.Location = New System.Drawing.Point(12, 122)
        Me.SinButton.Name = "SinButton"
        Me.SinButton.Size = New System.Drawing.Size(53, 42)
        Me.SinButton.TabIndex = 26
        Me.SinButton.Text = "&Sin"
        Me.ToolTip1.SetToolTip(Me.SinButton, "Sin in Radians")
        Me.SinButton.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 463)
        Me.Controls.Add(Me.SquareButton)
        Me.Controls.Add(Me.CosButton)
        Me.Controls.Add(Me.TanButton)
        Me.Controls.Add(Me.SinButton)
        Me.Controls.Add(Me.InverseButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.SquareRootButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.Display)
        Me.Controls.Add(Me.EqualButton)
        Me.Controls.Add(Me.DecimalButton)
        Me.Controls.Add(Me.ButtonZero)
        Me.Controls.Add(Me.PlusButton)
        Me.Controls.Add(Me.ButtonThree)
        Me.Controls.Add(Me.ButtonTwo)
        Me.Controls.Add(Me.ButtonOne)
        Me.Controls.Add(Me.SubtractionButton)
        Me.Controls.Add(Me.ButtonSix)
        Me.Controls.Add(Me.ButtonFive)
        Me.Controls.Add(Me.ButtonFour)
        Me.Controls.Add(Me.MultiplicationButton)
        Me.Controls.Add(Me.ButtonNine)
        Me.Controls.Add(Me.ButtonEight)
        Me.Controls.Add(Me.ButtonSeven)
        Me.Controls.Add(Me.DivisionButton)
        Me.Controls.Add(Me.PercentButton)
        Me.Controls.Add(Me.SignButton)
        Me.Controls.Add(Me.ClearAllButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClearAllButton As System.Windows.Forms.Button
    Friend WithEvents SignButton As System.Windows.Forms.Button
    Friend WithEvents PercentButton As System.Windows.Forms.Button
    Friend WithEvents DivisionButton As System.Windows.Forms.Button
    Friend WithEvents MultiplicationButton As System.Windows.Forms.Button
    Friend WithEvents ButtonNine As System.Windows.Forms.Button
    Friend WithEvents ButtonEight As System.Windows.Forms.Button
    Friend WithEvents ButtonSeven As System.Windows.Forms.Button
    Friend WithEvents SubtractionButton As System.Windows.Forms.Button
    Friend WithEvents ButtonSix As System.Windows.Forms.Button
    Friend WithEvents ButtonFive As System.Windows.Forms.Button
    Friend WithEvents ButtonFour As System.Windows.Forms.Button
    Friend WithEvents PlusButton As System.Windows.Forms.Button
    Friend WithEvents ButtonThree As System.Windows.Forms.Button
    Friend WithEvents ButtonTwo As System.Windows.Forms.Button
    Friend WithEvents ButtonOne As System.Windows.Forms.Button
    Friend WithEvents EqualButton As System.Windows.Forms.Button
    Friend WithEvents DecimalButton As System.Windows.Forms.Button
    Friend WithEvents ButtonZero As System.Windows.Forms.Button
    Friend WithEvents Display As System.Windows.Forms.RichTextBox
    Friend WithEvents SquareRootButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents InverseButton As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SquareButton As System.Windows.Forms.Button
    Friend WithEvents CosButton As System.Windows.Forms.Button
    Friend WithEvents TanButton As System.Windows.Forms.Button
    Friend WithEvents SinButton As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents SendToFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
