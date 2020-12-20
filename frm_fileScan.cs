using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;

namespace Shell_Anti_Vírus
{
    public partial class frm_fileScan : Form
    {
        public frm_fileScan()
        {
            InitializeComponent();
        }

        public string GetMD5FromFile(string filenPath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filenPath))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var md5signatures = File.ReadAllLines("MD5base.txt");
            if (md5signatures.Contains(tbMD5.Text))
            {
                lblStatus.Text = "Status: Infectado!";
                lblStatus.ForeColor = Color.Red;
            }

            else
            {
                lblStatus.Text = "Status: Limpo!";
                lblStatus.ForeColor = Color.Green;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            lblStatus.Text = "Status: N/A";
            lblStatus.ForeColor = Color.Black;

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbMD5.Text = GetMD5FromFile(ofd.FileName);
            }
        }
    }
}
