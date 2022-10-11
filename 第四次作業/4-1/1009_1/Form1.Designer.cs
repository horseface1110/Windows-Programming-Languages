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
            this.SuspendLayout();
            // 
            // begin
            // 
            this.begin.Location = new System.Drawing.Point(619, 61);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(124, 40);
            this.begin.TabIndex = 0;
            this.begin.Text = "開始遊戲";
            this.begin.UseVisualStyleBackColor = true;
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // conti
            // 
            this.conti.Location = new System.Drawing.Point(619, 177);
            this.conti.Name = "conti";
            this.conti.Size = new System.Drawing.Size(123, 45);
            this.conti.TabIndex = 1;
            this.conti.Text = "繼續";
            this.conti.UseVisualStyleBackColor = true;
            this.conti.Click += new System.EventHandler(this.conti_Click);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(619, 304);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(123, 42);
            this.left.TabIndex = 2;
            this.left.Text = "離開";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.left);
            this.Controls.Add(this.conti);
            this.Controls.Add(this.begin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button begin;
        private System.Windows.Forms.Button conti;
        private System.Windows.Forms.Button left;
    }
}

