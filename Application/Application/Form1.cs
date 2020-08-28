using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkButton_Click(object sender, EventArgs e)
        {
            int p1, p2, p3, p4;

            try
            {
                p1 = Int32.Parse(keyBox1.Text);
                p2 = Int32.Parse(textBox1.Text);
                p3 = Int32.Parse(textBox2.Text);
                p4 = Int32.Parse(textBox3.Text);

                if (chkGood(p1, p2, p3, p4))
                {
                    checkedPanel.Visible = true;
                    label4.Text = "Good key";
                    label4.Visible = true;
                }
                else
                {
                    checkedPanel.Visible = true;
                    label4.Text = "Bad key";
                    label4.Visible = true;
                }
            }
            catch (Exception ex)
            {
                checkedPanel.Visible = true;
                label4.Text = "Bad key";
                label4.Visible = true;
            }
        }

        bool chkGood(int p1, int p2, int p3, int p4)
        {
            if(p1 + p2 == 8532 && p3 / p4 == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
