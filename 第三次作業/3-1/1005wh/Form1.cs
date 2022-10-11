using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1005wh
{

    public partial class searchbtn : Form
    {
        List<Account> accounts = new List<Account> { };
        public searchbtn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            int[] a = new int[accounts.Count] ;
            for(int i = 0; i < accounts.Count; i++)
            {
                for(int j = i ; j < accounts.Count; j++)
                {
                    if(accounts[i].pass == accounts[j].pass)
                    {
                        textBox2.Text += "連結:" + accounts[i].link + "\r\n使用者:" + accounts[i].user + "\r\n密碼:" + accounts[i].pass + "\r\n================================================\r\n";
                        break;
                    }
                }
            }
        }

        private void searchbtn_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            info.Visible = false;
            show.Visible = true;
            up.Enabled = true;
            url.Text = "";
            user_.Text = "";
            secret.Text = "";
        }

        private void addordelete_Click(object sender, EventArgs e)
        {
            info.Visible = true;
            show.Visible = false;
            up.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)      //////新增帳號
        {
            bool re = true;  ////看有沒有重複
            Account tem = new Account(url.Text, user_.Text, secret.Text);

            accounts.ForEach(delegate (Account a)
            {
                if (tem.link == a.link )
                {
                    re = false;
                }
            });
 
            if (re)
            {
                accounts.Add(tem);
                url.Text = "";
                user_.Text = "";
                secret.Text = "";
                condition.Text = "新增完成";
            }
            if (!re)
            {
                condition.Text = "帳號已存在";
            }
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            bool de = false;
            Account tem = new Account(url.Text, user_.Text, secret.Text);

            for(int i = 0; i < accounts.Count; i++)
            {
                if (tem.link == accounts[i].link && tem.user == accounts[i].user && tem.pass == accounts[i].pass)
                {
                    accounts.Remove(accounts[i]);
                    url.Text = "";
                    user_.Text = "";
                    secret.Text = "";
                    condition.Text = "成功刪除";
                    de = true;
                }
            }
            if (!de)
            {
                condition.Text = "帳號不存在或密碼錯誤";
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            string search = search_box.Text;
            textBox2.Text = "";
            if(search != "")
            {
                accounts.ForEach(delegate (Account a)
                {
                    if (a.link.Contains(search))
                    {
                        textBox2.Text += "連結:" + a.link + "\r\n使用者:" + a.user + "\r\n密碼:" + a.pass + "\r\n================================================\r\n";
                    }
                });
            }
            else
            {
                accounts.ForEach(delegate (Account a)
                {
                    textBox2.Text += "連結:" + a.link + "\r\n使用者:" + a.user + "\r\n密碼:" + a.pass + "\r\n================================================\r\n";
                });
            }
        }
    }
    class Account
    {
        public string link, user, pass;  
        public Account(string _link , string _user , string _pass)
        {
            link = _link;
            user = _user;
            pass = _pass;
        }
        
    }

}
