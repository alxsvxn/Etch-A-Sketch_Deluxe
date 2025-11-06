<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EtchASketchForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EtchASketchForm))
        Me.GraphicsPictureBox = New System.Windows.Forms.PictureBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.QYATBoardRadioButton = New System.Windows.Forms.RadioButton()
        Me.ColorButton = New System.Windows.Forms.Button()
        Me.WaveButton = New System.Windows.Forms.Button()
        Me.MouseRadioButton = New System.Windows.Forms.RadioButton()
        Me.COMPortComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CommandTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ColorBox = New System.Windows.Forms.ColorDialog()
        Me.SentTextBox = New System.Windows.Forms.TextBox()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUBSCRIPTIONToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELUXEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ULTRADELUXEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ULTRADELUXEPROToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.GraphicsPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GraphicsPictureBox
        '
        Me.GraphicsPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GraphicsPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GraphicsPictureBox.Location = New System.Drawing.Point(12, 27)
        Me.GraphicsPictureBox.Name = "GraphicsPictureBox"
        Me.GraphicsPictureBox.Size = New System.Drawing.Size(776, 349)
        Me.GraphicsPictureBox.TabIndex = 0
        Me.GraphicsPictureBox.TabStop = False
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearButton.Location = New System.Drawing.Point(518, 382)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(86, 56)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'QYATBoardRadioButton
        '
        Me.QYATBoardRadioButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QYATBoardRadioButton.AutoSize = True
        Me.QYATBoardRadioButton.Location = New System.Drawing.Point(454, 414)
        Me.QYATBoardRadioButton.Name = "QYATBoardRadioButton"
        Me.QYATBoardRadioButton.Size = New System.Drawing.Size(58, 17)
        Me.QYATBoardRadioButton.TabIndex = 2
        Me.QYATBoardRadioButton.TabStop = True
        Me.QYATBoardRadioButton.Text = "Analog"
        Me.QYATBoardRadioButton.UseVisualStyleBackColor = True
        '
        'ColorButton
        '
        Me.ColorButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ColorButton.Location = New System.Drawing.Point(610, 382)
        Me.ColorButton.Name = "ColorButton"
        Me.ColorButton.Size = New System.Drawing.Size(86, 56)
        Me.ColorButton.TabIndex = 3
        Me.ColorButton.Text = "Color"
        Me.ColorButton.UseVisualStyleBackColor = True
        '
        'WaveButton
        '
        Me.WaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WaveButton.Location = New System.Drawing.Point(702, 382)
        Me.WaveButton.Name = "WaveButton"
        Me.WaveButton.Size = New System.Drawing.Size(86, 56)
        Me.WaveButton.TabIndex = 4
        Me.WaveButton.Text = "Waves"
        Me.WaveButton.UseVisualStyleBackColor = True
        '
        'MouseRadioButton
        '
        Me.MouseRadioButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MouseRadioButton.AutoSize = True
        Me.MouseRadioButton.Location = New System.Drawing.Point(454, 391)
        Me.MouseRadioButton.Name = "MouseRadioButton"
        Me.MouseRadioButton.Size = New System.Drawing.Size(57, 17)
        Me.MouseRadioButton.TabIndex = 5
        Me.MouseRadioButton.TabStop = True
        Me.MouseRadioButton.Text = "Mouse"
        Me.MouseRadioButton.UseVisualStyleBackColor = True
        '
        'COMPortComboBox
        '
        Me.COMPortComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.COMPortComboBox.FormattingEnabled = True
        Me.COMPortComboBox.Location = New System.Drawing.Point(12, 391)
        Me.COMPortComboBox.Name = "COMPortComboBox"
        Me.COMPortComboBox.Size = New System.Drawing.Size(121, 21)
        Me.COMPortComboBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 416)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "COM PORT SELECT"
        '
        'ReadTimer
        '
        '
        'CommandTimer
        '
        '
        'SentTextBox
        '
        Me.SentTextBox.Location = New System.Drawing.Point(221, 395)
        Me.SentTextBox.Name = "SentTextBox"
        Me.SentTextBox.Size = New System.Drawing.Size(36, 20)
        Me.SentTextBox.TabIndex = 8
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(139, 389)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(76, 49)
        Me.ConnectButton.TabIndex = 9
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 418)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "SENT"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem1, Me.ABOUTToolStripMenuItem1, Me.SUBSCRIPTIONToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem1
        '
        Me.FILEToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SAVEToolStripMenuItem, Me.EXITToolStripMenuItem1})
        Me.FILEToolStripMenuItem1.Name = "FILEToolStripMenuItem1"
        Me.FILEToolStripMenuItem1.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem1.Text = "FILE"
        '
        'SAVEToolStripMenuItem
        '
        Me.SAVEToolStripMenuItem.Name = "SAVEToolStripMenuItem"
        Me.SAVEToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SAVEToolStripMenuItem.Text = "SAVE"
        Me.SAVEToolStripMenuItem.ToolTipText = "ONLY AVALIABLE WITH SUBSCRIPTION"
        '
        'EXITToolStripMenuItem1
        '
        Me.EXITToolStripMenuItem1.Name = "EXITToolStripMenuItem1"
        Me.EXITToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.EXITToolStripMenuItem1.Text = "EXIT"
        '
        'ABOUTToolStripMenuItem1
        '
        Me.ABOUTToolStripMenuItem1.Name = "ABOUTToolStripMenuItem1"
        Me.ABOUTToolStripMenuItem1.Size = New System.Drawing.Size(58, 20)
        Me.ABOUTToolStripMenuItem1.Text = "ABOUT"
        '
        'SUBSCRIPTIONToolStripMenuItem1
        '
        Me.SUBSCRIPTIONToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DELUXEToolStripMenuItem, Me.ULTRADELUXEToolStripMenuItem, Me.ULTRADELUXEPROToolStripMenuItem})
        Me.SUBSCRIPTIONToolStripMenuItem1.Name = "SUBSCRIPTIONToolStripMenuItem1"
        Me.SUBSCRIPTIONToolStripMenuItem1.Size = New System.Drawing.Size(99, 20)
        Me.SUBSCRIPTIONToolStripMenuItem1.Text = "SUBSCRIPTION"
        '
        'DELUXEToolStripMenuItem
        '
        Me.DELUXEToolStripMenuItem.Name = "DELUXEToolStripMenuItem"
        Me.DELUXEToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DELUXEToolStripMenuItem.Text = "DELUXE+"
        Me.DELUXEToolStripMenuItem.ToolTipText = "$39.99 YEARLY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-ADDS 10 NEW COLORS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-EXLUSIVE ACCESS TO OFFERS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-DELUXE+ USER BAD" &
    "GE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-500 ETCH-A-SKETCH COINS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-ALLOWS BORDER CUSTOMIZATION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-1 ETCH-A-SKETCH LOO" &
    "TBOX KEY"
        '
        'ULTRADELUXEToolStripMenuItem
        '
        Me.ULTRADELUXEToolStripMenuItem.Name = "ULTRADELUXEToolStripMenuItem"
        Me.ULTRADELUXEToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ULTRADELUXEToolStripMenuItem.Text = "ULTRA DELUXE"
        Me.ULTRADELUXEToolStripMenuItem.ToolTipText = resources.GetString("ULTRADELUXEToolStripMenuItem.ToolTipText")
        '
        'ULTRADELUXEPROToolStripMenuItem
        '
        Me.ULTRADELUXEPROToolStripMenuItem.Name = "ULTRADELUXEPROToolStripMenuItem"
        Me.ULTRADELUXEPROToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ULTRADELUXEPROToolStripMenuItem.Text = "ULTRA DELUXE PRO"
        Me.ULTRADELUXEPROToolStripMenuItem.ToolTipText = resources.GetString("ULTRADELUXEPROToolStripMenuItem.ToolTipText")
        Me.ULTRADELUXEPROToolStripMenuItem.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(612, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(648, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "ULTRA DELUXE PRO User"
        '
        'EtchASketchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ConnectButton)
        Me.Controls.Add(Me.SentTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.COMPortComboBox)
        Me.Controls.Add(Me.MouseRadioButton)
        Me.Controls.Add(Me.WaveButton)
        Me.Controls.Add(Me.ColorButton)
        Me.Controls.Add(Me.QYATBoardRadioButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.GraphicsPictureBox)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EtchASketchForm"
        Me.Text = "Form1"
        CType(Me.GraphicsPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GraphicsPictureBox As PictureBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents QYATBoardRadioButton As RadioButton
    Friend WithEvents ColorButton As Button
    Friend WithEvents WaveButton As Button
    Friend WithEvents MouseRadioButton As RadioButton
    Friend WithEvents COMPortComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ReadTimer As Timer
    Friend WithEvents CommandTimer As Timer
    Friend WithEvents ColorBox As ColorDialog
    Friend WithEvents SentTextBox As TextBox
    Friend WithEvents ConnectButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FILEToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SAVEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SUBSCRIPTIONToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DELUXEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ULTRADELUXEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ULTRADELUXEPROToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
