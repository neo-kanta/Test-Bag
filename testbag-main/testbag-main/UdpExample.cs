using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

namespace ConsoleApplication2udp
{
    public partial class Form1 : Form
    {
        private UdpClient udpClient;
        private Thread thdUDPServer;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_send_Click(object sender, EventArgs e) //CLIENT
        {
            try
            {   
                udpClient = new UdpClient();
                udpClient.Connect(textBox_ip.Text, Convert.ToInt16(textBox_port.Text));

                string message = textBox_message.Text;
                //int sequenceNumber = getSequenceNumber(udpClient.Client.LocalEndPoint.ToString());

                for (int i = 0; i < MaxRetries; i++)
                {
                    Byte[] senddata = Encoding.ASCII.GetBytes(message + ":" + sequenceNumber);
                    udpClient.Send(senddata, senddata.Length);

                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    udpClient.Client.ReceiveTimeout = 5000; // 5 second timeout

                    Byte[] receiveBytes;
                    try { receiveBytes = udpClient.Receive(ref RemoteIpEndPoint); }
                    catch (SocketException ex) { if (ex.SocketErrorCode == SocketError.TimedOut) { continue; } else { throw; } }
                    string returnData = Encoding.ASCII.GetString(receiveBytes);
                    if (returnData == "ACK:" + sequenceNumber) { MessageBox.Show("Packet successfully delivered."); break; }
                    else { if (i == MaxRetries - 1) { MessageBox.Show("Error: Packet not acknowledged."); } else { Thread.Sleep(RetryDelay); } }
                }
            }
            catch (FormatException) { MessageBox.Show("Error: Invalid IP address or port number."); }
            catch (ArgumentNullException) { MessageBox.Show("Error: Message is null."); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { udpClient.Close(); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
        }

        public void serverThread() //SERVER
        {
            try
            {
                udpClient = new UdpClient(8080);
                udpClient.Client.ReceiveBufferSize = 1024; // 1 KB buffer size
                while (true)
                {
                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                    string[] messageParts = Encoding.ASCII.GetString(receiveBytes).Split(':');

                    // Check if message has sequence number
                    if (messageParts.Length < 2) { continue; }
                    int sequenceNumber = Convert.ToInt32(messageParts[1]);

                    // Send acknowledgement to the sender
                    Byte[] sendBytes = Encoding.ASCII.GetBytes("ACK:" + sequenceNumber);
                    udpClient.Send(sendBytes, sendBytes.Length, RemoteIpEndPoint);

                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        listBox_received.Items.Add(RemoteIpEndPoint.Address.ToString() + " : " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") +
                            " : " + messageParts[0]);
                        listBox_received.SelectedIndex = listBox_received.Items.Count - 1;
                        listBox_received.SelectedIndex = -1;
                    }));
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { udpClient.Close(); }
        }
        // DISABLE X BUTTON
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            thdUDPServer.Abort(); // Stop the UDP server thread
            udpClient?.Close(); // Close the UDP client if it's open
        }
    }
}