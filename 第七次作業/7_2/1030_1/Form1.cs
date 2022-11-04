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
        public bool waiting = false;
        public bool remove_ = false;
        public bool search = false;
        public string[] main_ = new string[99999];
        public int count = 0;
        String tem;
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
                String tem = textBox1.Text.Trim();
                tem = tem.Replace(" [ ] ", "-");
                tem = tem.Replace(" [√] ", "+");
                tem = tem.Replace("[ ] ", "-");
                tem = tem.Replace("[√] ", "-");
                StreamWriter sw = new StreamWriter(mySaveFileDialog.FileName);
                sw.Write(tem);
                sw.Close();


            }



        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 99999; i++)
            {
                main_[i] = "";
            }
            textBox1.Text = "";
        }

        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 99999; i++)
            {
                main_[i] = "";
            }
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
                    if(line.Contains("-"))
                        main_[count] += line.Replace("-" , " [ ] ");
                    else
                        main_[count] += line.Replace("+", " [√] ");
                    main_[count] += "\r\n";
                    textBox1.Text += main_[count++];
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

                for (int i = 0; i < count ; i++)
                {
                    tem += main_[i].Replace(" [ ] ", "-");
                    tem += main_[i].Replace(" [√] ", "+");
                    tem += main_[i].Replace("[ ] ", "-");
                    tem += main_[i].Replace("[√] ", "+");
                }
              
                tem = tem.Replace(" [√] ", "+");
                tem = tem.Replace("[ ] ", "-");
                tem = tem.Replace("[√] ", "+");
                StreamWriter sw = new StreamWriter(dialog.FileName);
                sw.Write(tem);
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

            main_[count] += " [ ] ";
            main_[count] += a;
            main_[count] += "\r\n";
            textBox1.Text += main_[count++];
        }
        public void Form1_Enable()
        {
            this.Enabled = true;
        }

        private void finish__Click(object sender, EventArgs e)
        {
            waiting = true;
            additem_Click(sender, e);

        }

        private void vuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 顯示完成事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            for(int i = 0; i < count; i++)
            {
                textBox1.Text += main_[i];
            }
        }

        private void 隱藏完成事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            for(int i = 0; i < count; i++)
            {
                if(main_[i].Contains(" [ ] "))
                {
                    textBox1.Text += main_[i];
                }
            }
        }

        private void 新增事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            additem_Click(sender, e);
        }

        private void 完成事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            finish__Click( sender, e);
        }

        private void 刪除事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            remove_ = true;
            additem_Click( sender,  e);
        }

        private void 尋找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search = true;
            additem_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            additem.Visible = true;
            finish_.Visible = true;
            menuStrip1.Enabled = true;
        }
    }
}
