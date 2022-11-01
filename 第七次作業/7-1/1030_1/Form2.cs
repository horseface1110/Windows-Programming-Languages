using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1030_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2sure_Click(object sender, EventArgs e)
        {
            if(form2textBox1.Text != "")
            {
                Form1.Instance.edittextbox1(form2textBox1.Text);
                form2cancel_Click(sender, e);
            }
            else
            {
                MessageBox.Show("請輸入事項");
            }
        }

        private void form2cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1.Instance.Form1_Enable();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            form2cancel_Click(sender, e);
        }
    }
}
