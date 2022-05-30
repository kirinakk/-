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
    public partial class Form5 : Form
    {
        public Form3 frm3;
        public Form2 frm2;
        public Form7 frm7;
        public Form8 frm8;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm2 = new Form2();
            frm2.frm5 = this;
            frm2.Show();
            this.Hide();
            //frm3.Hide();
            //frm7.Hide();
            //frm8.Hide();

        }
    }
}
