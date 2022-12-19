using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
//haha
//haha2
namespace WindowsPortFormsApp1
{
    public partial class Form1 : Form
    {
        string dataOut;
        string dataIn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            CBoxComPort.Items.AddRange(ports);

            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            ckbDTR.Checked = false;
            ckbRTS.Checked = false;
            serialPort1.DtrEnable = false;
            serialPort1.RtsEnable = false;
            btnSendData.Enabled = false;
            ComPortStatus.Text = "OFF";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int dataOutLength = tBoxDataOut.TextLength;
            DataOutLength.Text = string.Format("{0:0}", dataOutLength);
            //prevent a new line
            if (ckbUseReturn.Checked)
            {
                tBoxDataOut.Text = tBoxDataOut.Text.Replace(Environment.NewLine, "");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = CBoxComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(CBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(CBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), CBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), CBoxParityBits.Text);

                serialPort1.Open();
                progressBar1.Value = 100;
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                ComPortStatus.Text = "ON";

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = tBoxDataOut.Text;
                serialPort1.Write(dataOut);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                ComPortStatus.Text = "OFF";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDTR.Checked)
            {
                serialPort1.DtrEnable = true;
            }
            else
            {
                serialPort1.DtrEnable = false;

            }
        }

        private void ckbRTS_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRTS.Checked)
            {
                serialPort1.RtsEnable = true;
            }
            else
            {
                serialPort1.RtsEnable = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tBoxDataOut.Text != "")
            {
                tBoxDataOut.Text = "";
            }
        }

        private void ckbSendData_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbSendData.Checked == true)
            {
                btnSendData.Enabled = true;
            }
            else
            {
                btnSendData.Enabled = false;
            }
        }

        private void tBoxData_KeyDown(object sender, KeyEventArgs e)
        {
            if (ckbUseReturn.Checked)
            {
                if(e.KeyCode == Keys.Enter)
                {
                    if (serialPort1.IsOpen)
                    {
                        dataOut = tBoxDataOut.Text;
                        serialPort1.Write(dataOut);
                    }
                }
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIn = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {

            if (ckbAlwaysUpdate.Checked)
            {
                tBoxDataIn.Text = dataIn;
            }
            else
            {
                tBoxDataIn.Text += dataIn;
            }
            DataInLength.Text = string.Format("{0:0}", tBoxDataIn.TextLength);

        }

        private void ckbAlwaysUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAlwaysUpdate.Checked)
            {
                ckbAlwaysUpdate.Checked = true;
                ckbContinue.Checked = false;
            }
        }

        private void ckbContinue_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbContinue.Checked)
            {
                ckbAlwaysUpdate.Checked = false;
                ckbContinue.Checked = true;
            }
        }

        private void btnClearOutDataClick(object sender, EventArgs e)
        {
            tBoxDataIn.Text = "";
            DataInLength.Text = "0";
        }
    }
}
