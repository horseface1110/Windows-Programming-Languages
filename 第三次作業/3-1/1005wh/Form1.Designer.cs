namespace _1005wh
{
    partial class searchbtn
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.search_box = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.risk = new System.Windows.Forms.Button();
            this.addordelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Panel();
            this.info = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.secret = new System.Windows.Forms.TextBox();
            this.user_ = new System.Windows.Forms.TextBox();
            this.url = new System.Windows.Forms.TextBox();
            this.condition = new System.Windows.Forms.TextBox();
            this.up = new System.Windows.Forms.Panel();
            this.show.SuspendLayout();
            this.info.SuspendLayout();
            this.up.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "密碼管理員";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "搜尋列";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(98, 20);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(802, 25);
            this.search_box.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 56);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(863, 411);
            this.textBox2.TabIndex = 3;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(933, 19);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 26);
            this.search.TabIndex = 4;
            this.search.Text = "搜尋";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // risk
            // 
            this.risk.Location = new System.Drawing.Point(73, 72);
            this.risk.Name = "risk";
            this.risk.Size = new System.Drawing.Size(934, 33);
            this.risk.TabIndex = 5;
            this.risk.Text = "風險帳號";
            this.risk.UseVisualStyleBackColor = true;
            this.risk.Click += new System.EventHandler(this.button1_Click);
            // 
            // addordelete
            // 
            this.addordelete.Location = new System.Drawing.Point(689, 7);
            this.addordelete.Name = "addordelete";
            this.addordelete.Size = new System.Drawing.Size(245, 34);
            this.addordelete.TabIndex = 6;
            this.addordelete.Text = "新增或刪除";
            this.addordelete.UseVisualStyleBackColor = true;
            this.addordelete.Click += new System.EventHandler(this.addordelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "搜尋結果";
            // 
            // show
            // 
            this.show.Controls.Add(this.label3);
            this.show.Controls.Add(this.addordelete);
            this.show.Controls.Add(this.textBox2);
            this.show.Location = new System.Drawing.Point(82, 218);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(953, 485);
            this.show.TabIndex = 8;
            // 
            // info
            // 
            this.info.Controls.Add(this.back);
            this.info.Controls.Add(this.label6);
            this.info.Controls.Add(this.user);
            this.info.Controls.Add(this.link);
            this.info.Controls.Add(this.delete);
            this.info.Controls.Add(this.button1);
            this.info.Controls.Add(this.secret);
            this.info.Controls.Add(this.user_);
            this.info.Controls.Add(this.url);
            this.info.Controls.Add(this.condition);
            this.info.Location = new System.Drawing.Point(83, 218);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(953, 510);
            this.info.TabIndex = 17;
            this.info.Visible = false;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(732, 7);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(202, 34);
            this.back.TabIndex = 18;
            this.back.Text = "回主畫面";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "密碼";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(87, 231);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(52, 15);
            this.user.TabIndex = 15;
            this.user.Text = "使用者";
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(87, 148);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(37, 15);
            this.link.TabIndex = 14;
            this.link.Text = "連結";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(679, 351);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 28);
            this.delete.TabIndex = 13;
            this.delete.Text = "刪除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // secret
            // 
            this.secret.Location = new System.Drawing.Point(154, 299);
            this.secret.Name = "secret";
            this.secret.Size = new System.Drawing.Size(600, 25);
            this.secret.TabIndex = 12;
            // 
            // user_
            // 
            this.user_.Location = new System.Drawing.Point(154, 221);
            this.user_.Name = "user_";
            this.user_.Size = new System.Drawing.Size(600, 25);
            this.user_.TabIndex = 11;
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(154, 145);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(600, 25);
            this.url.TabIndex = 10;
            // 
            // condition
            // 
            this.condition.Location = new System.Drawing.Point(90, 54);
            this.condition.Name = "condition";
            this.condition.ReadOnly = true;
            this.condition.Size = new System.Drawing.Size(664, 25);
            this.condition.TabIndex = 8;
            this.condition.Text = "我是狀態列";
            // 
            // up
            // 
            this.up.Controls.Add(this.risk);
            this.up.Controls.Add(this.search);
            this.up.Controls.Add(this.search_box);
            this.up.Controls.Add(this.label2);
            this.up.Location = new System.Drawing.Point(11, 32);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(1025, 115);
            this.up.TabIndex = 9;
            // 
            // searchbtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 836);
            this.Controls.Add(this.info);
            this.Controls.Add(this.up);
            this.Controls.Add(this.show);
            this.Controls.Add(this.label1);
            this.Name = "searchbtn";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.searchbtn_Load);
            this.show.ResumeLayout(false);
            this.show.PerformLayout();
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            this.up.ResumeLayout(false);
            this.up.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button risk;
        private System.Windows.Forms.Button addordelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel show;
        private System.Windows.Forms.Panel up;
        private System.Windows.Forms.TextBox condition;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.TextBox user_;
        private System.Windows.Forms.TextBox secret;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label link;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel info;
        private System.Windows.Forms.Button back;
    }
}

