'Alexis Villagran
'Etch-A-Sketch Deluxe
'RCET 3371
'https://github.com/alxsvxn/Etch-A-Sketch_Deluxe

Option Strict On
Option Explicit On
Option Compare Text

Imports System.IO.Ports
Imports System.Linq.Expressions
Public Class EtchASketchForm
    Private Sub EtchaASketchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaults()
        GraphicsPictureBox.BackColor = Color.Black
    End Sub
    '==========================================Set Default Settings==========================================
    Sub SetDefaults()
        Try
            For Each port In SerialPort.GetPortNames()
                COMPortComboBox.Items.Add(port)                         'ADDS AVAILABLE COM PORTS TO COM PORT DROPDOWN
            Next
            COMPortComboBox.SelectedIndex = 0                           'SETS FIRST COM PORT AS DEFAULT
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
            MessageBox.Show("Error: " & ex.Message)                     'DISPLAYS ERROR MESSAGE
            Return
        End Try

        If QYATBoardRadioButton.Checked Then
            QYATBoardRadioButton_CheckedChanged(Nothing, EventArgs.Empty)
        End If

    End Sub
    '==========================================BUTTONS==========================================
    Private Sub WaveButton_Click(sender As Object, e As EventArgs) Handles WaveButton.Click
        Graticules()
        Sine()
        Cosine()
        Tangent()
    End Sub

    Private Sub ColorButton_Click(sender As Object, e As EventArgs) Handles ColorButton.Click
        DialogBox()                                                     'ADDS COLOR DIALOG BOX
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        GraphicsPictureBox.Refresh()                                    '"VOLATILE" CLEARS GRAPHICS BOX
    End Sub

    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        Connect()                                                       'CALLS OUR CONNECT SUB TO GET PORT READY TO SENT & RECEIVE DATA
    End Sub
    '==========================================COLORS==========================================
    Function SetColor(Optional newColor As Color = Nothing) As Color    'SETS OR GETS FORECOLOR
        Static _forecolor As Color = Color.PaleTurquoise
        If newColor <> Nothing Then
            _forecolor = newColor
        End If
        Return _forecolor                                               'ALLOWS USER TO SELECT ANY COLOR
    End Function
    Function DialogBox() As Color
        ColorBox.ShowDialog()
        SetColor(ColorBox.Color)
        Return SetColor()
    End Function
    '==========================================MATHEMATICAL GRAPHICS==========================================

    Sub Graticules()
        Dim graphics As Graphics = GraphicsPictureBox.CreateGraphics    'CREATES A GRAPHICS OBJECT TO DRAW ON THE PICTURE BOX
        Dim pen As New Pen(Color.LightSlateGray)
        Dim y As Integer = 0
        Dim x As Integer = 0                                            'GRID INTEGERS INITIALIZED TO ZERO

        Do Until y > GraphicsPictureBox.Height                          'DRAWS HORIZONTAL LINES ACROSS THE HEIGHT

            y += (GraphicsPictureBox.Height \ 10)                       'INCREMENTS Y BUT BY 1/10 OF THE HEIGHT
            graphics.DrawLine(pen, 0, y, GraphicsPictureBox.Width, y)   'DRAWS LINE FROM LEFT TO RIGHT

        Loop

        Do Until x > GraphicsPictureBox.Width                           'DRAWS VERTICAL LINES ACROSS THE WIDTH

            x += (GraphicsPictureBox.Width \ 10)
            graphics.DrawLine(pen, x, 0, x, GraphicsPictureBox.Height)  'DRAWS LINE FROM TOP TO BOTTOM

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
        Dim oldY As Integer = GraphicsPictureBox.Height
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
            mouseIsDrawing = True                                       'ENABLES DRAWING MODE
            lastPt = e.Location                                         'STORES LAST POINT WHERE MOUSE IS CLICKED
            Using g As Graphics = GraphicsPictureBox.CreateGraphics(), p As New Pen(SetColor(), 2)
                g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias     'MAKES LINES SMOOTHER
                g.DrawLine(p, lastPt, lastPt)                           'DRAWS A SINGLE POINT IF MOUSE IS CLICKED
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
            lastPt = e.Location                                         'UPDATES LAST POINT TO CURRENT LOCATION
        End If
    End Sub

    Private Sub GraphicsPictureBox_MouseUp(sender As Object, e As MouseEventArgs) Handles GraphicsPictureBox.MouseUp
        If e.Button = MouseButtons.Left Then
            mouseIsDrawing = False
        End If
    End Sub

    '==========================================QY@ GRAPHICS==========================================
    Private Sub CommandTimer_Tick(sender As Object, e As EventArgs) Handles CommandTimer.Tick
        If QYATBoardRadioButton.Checked AndAlso SerialPort.IsOpen Then
            Const RequestAnalogCommand As Byte = &H53
            SerialPort.Write(New Byte() {RequestAnalogCommand}, 0, 1)
            SentTextBox.Text = $"{RequestAnalogCommand:X2}"
        End If
    End Sub
    Private Sub ReadTimer_Tick(sender As Object, e As EventArgs) Handles ReadTimer.Tick
        If Not SerialPort.IsOpen Then Exit Sub                          'EXIT IF PORT ISN'T OPEN

        While SerialPort.BytesToRead >= 4
            Dim b(3) As Byte                                            'CREATES AN ARRAY TO STORE 4 BYTES
            Dim read As Integer = SerialPort.Read(b, 0, 4)              'READS 4 BYTES FROM SERIAL PORT INTO ARRAY

            If read < 4 Then Exit While                                 'IF LESS THAN 4 BYTES READ, EXIT LOOP

            ProcessQBoardPacket(b)                                      'SEND BYTES TO PROCESSING SUB
        End While
    End Sub
    Private Sub ProcessQBoardPacket(b() As Byte)
        '===========================================
        '=================IMPORTANT=================
        '===========================================
        'THIS COMBINES BITS FROM TWO BYTES TO CREATE A 10-BIT VALUE FOR X AND Y COORDINATES
        Dim x As Integer = (CInt(b(0)) << 2) Or (b(1) >> 6)             'X-AXIS VALUE
        Dim y As Integer = (CInt(b(2)) << 2) Or (b(3) >> 6)             'Y-AXIS VALUE

        DrawWithQBoard(x, y)                                            'DRAWS USING THE X AND Y VALUES
    End Sub

    Sub DrawWithQBoard(x As Integer, y As Integer)
        Dim graphics As Graphics = GraphicsPictureBox.CreateGraphics
        Dim pen As New Pen(SetColor)
        pen.Width = 0.25
        Static oldx, oldy As Integer
        Dim scaleX As Single = CSng(GraphicsPictureBox.Width / 1100)            'MATH TO SCALE 10-BIT VALUE TO PICTURE BOX SIZE
        Dim scaleY As Single = CSng((GraphicsPictureBox.Height / 1100) * -1)    '1100 IS A SAFE VALUE TO AVOID GOING OUT OF BOUNDS
        graphics.TranslateTransform(0, GraphicsPictureBox.Height)
        graphics.ScaleTransform(scaleX, scaleY)

        Dim newX As Integer = x
        Dim newY As Integer = y

        graphics.DrawLine(pen, oldx, oldy, newX, newY)                  'DRAWS LINE FROM OLD TO NEW COORDINATES
        oldy = newY
        oldx = newX

        graphics.Dispose()
    End Sub

    Private Sub QYATBoardRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles QYATBoardRadioButton.CheckedChanged
        If QYATBoardRadioButton.Checked Then
            mouseIsDrawing = False

            If QYATBoardRadioButton.Checked AndAlso SerialPort.IsOpen Then
                CommandTimer.Interval = 50                              'DETERMINES HOW OFTEN COMMAND IS SENT
                ReadTimer.Interval = 10                                 'DETERMINES HOW OFTEN TO READ THE PORT BUFFER
                CommandTimer.Enabled = True
                ReadTimer.Enabled = True
            Else
                CommandTimer.Enabled = False
                ReadTimer.Enabled = False
            End If
        End If
    End Sub

    '==========================================MENU STRIP==========================================
    Private Sub EXITToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub SAVEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAVEToolStripMenuItem.Click
        Using saveDialog As New SaveFileDialog()
            saveDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp"
            saveDialog.Title = "Save Your Masterpiece"
            saveDialog.FileName = "MyDrawing.png"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Dim bmp As New Bitmap(GraphicsPictureBox.Width, GraphicsPictureBox.Height)
                GraphicsPictureBox.DrawToBitmap(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height))

                Select Case IO.Path.GetExtension(saveDialog.FileName).ToLower()
                    Case ".jpg"
                        bmp.Save(saveDialog.FileName, Imaging.ImageFormat.Jpeg)
                    Case ".bmp"
                        bmp.Save(saveDialog.FileName, Imaging.ImageFormat.Bmp)
                    Case Else
                        bmp.Save(saveDialog.FileName, Imaging.ImageFormat.Png)
                End Select

                MessageBox.Show("Your piece has been saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub

    Private Sub ABOUTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ABOUTToolStripMenuItem1.Click
        Dim message As String =
        "Etch-A-Sketch" & vbCrLf &
        "By Alexis Villagran" & vbCrLf &
        "Fall 2025 — Idaho State University" & vbCrLf & vbCrLf &
        "Your current subscription includes the Ultra Deluxe Pro features!"
        MessageBox.Show(message, "About Etch-A-Sketch", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
