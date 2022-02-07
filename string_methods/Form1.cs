using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace string_methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.len_textBox2.Text = this.string_textBox1.Text.Length.ToString();
        }

        private void string_textBox1_TextChanged(object sender, EventArgs e)
        {
            string t;
            t = this.string_textBox1.Text;
            this.len_textBox2.Text = t.Length.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.birth_daytextBox4.Text = this.birth_date_textBox1.Text.Substring(0, 2);
            this.birth_monthtextBox3.Text = this.birth_date_textBox1.Text.Substring(3, 2);
            // this.birth_yeartextBox2.Text = this.birth_date_textBox1.Text.Substring(6, 4);
            Int32 i;
            i = this.birth_date_textBox1.Text.Length;
            this.birth_yeartextBox2.Text = this.birth_date_textBox1.Text.Substring(i - 4, 4);
            //-----------------------------
            Int32 m;
            Int32.TryParse(this.birth_monthtextBox3.Text, out m);
            string mn;

            switch (m)
            {
               
                case 1:
                    mn = "January";
                    break;

                case 2:
                    mn = "February";
                    break;

                case 3:
                    mn = "March";
                    break;

                case 4:
                    mn = "April";
                    break;

                case 5:
                    mn = "May";
                    break;

                case 6:
                    mn = "June";
                    break;

                case 7:
                    mn = "July";
                    break;

                case 8:
                    mn = "August";
                    break;

                case 9:
                    mn = "September";
                    break;

                case 10:
                    mn = "October";
                    break;

                case 11:
                    mn = "November";
                    break;

                case 12:
                    mn = "December";
                    break;

                default:
                    mn = "Unknown";
                    break;
            }
            //------------------------------
            this.month_name_label5.Text = mn;
            //------------------------------

        }
    }
}
