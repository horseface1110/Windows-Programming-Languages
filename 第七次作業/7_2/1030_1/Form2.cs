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
            if (Form1.Instance.waiting || Form1.Instance.remove_  )
            {
                this.Text = "待辦事項";
            }
            else
            {
                this.Text = "新增代辦事項";
            }
        }

        private void Form2sure_Click(object sender, EventArgs e)
        {
            if (Form1.Instance.waiting)
            {

                for(int i = 0; i < Form1.Instance.count; i++)
                {
                    if (Form1.Instance.main_[i].Contains(form2textBox1.Text))
                    {
                        Form1.Instance.main_[i] = Form1.Instance.main_[i].Replace(" [ ] " + form2textBox1.Text + "\r\n", " [√] " + form2textBox1.Text + "\r\n");
                        Form1.Instance.textBox1.Text = Form1.Instance.textBox1.Text.Replace(" [ ] " + form2textBox1.Text + "\r\n", " [√] " + form2textBox1.Text + "\r\n");
                    }
                }
                Form1.Instance.waiting = false;
                form2cancel_Click(sender, e);

                /*      if (Form1.Instance.textBox1.Text.Contains(form2textBox1.Text))
                      {
                          Form1.Instance.textBox1.Text = Form1.Instance.textBox1.Text.Replace(" [ ] " + form2textBox1.Text + "\r\n", " [√] " + form2textBox1.Text + "\r\n");
                          Form1.Instance.main_[Form1.Instance.count - 1] = Form1.Instance.textBox1.Text.Replace(" [ ] " + form2textBox1.Text + "\r\n", " [√] " + form2textBox1.Text + "\r\n");
                      }
                      Form1.Instance.waiting = false;
                      form2cancel_Click(sender, e);  */
            }
            else if (Form1.Instance.remove_)
            {
                for (int i = 0; i < Form1.Instance.count; i++)
                {
                    if (Form1.Instance.main_[i].Equals(" [ ] " +form2textBox1.Text + "\r\n") || Form1.Instance.main_[i].Equals(" [√] " + form2textBox1.Text + "\r\n"))
                    {
                        Form1.Instance.main_[i] = Form1.Instance.main_[i].Replace(" [√] " + form2textBox1.Text + "\r\n", "");
                        Form1.Instance.main_[i] = Form1.Instance.main_[i].Replace(" [] " + form2textBox1.Text + "\r\n", "");
                        Form1.Instance.textBox1.Text = Form1.Instance.textBox1.Text.Replace(" [ ] " + form2textBox1.Text + "\r\n", "");
                    }
                }
                /* if (Form1.Instance.textBox1.Text.Contains( " [ ] "+ form2textBox1.Text))
                {
                    Form1.Instance.textBox1.Text = Form1.Instance.textBox1.Text.Replace(" [ ] " + form2textBox1.Text + "\r\n" , "");
                }
                else if (Form1.Instance.textBox1.Text.Contains(" [√] " + form2textBox1.Text))
                {
                    Form1.Instance.textBox1.Text = Form1.Instance.textBox1.Text.Replace(" [√] " + form2textBox1.Text + "\r\n", "");
                } */
                Form1.Instance.remove_ = false;
                form2cancel_Click(sender, e);
            }
            else if (Form1.Instance.search)
            {
                Form1.Instance.menuStrip1.Enabled = false;
                Form1.Instance.finish_.Visible = false;
                Form1.Instance.additem.Visible = false;
                Form1.Instance.button1.Visible = true;
                Form1.Instance.textBox1.Text = "";
                for (int i = 0; i < Form1.Instance.count; i++)
                {
                    if (Form1.Instance.main_[i].Contains(form2textBox1.Text))
                    {
                        Form1.Instance.textBox1.Text += Form1.Instance.main_[i];
                    }
                }
                Form1.Instance.search = false;
                form2cancel_Click(sender, e);
            }
            else
            {
                if (form2textBox1.Text != "")
                {
                    Form1.Instance.edittextbox1(form2textBox1.Text);
                    form2cancel_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("請輸入事項");
                }
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
