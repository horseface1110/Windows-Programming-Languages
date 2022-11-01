namespace _1030_1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.form2textBox1 = new System.Windows.Forms.TextBox();
            this.Form2sure = new System.Windows.Forms.Button();
            this.form2cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(34, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "事項名稱";
            // 
            // form2textBox1
            // 
            this.form2textBox1.Location = new System.Drawing.Point(153, 75);
            this.form2textBox1.Name = "form2textBox1";
            this.form2textBox1.Size = new System.Drawing.Size(416, 25);
            this.form2textBox1.TabIndex = 1;
            // 
            // Form2sure
            // 
            this.Form2sure.Location = new System.Drawing.Point(374, 144);
            this.Form2sure.Name = "Form2sure";
            this.Form2sure.Size = new System.Drawing.Size(75, 36);
            this.Form2sure.TabIndex = 2;
            this.Form2sure.Text = "確認";
            this.Form2sure.UseVisualStyleBackColor = true;
            this.Form2sure.Click += new System.EventHandler(this.Form2sure_Click);
            // 
            // form2cancel
            // 
            this.form2cancel.Location = new System.Drawing.Point(500, 144);
            this.form2cancel.Name = "form2cancel";
            this.form2cancel.Size = new System.Drawing.Size(75, 36);
            this.form2cancel.TabIndex = 3;
            this.form2cancel.Text = "取消";
            this.form2cancel.UseVisualStyleBackColor = true;
            this.form2cancel.Click += new System.EventHandler(this.form2cancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 192);
            this.Controls.Add(this.form2cancel);
            this.Controls.Add(this.Form2sure);
            this.Controls.Add(this.form2textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox form2textBox1;
        private System.Windows.Forms.Button Form2sure;
        private System.Windows.Forms.Button form2cancel;
    }
}