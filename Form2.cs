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
    public partial class Form2 : Form
      
    {
        public Form1 frm1;
        public Form3 frm3;
        public Form4 frm4;
        public Form5 frm5;
        public Form6 frm6;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm4 = new Form4();//Создаем указатель на форму2
            frm4.frm2 = this;
            frm4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm6 = new Form6();
            frm6.frm2 = this;
            frm6.Show();
            
        }
    }
}
