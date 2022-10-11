namespace _1009_1
{
    partial class Form1
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
            this.begin = new System.Windows.Forms.Button();
            this.conti = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpage1 = new System.Windows.Forms.TabPage();
            this.re0 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabpage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // begin
            // 
            this.begin.Location = new System.Drawing.Point(534, 35);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(124, 40);
            this.begin.TabIndex = 0;
            this.begin.Text = "開始遊戲";
            this.begin.UseVisualStyleBackColor = true;
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // conti
            // 
            this.conti.Location = new System.Drawing.Point(534, 106);
            this.conti.Name = "conti";
            this.conti.Size = new System.Drawing.Size(123, 45);
            this.conti.TabIndex = 1;
            this.conti.Text = "繼續";
            this.conti.UseVisualStyleBackColor = true;
            this.conti.Click += new System.EventHandler(this.conti_Click);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(534, 462);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(123, 42);
            this.left.TabIndex = 2;
            this.left.Text = "離開";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "翻牌小遊戲";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(707, 567);
            this.tabControl1.TabIndex = 4;
            // 
            // tabpage1
            // 
            this.tabpage1.Controls.Add(this.re0);
            this.tabpage1.Controls.Add(this.name);
            this.tabpage1.Controls.Add(this.label3);
            this.tabpage1.Controls.Add(this.grade);
            this.tabpage1.Controls.Add(this.label2);
            this.tabpage1.Controls.Add(this.begin);
            this.tabpage1.Controls.Add(this.conti);
            this.tabpage1.Controls.Add(this.left);
            this.tabpage1.Location = new System.Drawing.Point(4, 25);
            this.tabpage1.Name = "tabpage1";
            this.tabpage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage1.Size = new System.Drawing.Size(699, 538);
            this.tabpage1.TabIndex = 0;
            this.tabpage1.Text = "遊玩區";
            this.tabpage1.UseVisualStyleBackColor = true;
            this.tabpage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // re0
            // 
            this.re0.Location = new System.Drawing.Point(534, 190);
            this.re0.Name = "re0";
            this.re0.Size = new System.Drawing.Size(123, 43);
            this.re0.TabIndex = 7;
            this.re0.Text = "重新開始";
            this.re0.UseVisualStyleBackColor = true;
            this.re0.Click += new System.EventHandler(this.re0_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(212, 17);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(155, 25);
            this.name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "名稱：";
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.Location = new System.Drawing.Point(92, 23);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(28, 15);
            this.grade.TabIndex = 4;
            this.grade.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "分數：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(699, 538);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "歷史紀錄區";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-4, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(707, 542);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 631);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabpage1.ResumeLayout(false);
            this.tabpage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button begin;
        private System.Windows.Forms.Button conti;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label grade;
        private System.Windows.Forms.Button re0;
        private System.Windows.Forms.TextBox textBox1;
    }
}

