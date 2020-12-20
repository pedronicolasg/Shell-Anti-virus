using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Shell_Anti_Vírus
{
    public partial class frm_shell : Form
    {
        

        public frm_shell()
        {
            InitializeComponent();
            BCscanmode.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuVTrackbar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BCscanmode.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_fileScan ffs = new frm_fileScan();
            ffs.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BCscanmode.Visible = false;
        }
    }
}
