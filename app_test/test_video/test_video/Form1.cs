using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_video
{
    public partial class Form1 : Form
    {
        AutoIt a = new AutoIt();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a.mclick("LEFT", 38, 139, 2, 1);
        }
    }
}
