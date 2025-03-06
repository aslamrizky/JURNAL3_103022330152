using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MODUL3_103022330152
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enam_Click(object sender, EventArgs e)
        {
            Output.Text += "6";
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {

        }

        private void samadengan_Click(object sender, EventArgs e)
        {
            string[] number = Output.Text.Split('+');
            int a = Int32.Parse(number[0]);
            int b = Int32.Parse(number[1]);
            int result = a + b;
            Output.Text = result.ToString();
        }

        private void nol_Click(object sender, EventArgs e)
        {
            Output.Text += "0";
        }

        private void satu_Click(object sender, EventArgs e)
        {
            Output.Text += "1";
        }

        private void dua_Click(object sender, EventArgs e)
        {
            Output.Text += "2";
        }

        private void tiga_Click(object sender, EventArgs e)
        {
            Output.Text += "3";
        }

        private void empat_Click(object sender, EventArgs e)
        {
            Output.Text += "4";
        }

        private void lima_Click(object sender, EventArgs e)
        {
            Output.Text += "5";
        }

        private void tujuh_Click(object sender, EventArgs e)
        {
            Output.Text += "7";
        }

        private void delapan_Click(object sender, EventArgs e)
        {
            Output.Text += "8";
        }

        private void sembilan_Click(object sender, EventArgs e)
        {
            Output.Text += "9";
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            Output.Text += "+";
        }
    }
}
