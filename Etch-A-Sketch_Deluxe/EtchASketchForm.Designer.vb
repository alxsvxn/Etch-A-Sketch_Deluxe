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
        CType(Me.GraphicsPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GraphicsPictureBox
        '
        Me.GraphicsPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GraphicsPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GraphicsPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.GraphicsPictureBox.Name = "GraphicsPictureBox"
        Me.GraphicsPictureBox.Size = New System.Drawing.Size(776, 364)
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
        'EtchASketchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
        Me.Name = "EtchASketchForm"
        Me.Text = "Form1"
        CType(Me.GraphicsPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
