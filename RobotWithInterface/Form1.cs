using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Collections;
using Sicily.Gps;
namespace RobotWithInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            serialPort1.Encoding = Encoding.UTF8;
            serialPort1.StopBits = StopBits.One;
            serialPort1.Parity = Parity.None;
            serialPort1.BaudRate = 38400;
            serialPort1.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ArrayList list = new ArrayList();

            
            int size = serialPort1.ReadBufferSize;
           // char[] buffer = new char[size];
            
            //serialPort1.Read(buffer, 0, size);
            string temp = serialPort1.ReadExisting();
      ///      GpsReading gpsReading = GpsReading.Parse(temp);
       //     GgaData gga = gpsReading.FixedGpsData;
        }
    }
}
