using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace _1009_1
{
    
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Auto)]
        private extern static IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int PostMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        /// <summary>
        /// ///////////////////////////////////////////////////////////////
        /// </summary>
        int firstbtnim = 0;
        int firstbtnid = -1;
        int num = 0;
        Button[] btns = new Button[4 * 4];
        int[] tem1 = new int[8];
        int[] tem2 = new int[8];
        bool[] change = new bool[16];
        int score = 100;
        List<info> infos = new List<info>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conti.Enabled = false;
        }

        private void begin_Click(object sender, EventArgs e)
        {
            begin1();
        }
        private void begin1()
        {
           
            if (name.Text == "")
            {
                MessageBox.Show("名稱不能為空白", "偵錯", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (name.Text.Length < 3 || name.Text.Length > 10)
            {

                MessageBox.Show("名稱不合格式(>=3&&<=10)", "偵錯", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                begin.Enabled = false;

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        int idx = i * 4 + j;
                        btns[idx] = new Button();
                        btns[idx].Text = "";
                        btns[idx].Image = Image.FromFile(Application.StartupPath + "\\images\\card.jpg");
                        btns[idx].Height = 90;
                        btns[idx].ImageAlign = ContentAlignment.MiddleLeft;
                        btns[idx].Left = j * btns[0].Width + 30;
                        btns[idx].Top = i * btns[0].Height + 40;

                    }
                }
                //this.Controls.AddRange(btns);
                tabpage1.Controls.AddRange(btns);

                Random ran = new Random();

                for (int i = 0; i < 8; i++)
                {
                    tem1[i] = ran.Next(1, 9);
                    for (int j = 0; j < i; j++)
                    {
                        while (tem1[i] == tem1[j])
                        {
                            j = 0;
                            tem1[i] = ran.Next(1, 9);
                        }
                    }
                }
                for (int i = 0; i < 8; i++)
                {
                    tem2[i] = ran.Next(1, 9);
                    for (int j = 0; j < i; j++)
                    {
                        while (tem2[i] == tem2[j])
                        {
                            j = 0;
                            tem2[i] = ran.Next(1, 9);
                        }
                    }
                }
                for (int i = 0; i < btns.Length; i++)
                {
                    //it's important to have this; closing over the loop variable would be bad
                    int index = i;
                    btns[i].Click += (sender1, args) => btns_Click(index);
                }
            }
        }
        private void btns_Click(int idx)
        {
           if(!conti.Enabled && firstbtnid != idx)
            {
                if (firstbtnim == 0)
                {
                    if (idx < 8)
                    {
                        btns[idx].Image = Image.FromFile(Application.StartupPath + "\\images\\0" + tem1[idx] + ".jpg");
                        firstbtnim = tem1[idx];
                        firstbtnid = idx;
                    }

                    else
                    {
                        btns[idx].Image = Image.FromFile(Application.StartupPath + "\\images\\0" + tem2[idx - 8] + ".jpg");
                        firstbtnim = tem2[idx - 8];
                        firstbtnid = idx;
                    }


                }
                else      //////第二次了
                {
                    if (idx < 8)
                    {
                        if (tem1[idx] == firstbtnim)
                        {
                            btns[idx].Image = Image.FromFile(Application.StartupPath + "\\images\\0" + tem1[idx] + ".jpg");
                            btns[idx].Enabled = false;
                            btns[firstbtnid].Enabled = false;
                            change[firstbtnid] = true;
                            change[idx] = true;
                            firstbtnim = 0;
                            firstbtnid = -1;
                            num += 2;
                            grade.Text =""+(score+=10);
                        }
                        else
                        {
                            btns[idx].Image = Image.FromFile(Application.StartupPath + "\\images\\0" + tem1[idx] + ".jpg");
                            conti.Enabled = true;
                            for (int i = 0; i < 16; i++)
                            {
                                if (i != firstbtnid && i != idx)
                                {
                                    btns[i].Enabled = false;
                                }
                            }
                            firstbtnim = 0;
                            firstbtnid = -1;
                            grade.Text = "" + (score-= 5);
                        }

                    }
                    else     ///idx>=8
                    {
                        if (tem2[idx - 8] == firstbtnim)
                        {
                            btns[idx].Image = Image.FromFile(Application.StartupPath + "\\images\\0" + tem2[idx - 8] + ".jpg");
                            btns[idx].Enabled = false;
                            btns[firstbtnid].Enabled = false;
                            change[firstbtnid] = true;
                            change[idx] = true;
                            firstbtnim = 0;
                            firstbtnid = -1;
                            num += 2;
                            grade.Text = "" + (score += 10);
                        }
                        else
                        {
                            btns[idx].Image = Image.FromFile(Application.StartupPath + "\\images\\0" + tem2[idx - 8] + ".jpg");
                            conti.Enabled = true;
                            for (int i = 0; i < 16; i++)
                            {
                                if (i != firstbtnid && i != idx)
                                {
                                    btns[i].Enabled = false;
                                }
                            }
                            firstbtnim = 0;
                            firstbtnid = -1;
                            grade.Text = "" + (score -= 5);
                        }
                    }
                }
                if (num == 16)
                {
                    DialogResult Result = MessageBox.Show("分數：" + score, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                    

                    if (Result == DialogResult.Retry)
                    {
                        for (int j = 0; j < 16; j++)
                        {
                            tabpage1.Controls.Remove(btns[j]);
                            change[j] = false;
                        }
                        begin.Enabled = true;
                        name.Text = "";
                        grade.Text = "100";
                        num = 0;
                    }
                    else if (Result == DialogResult.Cancel)
                    {
                        IntPtr ptr = FindWindow(null, "MessageBox");
                        if (ptr != IntPtr.Zero)
                        {
                            //找到，則關閉MessageBox視窗
                            PostMessage(ptr, 0, IntPtr.Zero, IntPtr.Zero);
                        }
                    }
                    info i = new info(name.Text, score);
                    infos.Add(i);
                    textBox1.Text += (name.Text + "得分為：" + score + "\r\n" + "\r\n");
                }
            }
        }

        private void conti_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 16; i++)
            {
                if (!change[i])
                {
                    btns[i].Enabled = true;
                    btns[i].Image = Image.FromFile(Application.StartupPath + "\\images\\card.jpg");
                }
            }
            conti.Enabled = false;
        }

        private void left_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void re0_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++) {
                    tabpage1.Controls.Remove(btns[i]);
                change[i] = false;
            }
            begin.Enabled = true;
            name.Text = "";
            grade.Text = "100";
            num = 0;
        }
    }
    class info
    {
        public info(string name , int sc)
        {
            this.username = name;
            this.sc = sc;
        }
        string username;
        int sc = 0;
    }

}
