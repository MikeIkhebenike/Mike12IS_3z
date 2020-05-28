using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mike12IS_3z
{
    public partial class Mike : Form
    {
        public Mike()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, p, s,z;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            p =  (a + b + c)*1/2;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            z = (a * b * c) / (4*s);
            listBox1.Items.Add("Функция z = " +z );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
