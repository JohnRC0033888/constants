using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace constants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double pi = 3.141592653589793;
            double c = 299792458;
            double d1 = 5e6;
            richTextBox1.AppendText(pi.ToString() + "\n");
            richTextBox1.AppendText(pi.ToString("N") + "\n");
            richTextBox1.AppendText(c.ToString("N3") + "\n");
            richTextBox1.AppendText(c.ToString("NO") + "\n");
            richTextBox1.AppendText(d1.ToString("0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.0E0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.00E00") + "\n");

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
