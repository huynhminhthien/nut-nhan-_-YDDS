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
using AutoItX3Lib;

namespace YDDS_APP
{
    public partial class Form1 : Form
    {
        string datain;
        AutoItX3 auto = new AutoItX3();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cboport.Items.AddRange(ports);
            btndisconnect.Enabled = false;
            grbvitri.Enabled = false;
        }

        private void btconnect_Click(object sender, EventArgs e)
        {
            btconnect.Enabled = false;
            btndisconnect.Enabled = true;
            grbvitri.Enabled = true;
            
            try
            {
                serialPort1.PortName = cboport.Text;
                serialPort1.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy chọn cổng COM trước khi kết nối");
            }
        }

        private void btndisconnect_Click(object sender, EventArgs e)
        {
            btconnect.Enabled = true;
            btndisconnect.Enabled = false;
            grbvitri.Enabled = false;
            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }
        string tmp = "0",tmp1="0";
        int kt = 0, kt1=0,kt2=0,a=0,b=0;

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            datain = serialPort1.ReadExisting();

            if (datain == "1" && tmp != "2" && tmp != "3" && kt == 0)
            {
                tmp = "1";
                kt = 1;
                a = 1;
            }

            if (datain == "2" && tmp != "1" && tmp != "3" && kt1 == 0)
            {
                tmp = "2";
                kt1 = 1;
                b = 1;
            }

            if ((datain == "2" && tmp == "1" && kt2 == 0) || (tmp == "2") && datain == "1" && kt2 == 0)
            {
                tmp1 = "3";
                tmp = "3";
                kt2 = 1;
            }

            if (tmp == "1" && a == 1)
            {
                auto.MouseClick("LEFT", Convert.ToInt32(txtNamX.Text), Convert.ToInt32(txtNamY.Text), 2, 1);
                auto.Send("^g");
                a = 0;
            }
            if (tmp == "2" && b == 1)
            {
                auto.MouseClick("LEFT", Convert.ToInt32(txtNuX.Text), Convert.ToInt32(txtNuY.Text), 2, 1);
                auto.Send("^g");
                b = 0;
            }
            if (tmp1 == "3")
            {
                auto.MouseClick("LEFT", Convert.ToInt32(txtCaHaiX.Text), Convert.ToInt32(txtCaHaiY.Text), 2, 1);
                auto.Send("^g");
                tmp1 = "4";
            }
            
            
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
            Application.Exit();
        }

        private void btminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
            kt = 0;
            kt1 = 0;
            kt2 = 0;
            tmp = "0";
            tmp1 = "0";
            picTim.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kt==1)
            {
                pictrai.BringToFront();
                kt = 2;
            }
            if (kt1==1)
            {
                picphai.BringToFront();
                kt1 = 2;
            }
            if (kt2==1)
            {
                piccahai.BringToFront();
                kt2 = 2;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (serialPort1.IsOpen)
                    serialPort1.Close();
                Application.Exit();
            }
        }

        
    }
}
