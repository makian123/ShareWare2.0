using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keygen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void keyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void genButton_Click(object sender, EventArgs e)
        {
            ulong number = 0;

            number = getKey();

            keyTextBox.Text = "" + number;
        }

        ulong getKey()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int p1, p2, p3, p4;
            ulong result = 0;
            
            while(true)
            {
                p1 = rand.Next(1000, 9999);
                p2 = rand.Next(1000, 9999);
                p3 = rand.Next(1000, 9999);
                p4 = rand.Next(1000, 9999);

                if(p1 + p2 == 8532 && p3 / p4 == 3)
                {
                    result += (ulong) p1;
                    result *= (ulong) 10000;
                    result += (ulong) p2;
                    result *= (ulong) 10000;
                    result += (ulong) p3;
                    result *= (ulong) 10000;
                    result += (ulong) p4;

                    return result;
                }
            }
        }
    }
}
