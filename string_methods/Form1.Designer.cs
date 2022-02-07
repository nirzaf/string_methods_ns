namespace string_methods
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.string_textBox1 = new System.Windows.Forms.TextBox();
            this.len_textBox2 = new System.Windows.Forms.TextBox();
            this.birth_date_textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.birth_yeartextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.birth_monthtextBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.birth_daytextBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.month_name_label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate length";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // string_textBox1
            // 
            this.string_textBox1.Location = new System.Drawing.Point(34, 25);
            this.string_textBox1.Name = "string_textBox1";
            this.string_textBox1.Size = new System.Drawing.Size(100, 20);
            this.string_textBox1.TabIndex = 1;
            this.string_textBox1.TextChanged += new System.EventHandler(this.string_textBox1_TextChanged);
            // 
            // len_textBox2
            // 
            this.len_textBox2.Location = new System.Drawing.Point(34, 51);
            this.len_textBox2.Name = "len_textBox2";
            this.len_textBox2.Size = new System.Drawing.Size(100, 20);
            this.len_textBox2.TabIndex = 2;
            // 
            // birth_date_textBox1
            // 
            this.birth_date_textBox1.Location = new System.Drawing.Point(285, 25);
            this.birth_date_textBox1.Name = "birth_date_textBox1";
            this.birth_date_textBox1.Size = new System.Drawing.Size(118, 20);
            this.birth_date_textBox1.TabIndex = 3;
            this.birth_date_textBox1.Text = "25/09/1981";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Birth Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Birth Year:";
            // 
            // birth_yeartextBox2
            // 
            this.birth_yeartextBox2.Location = new System.Drawing.Point(285, 51);
            this.birth_yeartextBox2.Name = "birth_yeartextBox2";
            this.birth_yeartextBox2.Size = new System.Drawing.Size(118, 20);
            this.birth_yeartextBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Birth Month:";
            // 
            // birth_monthtextBox3
            // 
            this.birth_monthtextBox3.Location = new System.Drawing.Point(285, 77);
            this.birth_monthtextBox3.Name = "birth_monthtextBox3";
            this.birth_monthtextBox3.Size = new System.Drawing.Size(45, 20);
            this.birth_monthtextBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Birth Day:";
            // 
            // birth_daytextBox4
            // 
            this.birth_daytextBox4.Location = new System.Drawing.Point(285, 103);
            this.birth_daytextBox4.Name = "birth_daytextBox4";
            this.birth_daytextBox4.Size = new System.Drawing.Size(118, 20);
            this.birth_daytextBox4.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Show Result";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // month_name_label5
            // 
            this.month_name_label5.Location = new System.Drawing.Point(336, 81);
            this.month_name_label5.Name = "month_name_label5";
            this.month_name_label5.Size = new System.Drawing.Size(88, 13);
            this.month_name_label5.TabIndex = 12;
            this.month_name_label5.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 225);
            this.Controls.Add(this.month_name_label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.birth_daytextBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.birth_monthtextBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.birth_yeartextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.birth_date_textBox1);
            this.Controls.Add(this.len_textBox2);
            this.Controls.Add(this.string_textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox string_textBox1;
        private System.Windows.Forms.TextBox len_textBox2;
        private System.Windows.Forms.TextBox birth_date_textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox birth_yeartextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox birth_monthtextBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox birth_daytextBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label month_name_label5;
    }
}

