using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace форма_ателье_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = Data.a;
            textBox2.Text = Data.b;
            textBox3.Text = Data.c;
            textBox4.Text = Data.d;
            textBox5.Text = Data.e;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
