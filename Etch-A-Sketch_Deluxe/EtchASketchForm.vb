Imports System.IO.Ports
Public Class EtchASketchForm
    Private Sub EtchaASketchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaults()
    End Sub
    '==========================================Set Default Settings==========================================
    Sub SetDefaults()
        Try
            For Each port In SerialPort.GetPortNames()
                COMPortComboBox.Items.Add(port)
            Next
            COMPortComboBox.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("No COM Ports found, connect the Q@ Board to continue") 'NO COM PORTS FOUND MESSAGE
        End Try

        MouseRadioButton.Checked = True
        QYATBoardRadioButton.Enabled = False
        ReadTimer.Enabled = False
        CommandTimer.Enabled = False
    End Sub
    '==========================================Serial Connection========================================
    Sub Connect()
        Try
            Dim comPort As String = COMPortComboBox.Text
            SerialPort.Close()
            SerialPort.BaudRate = 9600                                 'Q@ Board DEFAULTS
            SerialPort.Parity = IO.Ports.Parity.None                   'NO PARITY BITS
            SerialPort.StopBits = IO.Ports.StopBits.One
            SerialPort.DataBits = 8
            SerialPort.PortName = comPort                              'CHANGES TO USER COMPORT

            SerialPort.Open()
            If SerialPort.IsOpen Then                                  'CHECKS TO SEE IF CONNECTED
                MessageBox.Show("Connected to " & SerialPort.PortName) 'DISPLAYS CONNECTED PORT MESSAGE
                QYATBoardRadioButton.Enabled = True
            End If

        Catch ex As Exception
            'Show error message if port is invalid
            MessageBox.Show("Error: " & ex.Message)
            Return
        End Try
    End Sub
    '==========================================RANDOM NUMBERS==========================================
    Function GetRandomNumberAround(thisNumber%, Optional within% = 10) As Integer
        Dim result%
        result = thisNumber - within
        result += GetRandomNumber(within) + GetRandomNumber(within)
        Return result
    End Function
    Function GetRandomNumber(max%) As Integer
        Randomize()
        Return CInt(System.Math.Floor((Rnd() * (max + 1))))
    End Function
    '==========================================BUTTONS==========================================
    Private Sub WaveButton_Click(sender As Object, e As EventArgs) Handles WaveButton.Click
        Graticules()
    End Sub
    '==========================================COLORS==========================================
    Function SetColor(Optional newColor As Color = Nothing) As Color    'SETS OR GETS FORECOLOR
        Static _forecolor As Color = Color.PaleTurquoise
        If newColor <> Nothing Then
            _forecolor = newColor
        End If
        Return _forecolor
    End Function
    Function DialogBox() As Color
        ColorBox.ShowDialog()
        SetColor(ColorBox.Color)
        Return SetColor()
    End Function
    '==========================================GRAPHICS==========================================

    Sub Graticules()
        Dim graphics As Graphics = GraphicsPictureBox.CreateGraphics
        Dim pen As New Pen(Color.LightSlateGray)
        Dim y As Integer = 0
        Dim x As Integer = 0

        Do Until y > GraphicsPictureBox.Height

            y += (GraphicsPictureBox.Height \ 10)
            graphics.DrawLine(pen, 0, y, GraphicsPictureBox.Width, y)

        Loop

        Do Until x > GraphicsPictureBox.Width

            x += (GraphicsPictureBox.Width \ 10)
            graphics.DrawLine(pen, x, 0, x, GraphicsPictureBox.Height)

        Loop
    End Sub

End Class
