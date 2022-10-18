using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        int y = 0;
        int i = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm3 = new Form1();
            myForm3.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem2 = comboBox1.SelectedItem;
            if(selectedItem2.ToString() == "DELL")
            {
                Form1.GlobalMonitor = 0;
                i = 1;
                if (y != null && y == 1)
                {
                    Form1.GlobalMonitor += 500;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (y != null && y == 2)
                {
                    Form1.GlobalMonitor += 1000;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (y != null && y == 3)
                {
                    Form1.GlobalMonitor += 1500;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (y != null && y == 4)
                {
                    Form1.GlobalMonitor += 2000;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
            }
            else if (selectedItem2.ToString() == "Microsoft")
            {
                Form1.GlobalMonitor = 0;
                i = 2;
                if (y != null && y == 1)
                {
                    Form1.GlobalMonitor += 700;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (y != null && y == 2)
                {
                    Form1.GlobalMonitor += 1400;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (y != null && y == 3)
                {
                    Form1.GlobalMonitor += 2100;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (y != null && y == 4)
                {
                    Form1.GlobalMonitor += 2800;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
            }
            else if (selectedItem2.ToString() == "Lenovo")
            {
                Form1.GlobalMonitor = 0;
                i = 3;
                if (y != null && y == 1)
                {
                    Form1.GlobalMonitor += 500;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (y != null && y == 2)
                {
                    Form1.GlobalMonitor += 1000;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (y != null && y == 3)
                {
                    Form1.GlobalMonitor += 1500;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (y != null && y == 4)
                {
                    Form1.GlobalMonitor += 2000;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
            }
            else if (selectedItem2.ToString() == "APPLE")
            {
                Form1.GlobalMonitor = 0;
                i = 4;
                if (y != null && y == 1)
                {
                    Form1.GlobalMonitor += 1000;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (y != null && y == 2)
                {
                    Form1.GlobalMonitor += 2000;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (y != null && y == 3)
                {
                    Form1.GlobalMonitor += 3000;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (y != null && y == 4)
                {
                    Form1.GlobalMonitor += 4000;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
            }
            else if (selectedItem2.ToString() == "SAMSUNG")
            {
                Form1.GlobalMonitor = 0;
                i = 5;
                if (y != null && y == 1)
                {
                    Form1.GlobalMonitor += 900;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (y != null && y == 2)
                {
                    Form1.GlobalMonitor += 1800;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (y != null && y == 3)
                {
                    Form1.GlobalMonitor += 2700;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (y != null && y == 4)
                {
                    Form1.GlobalMonitor += 3600;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem3 = comboBox2.SelectedItem;
            if (selectedItem3.ToString() == "60")
            {
                Form1.GlobalMonitor = 0;
                y = 1;
                if (i != null && i == 1)
                {
                    Form1.GlobalMonitor += 500;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if(i != null && i == 2)
                {
                    Form1.GlobalMonitor += 700;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (i != null && i == 3)
                {
                    Form1.GlobalMonitor += 500;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (i != null && i == 4)
                {
                    Form1.GlobalMonitor += 1000;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (i != null && i == 5)
                {
                    Form1.GlobalMonitor += 900;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
            }
            else if (selectedItem3.ToString() == "75")
            {
                Form1.GlobalMonitor = 0;
                y = 2;
                if (i != null && i == 1)
                {
                    Form1.GlobalMonitor += 1000;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (i != null && i == 2)
                {
                    Form1.GlobalMonitor += 1400;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (i != null && i == 3)
                {
                    Form1.GlobalMonitor += 1000;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (i != null && i == 4)
                {
                    Form1.GlobalMonitor += 2000;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (i != null && i == 5)
                {
                    Form1.GlobalMonitor += 1800;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
            }
            else if (selectedItem3.ToString() == "144")
            {
                Form1.GlobalMonitor = 0;
                y = 3;
                if (i != null && i == 1)
                {
                    Form1.GlobalMonitor += 1500;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (i != null && i == 2)
                {
                    Form1.GlobalMonitor += 2100;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (i != null && i == 3)
                {
                    Form1.GlobalMonitor += 1500;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (i != null && i == 4)
                {
                    Form1.GlobalMonitor += 3000;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (i != null && i == 5)
                {
                    Form1.GlobalMonitor += 2700;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
            }
            else if (selectedItem3.ToString() == "165")
            {
                Form1.GlobalMonitor = 0;
                y = 4;
                if (i != null && i == 1)
                {
                    Form1.GlobalMonitor += 2000;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (i != null && i == 2)
                {
                    Form1.GlobalMonitor += 2800;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (i != null && i == 3)
                {
                    Form1.GlobalMonitor += 2000;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (i != null && i == 4)
                {
                    Form1.GlobalMonitor += 4000;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
                else if (i != null && i == 5)
                {
                    Form1.GlobalMonitor += 3600;
                    label1.Text = Form1.GlobalMonitor.ToString();
                }
            }
        }
    }
}
