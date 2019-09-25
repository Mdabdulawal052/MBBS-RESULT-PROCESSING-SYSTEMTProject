using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            proof1 ss = new proof1();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            proof2 ss = new proof2();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            proof3 ss = new proof3();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            proof4 ss = new proof4();
            ss.Show();
        }
    }
}
