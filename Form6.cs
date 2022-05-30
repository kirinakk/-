using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace будущая_игра__но_это_не_точно
{
    public partial class Form6 : Form
    {
        public Form2 frm2;
        public Form3 frm3;
        public Form7 frm7;
        public Form8 frm8;

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm3 = new Form3();
            frm3.frm6 = this;
            frm3.Show();
            this.Hide();
            frm2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm7 = new Form7();
            frm7.frm6 = this;
            frm7.Show();
            this.Hide();
            frm2.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm8 = new Form8();
            frm8.frm6 = this;
            frm8.Show();
            this.Hide();
            frm2.Hide();
        }
    }
}
