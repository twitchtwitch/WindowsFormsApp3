using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int pb = 10;int ct = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            int i = 0 ; i++;
            {
                string I;
                Random X = new Random();
                int Rd = X.Next(99);
                if (Rd < pb) { I = " HIT "; pb = 10;ct = 0; } else { I = " MISS "; pb += 10; ct++; }
                status.Text = I;
                string string0=string.Format("{0}%", pb);
                chance.Text =string0;
                title.Text = string.Format("MISSx{0}",ct);

            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
