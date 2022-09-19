using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kliker
{
    public partial class Form1 : Form
    {
        public int licznik = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            licznik=licznik+1;
            label1.Text=licznik.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
