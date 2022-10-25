using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;

namespace _1024_2
{
    public partial class Form1 : Form
    {
        Button[] btn_phone = new Button[15];
        int player_i = 0;
        int player_j = 0;
        bool up = true;   //true 代表有起來了
        public Form1()
        {
            InitializeComponent();
            btn_phone[0] = button1; btn_phone[1] = button2; btn_phone[2] = button3; btn_phone[3] = button4;btn_phone[4] = button5;
            btn_phone[5] = button6; btn_phone[6] = button7; btn_phone[7] = button8; btn_phone[8] = button9; btn_phone[9] = button10;
            btn_phone[10] = button11; btn_phone[11] = button12; btn_phone[12] = button13; btn_phone[13] = button14; btn_phone[14] = button15;
            for (int i = 0; i < btn_phone.Length; i++)
            {
                //it's important to have this; closing over the loop variable would be bad
                int index = i;
                btn_phone[i].MouseDown += (sender, args) => btn_phone_MouseDown(index);
                btn_phone[i].MouseUp += (sender, args) => btn_phone_MouseUp(index);
            }
            tabControl1.KeyDown += TabControl1_KeyDown;
            tabControl1.KeyUp += TabControl1_KeyUp;
        }

        private void TabControl1_KeyUp(object sender, KeyEventArgs e)
        {
                 btn_phone_MouseUp(0);
        }

        private void TabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue <= 106 && e.KeyValue >= 96 && e.KeyValue != 106)
            {

                if (e.KeyValue == 96)
                {
                    btn_phone_MouseDown(10);
                }
                else
                {
                    btn_phone_MouseDown(e.KeyValue - 1 - 96);
                }
            }
            else if (e.KeyValue <= 57 && e.KeyValue >= 48)
            {
                if (e.KeyValue == 0)
                {
                    btn_phone_MouseDown(10);
                }
                else if (e.KeyValue == 48)
                {
                    btn_phone_MouseDown(10);
                }
                else
                {
                    btn_phone_MouseDown(e.KeyValue - 1 - 48);
                }
            }
            else if (e.KeyValue == 56 && e.Shift)
            {
                btn_phone_MouseDown(9);
            }
            else if (e.KeyValue == 51 && e.Shift)
            {
                btn_phone_MouseDown(11);
            }
            else if (e.KeyValue == (char)Keys.Back)
            {
                btn_phone_MouseDown(14);
            }
            else if (e.KeyValue == (char)Keys.Enter)
            {
                btn_phone_MouseDown(13);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        private void btn_phone_MouseDown(int idx)
        {
            player_i = 10;
            player_j = 10;
                if (telephone.Text == "Telephone" && idx != 13 )
                {
                    telephone.Text = "";
                }
                else if (idx == 14 && telephone.Text != "")
                {
                    telephone.Text = telephone.Text.Remove(telephone.Text.Length - 1, 1);
            }
                if (idx == 12 &&  up)
                {
                    telephone.Text = "";
            }
                if (idx == 13 && telephone.Text != "Telephone" )
                {
                    if (btn_phone[idx].Text == "📱")
                    {
                        for (int i = 0; i < 15; i++)
                        {
                            if (i != 13)
                                btn_phone[i].Enabled = false;
                        }
                        btn_phone[idx].Text = "📵";
                    }
                    else
                    {
                        telephone.Text = "Telephone";
                        for (int i = 0; i < 15; i++)
                        {
                            btn_phone[i].Enabled = true;
                        }
                        btn_phone[idx].Text = "📱";
                    }
                    if (telephone.Text != "" && telephone.Text != "Telephone")
                    {
                        textBox2.Text += telephone.Text + "\r\n";
                    }

            }              
            
            if (idx < 12 && up)
            {
                player_i = idx / 3; player_j = idx % 3;
                telephone.Text += btn_phone[idx].Text;
                up = false;
            }            
            switch (player_i )
            {
                case 0:
                    axWindowsMediaPlayer1.URL = Application.StartupPath + "\\697.wav";
                    break;
                case 1:
                    axWindowsMediaPlayer1.URL = Application.StartupPath + "\\770.wav";
                    break;
                case 2:
                    axWindowsMediaPlayer1.URL = Application.StartupPath + "\\852.wav";
                    break;
                case 3:
                    axWindowsMediaPlayer1.URL = Application.StartupPath + "\\941.wav";
                    break;
                case 4:
                    break;
            }
            switch (player_j)
            {
                case 0:
                    axWindowsMediaPlayer2.URL = Application.StartupPath + "\\1209.wav";
                    break;
                case 1:
                    axWindowsMediaPlayer2.URL = Application.StartupPath + "\\1336.wav";
                    break;
                case 2:
                    axWindowsMediaPlayer2.URL = Application.StartupPath + "\\1477.wav";
                    break;
            }

        }
        private void btn_phone_MouseUp(int idx)
        {
            for(int i = 0; i < 15; i++)
            {
                axWindowsMediaPlayer2.close();
                axWindowsMediaPlayer1.close();
            }
            up = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Empty String");
            }
            if (!File.Exists(textBox1.Text))
            {
                MessageBox.Show("Directory Not Found"); 
            }
            else
            {
                try
                {
                    using (StreamWriter sw = File.CreateText(textBox1.Text))
                    {
                        sw.WriteLine(textBox2.Text);
                    }
                    MessageBox.Show(textBox1.Text);
                }
                catch(Exception ee)
                {

                }
                
            }
        }
    }
}
