Imports System.IO.Ports
Public Class EtchASketchForm
    Private Sub EtchaASketchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaults()
        GraphicsPictureBox.BackColor = Color.Black
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
        Sine()
        Cosine()
        Tangent()
    End Sub

    Private Sub ColorButton_Click(sender As Object, e As EventArgs) Handles ColorButton.Click
        DialogBox()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        GraphicsPictureBox.Refresh()
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
    '==========================================MATHEMATICAL GRAPHICS==========================================

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
    Sub Sine()
        Dim graphics As Graphics = GraphicsPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Red)
        Dim ymax As Integer = GraphicsPictureBox.Height \ 2
        Dim oldX, newy As Integer
        Dim oldY As Integer = GraphicsPictureBox.Height \ 2
        Dim degPerGraticule As Double = 360 / GraphicsPictureBox.Width

        For x = 0 To GraphicsPictureBox.Width
            newy = CInt(ymax * Math.Sin((Math.PI / 180) * (x * degPerGraticule))) + GraphicsPictureBox.Height \ 2
            graphics.DrawLine(pen, oldX, oldY, x, newy)
            oldX = x
            oldY = newy
        Next
    End Sub
    Sub Cosine()
        Dim graphics As Graphics = GraphicsPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Blue)
        Dim yMax As Integer = GraphicsPictureBox.Height \ 2
        Dim oldX, newy As Integer
        Dim oldY As Integer = GraphicsPictureBox.Height 'remove the divide 2 here so cosine starts at the right point 
        Dim degPerGraticule As Double = 360 / GraphicsPictureBox.Width

        For x = 0 To GraphicsPictureBox.Width
            newy = CInt(yMax * Math.Cos((Math.PI / 180) * (x * degPerGraticule))) + GraphicsPictureBox.Height \ 2
            graphics.DrawLine(pen, oldX, oldY, x, newy)
            oldX = x
            oldY = newy
        Next
    End Sub
    Sub Tangent()
        Dim graphics As Graphics = GraphicsPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Green)
        Dim ymaX As Integer = GraphicsPictureBox.Height \ 2
        Dim oldX, newy As Integer
        Dim oldY As Integer = GraphicsPictureBox.Height \ 2
        Dim degPerGraticule As Double = 360 / GraphicsPictureBox.Width

        Try
            For x = 0 To GraphicsPictureBox.Width

                newy = CInt(ymaX * Math.Tan((Math.PI / 180) * (x * degPerGraticule))) + GraphicsPictureBox.Height \ 2
                graphics.DrawLine(pen, oldX, oldY, x, newy)
                oldX = x
                oldY = newy
            Next
        Catch ex As Exception

        End Try
    End Sub
    '==========================================MOUSE GRAPHICS==========================================

    Private mouseIsDrawing As Boolean = False
    Private lastPt As Point
    Private Sub GraphicsPictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles GraphicsPictureBox.MouseDown
        If MouseRadioButton.Checked AndAlso e.Button = MouseButtons.Left Then
            mouseIsDrawing = True
            lastPt = e.Location
            Using g As Graphics = GraphicsPictureBox.CreateGraphics(), p As New Pen(SetColor(), 2)
                g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                g.DrawLine(p, lastPt, lastPt)
            End Using
        ElseIf e.Button = MouseButtons.Middle Then
            DialogBox()
        End If
    End Sub

    Private Sub GraphicsPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles GraphicsPictureBox.MouseMove
        If mouseIsDrawing AndAlso MouseRadioButton.Checked AndAlso (Control.MouseButtons And MouseButtons.Left) = MouseButtons.Left Then
            Using g As Graphics = GraphicsPictureBox.CreateGraphics(), p As New Pen(SetColor(), 2)
                g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                g.DrawLine(p, lastPt, e.Location)
            End Using
            lastPt = e.Location
        End If
    End Sub

    Private Sub GraphicsPictureBox_MouseUp(sender As Object, e As MouseEventArgs) Handles GraphicsPictureBox.MouseUp
        If e.Button = MouseButtons.Left Then
            mouseIsDrawing = False
        End If
    End Sub

    Private Sub QYATBoardRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles QYATBoardRadioButton.CheckedChanged
        If QYATBoardRadioButton.Checked Then
            mouseIsDrawing = False

        End If
    End Sub

End Class
