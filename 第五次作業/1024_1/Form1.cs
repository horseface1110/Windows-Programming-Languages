using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1024_1
{
    public partial class Form1 : Form
    {
        int bpm;
        int times_4 = 0;
        int times_8 = 0;
        int time_4_2 = 0;
        int time_8_2 = 0;
        string comboBox1_Text;
        SoundPlayer player1 = new SoundPlayer();
        SoundPlayer player2 = new SoundPlayer();
        SoundPlayer player3 = new SoundPlayer();
        System.Timers.Timer timer = new System.Timers.Timer();
        public Form1()
        {
            InitializeComponent();          
            player1.SoundLocation = Application.StartupPath + "\\ding.wav";
            player2.SoundLocation = Application.StartupPath + "\\dong.wav";
            player3.SoundLocation = Application.StartupPath + "\\doo.wav";
            button6.Image = Image.FromFile(Application.StartupPath + "\\33.png");
            timer.Elapsed += Timer_Elapsed;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            button1.BackColor = DefaultBackColor;
            button2.BackColor = DefaultBackColor;
            button3.BackColor = DefaultBackColor;
            button4.BackColor = DefaultBackColor;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (comboBox1_Text == "4" && radioButton1.Checked)
            {
                if (times_4 == 0)
                {
                    player1.Play();
                    button1.BackColor = Color.Green;
                    button4.BackColor = DefaultBackColor;
                    times_4++;
                }
                else if (times_4 ==1)
                {
                    player2.Play();
                    button2.BackColor = Color.Green;
                    button1.BackColor = DefaultBackColor;
                    times_4++;
                }
                else if (times_4 == 2)
                {
                    player2.Play();
                    button3.BackColor = Color.Green;
                    button2.BackColor = DefaultBackColor;
                    times_4++;
                }
                else if (times_4 == 3)
                {
                    player2.Play();
                    button4.BackColor = Color.Green;
                    button3.BackColor = DefaultBackColor;
                    times_4 = 0;
                }
            }
            if (comboBox1_Text == "4" && radioButton2.Checked)
            {
                if (time_4_2 == 0)
                {
                    player1.Play();
                    button1.BackColor = Color.Green;
                    button4.BackColor = DefaultBackColor;
                    time_4_2++;
                }
                else if (time_4_2 == 7)
                {
                    player3.Play();                    
                    time_4_2 = 0;
                }
                else if (time_4_2 % 2 == 1)
                {
                    player3.Play();
                    time_4_2++;
                }
                else if (time_4_2 == 2)
                {
                    button2.BackColor = Color.Green;
                    button1.BackColor = DefaultBackColor;
                    player2.Play();
                    time_4_2++;
                }
                else if (time_4_2 == 4)
                {
                    player2.Play();
                    button3.BackColor = Color.Green;
                    button2.BackColor = DefaultBackColor;
                    time_4_2++;
                }
                else if (time_4_2 == 6)
                {
                    player2.Play();
                    button4.BackColor = Color.Green;
                    button3.BackColor = DefaultBackColor;
                    time_4_2++;
                }
            }
            if (comboBox1_Text == "8" && radioButton1.Checked)
            {
                if (times_8 == 0)
                {
                    player1.Play();
                    button5.BackColor = Color.Green;
                    button13.BackColor = DefaultBackColor;
                    times_8++;
                }
                else if (times_8 == 1)
                {
                    player2.Play();
                    button7.BackColor = Color.Green;
                    button5.BackColor = DefaultBackColor;
                    times_8++;
                }
                else if (times_8 == 2)
                {
                    player2.Play();
                    button8.BackColor = Color.Green;
                    button7.BackColor = DefaultBackColor;
                    times_8++;
                }
                else if (times_8 == 3)
                {
                    player2.Play();
                    button9.BackColor = Color.Green;
                    button8.BackColor = DefaultBackColor;
                    times_8++;
                }
                else if (times_8 == 4)
                {
                    player2.Play();
                    button10.BackColor = Color.Green;
                    button9.BackColor = DefaultBackColor;
                    times_8++;
                }
                else if (times_8 == 5)
                {
                    player2.Play();
                    button11.BackColor = Color.Green;
                    button10.BackColor = DefaultBackColor;
                    times_8++;
                }
                else if (times_8 == 6)
                {
                    player2.Play();
                    button12.BackColor = Color.Green;
                    button11.BackColor = DefaultBackColor;
                    times_8++;
                }
                else if (times_8 == 7)
                {
                    player2.Play();
                    button13.BackColor = Color.Green;
                    button12.BackColor = DefaultBackColor;
                    times_8 = 0;
                }
                
            }
            if (comboBox1_Text == "8" && radioButton2.Checked)
            {
                if (time_8_2 == 0)
                {
                    player1.Play();
                    button5.BackColor = Color.Green;
                    button13.BackColor = DefaultBackColor;
                    time_8_2++;
                }
                else if (time_8_2 == 15)
                {
                    player3.Play();
                    time_8_2 = 0;
                }
                else if(time_8_2 % 2 == 1)
                {
                    player3.Play();
                    time_8_2++;
                }
                else if (time_8_2 == 2)
                {
                    player2.Play();
                    button7.BackColor = Color.Green;
                    button5.BackColor = DefaultBackColor;
                    time_8_2++;
                }
                else if (time_8_2 == 4)
                {
                    player2.Play();
                    button8.BackColor = Color.Green;
                    button7.BackColor = DefaultBackColor;
                    time_8_2++;
                }
                else if (time_8_2 == 6)
                {
                    player2.Play();
                    button9.BackColor = Color.Green;
                    button8.BackColor = DefaultBackColor;
                    time_8_2++;
                }
                else if (time_8_2 == 8)
                {
                    player2.Play();
                    button10.BackColor = Color.Green;
                    button9.BackColor = DefaultBackColor;
                    time_8_2++;
                }
                else if (time_8_2 == 10)
                {
                    player2.Play();
                    button11.BackColor = Color.Green;
                    button10.BackColor = DefaultBackColor;
                    time_8_2++;
                }
                else if (time_8_2 == 12)
                {
                    player2.Play();
                    button12.BackColor = Color.Green;
                    button11.BackColor = DefaultBackColor;
                    time_8_2++;
                }
                else if (time_8_2 == 14)
                {
                    player2.Play();
                    button13.BackColor = Color.Green;
                    button12.BackColor = DefaultBackColor;
                    time_8_2++;
                }
            }
        }




        private void start_Click(object sender, EventArgs e)
        {
            comboBox1_Text = comboBox1.Text;
            if (start.Text == "start")
            {
                start.Text = "stop";
                label5.Text = "" + trackBar1.Value;
                timer.Interval = 60 * 1000 / trackBar1.Value;
                timer.Start();
            }
            else
            {
                timer.Stop();
                start.Text = "start";
            }

        }
        private void TrackBar1_ValueChanged(object sender, System.EventArgs e)
        {
            label1.Text = trackBar1.Value + "BMP";
            if (radioButton2.Checked)
            {
                timer.Interval = 30 * 1000 / trackBar1.Value;
                label5.Text = "" + timer.Interval;
            }
            else
            {
                timer.Interval = 60 * 1000 / trackBar1.Value;
            }
            label5.Text = "" + timer.Interval;
        }
        private void Combobox_ValueChanged(object sender, System.EventArgs e)
        {
            comboBox1_Text = comboBox1.Text;
            if (comboBox1.Text == "4")
            {
                panel1.Visible = true;
                panel2.Visible = false;

            }
            else
            {
                panel2.Visible = true;
                panel1.Visible = false;
            }
        }
        private void RadioButton_ValueChanged(object sender, System.EventArgs e)
        {
            
            if (radioButton2.Checked)
            {
                time_4_2 = times_4 * 2;
                time_8_2 = times_8 * 2;
                timer.Interval = 30 * 1000 / trackBar1.Value;
                label5.Text = "" + timer.Interval;
            }
            else
            {
                if(time_4_2 == 1)
                {
                    times_4 = 1;
                    times_8 = 1;
                }
                else
                {
                    times_4 = time_4_2 / 2;
                    times_8 = time_8_2 / 2;
                }

                timer.Interval = 60 * 1000 / trackBar1.Value;
            }
        }
    }
}
