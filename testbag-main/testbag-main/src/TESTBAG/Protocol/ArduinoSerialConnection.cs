using System;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace TESTBAG.Protocol
{
    public class ArduinoSerialConnection : IDisposable
    {
        private SerialPort _serialPort;
        private Thread _threadSerial;
        private Logger logger;
        public bool IsConnected => _connectedFlag;
        public bool _connectedFlag;
        public bool _stopFlagSerial;

        private readonly object _lockObject = new object();

        private static string dataNano { get; set; }

        public delegate void NanoDataHandler(double currentDcNano, double voltageDcNano, double currentAcNano, double voltageAcNano);
        public event NanoDataHandler NanoDataReceived;

        #region SEND TO RECIEVE DATA --------------------------------------------------------------------
        public void SerialThreadStart()
        {
            _threadSerial = new Thread(new ThreadStart(this.SerialThreadTask));
            _threadSerial.IsBackground = true;
            _threadSerial.Start();
        }
        public void SerialThreadStop()
        {
            _stopFlagSerial = true;
            _threadSerial.Join();
        }
        public void SerialThreadTask()
        {
            try
            {
                while (!_stopFlagSerial)
                {
                    _serialPort.Write(":?\r\n");
                    dataNano = _serialPort.ReadLine();

                    var serialData = DataPattern.GetDataNano(dataNano);
                    double currentAcs = serialData.currentDc;
                    double voltageArduino = serialData.voltageDc;
                    double currentPzem = serialData.currentAc;
                    double voltagePzem = serialData.voltageAc;

                    double physicalVoltage = ((voltageArduino * 15) / 614) + ((0.2683 + 0.2670 + 0.2720 + 0.2735) / 4);
                    double physicalCurrent = (((currentAcs - 512) * 5) / 512);
                    NanoDataReceived?.Invoke(physicalCurrent, physicalVoltage, currentPzem, voltagePzem);
                }
            }
            catch (InvalidOperationException ex) { logger.HandleError($"Error writing (:?\r\n) data to serial port (Timeout): {ex.Message}"); }
            catch (TimeoutException ex) { logger.HandleError($"Error writing (:?\r\n) data to serial port (Timeout): {ex.Message}"); }
            catch (Exception ex) { logger.HandleError($"Error writing (:?\r\n) data to serial port (Timeout): {ex.Message}"); }
        }

        #endregion SEND TO RECIEVE DATA .........................................................................


        #region PORT CONNECTION --------------------------------------------------------------------
        public ArduinoSerialConnection(int baudRate = 115200)
        {
            _serialPort = new SerialPort();
            _serialPort.BaudRate = baudRate;
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            //_serialPort.DataReceived += SerialPort_DataReceived;
        }

        public void Connect(string portName)
        {

            try
            {
                lock (_lockObject)
                {
                    if (_serialPort.IsOpen)
                    {
                        Disconnect();
                        MessageBox.Show("Serial port has been disconnected");
                    }
                    _serialPort.PortName = portName;
                    _serialPort.Open();
                    _connectedFlag = true;
                    MessageBox.Show($"Serial port {portName} is open .", "Port Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (UnauthorizedAccessException ex) { logger.HandleError($"Error opening serial port (Access is denied): {ex.Message}"); }
            catch (IOException ex) { MessageBox.Show($"Error opening serial port (Port is not available): {ex.Message}"); }
            catch (ArgumentException ex) { logger.HandleError($"Error opening serial port (Invalid port parameters): {ex.Message}"); }
            catch (Exception ex) { logger.HandleError($"Error opening serial port: {ex.Message}"); }

        }

        public void Disconnect()
        {
            lock (_lockObject)
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                    _connectedFlag = false;
                    MessageBox.Show($"Serial port {_serialPort.PortName} is closed.", "Port Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = _serialPort.ReadExisting();
            // do something with the data received
        }
        public void Dispose()
        {
            if (_serialPort != null)
            {
                Disconnect();
                _serialPort.Dispose();
                _serialPort = null;
            }
        }
        #endregion PORT CONNECTION .........................................................................
    }
}