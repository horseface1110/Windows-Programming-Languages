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

namespace _1030_1
{
    public partial class Form1 : Form
    {
        private static Form1 _instance = null;

        public static Form1 Instance
        {
            get
            {
                if (_instance == null) _instance = new Form1();
                return _instance;
            }
        }


        OpenFileDialog dialog = new OpenFileDialog();
        bool selectadd = false;
        bool selectopen = false;
        string path = Application.StartupPath + "555.todo";
        private Form1()
        {
            InitializeComponent();
        }

        private void 令存心檔ToolStripMenuItem_Click(object sender, EventArgs e)      //哀哀
        {
            path = Application.StartupPath + "555.todo";
            SaveFileDialog mySaveFileDialog = new SaveFileDialog(); //新增檔案儲存視窗
            mySaveFileDialog.Title = "另存新檔";
            mySaveFileDialog.Filter = "Todo Files (*.todo)|*.todo|Text File (*.txt)|*.txt|All File (*.*)|*.*";
            if (mySaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var myFile = File.Create(mySaveFileDialog.FileName);  //新建文件(另存新檔視窗)
                myFile.Close();

            }



        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String line;
            textBox1.Text = "";
            selectopen = true;
            dialog.Title = "請選擇檔案";
            dialog.Filter = "Todo Files (*.todo)|*.todo|Text File (*.txt)|*.txt|All File (*.*)|*.*";
            path = dialog.FileName;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dialog.FileName);
                line = sr.ReadLine();
                while (line != null)
                {
                    //write the line to console window
                    textBox1.Text += line;
                    textBox1.Text += "\r\n";
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();

            }
        }

        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectopen)
            {
                StreamWriter sw = new StreamWriter(dialog.FileName);
                sw.WriteLine(textBox1.Text);
                sw.WriteLine("\r\n");
                sw.Close();
                selectopen = false;
            }
            else
            {
                令存心檔ToolStripMenuItem_Click(sender, e);
            }

        }

        private void 離開ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void 字型大小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void additem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form2 f2 = new Form2();
            f2.ShowDialog(this);
        }
        public  void edittextbox1(string a)
        {
            textBox1.Text += a;
            textBox1.Text += "\r\n";
        }
        public void Form1_Enable()
        {
            this.Enabled = true;
        }
    }
}
