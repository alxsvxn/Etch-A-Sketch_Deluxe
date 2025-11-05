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
    '==========================================COLORS & GRAPHICS========================================
End Class
