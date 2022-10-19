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
    public partial class Form2 : Form
    {
        int b = 0;
        int c = 0;
        int i = 0;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public static int procesor = 0;

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
            {
                Form2.procesor = 0;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton1.Checked == true && radioButton2.Checked == false  && radioButton3.Checked == false && radioButton4.Checked == false)
            {
                Form2.procesor = 500;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton1.Checked == false && radioButton2.Checked == true && radioButton3.Checked == false && radioButton4.Checked == false)
            {
                Form2.procesor = 700;
                label6.Text = Form1.GlobalKomputer.ToString();
            }





           
            if (radioButton1.Checked == false)
            {
                Form1.GlobalKomputer -= 500;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton3.Checked == true)
            {
                Form1.GlobalKomputer += 1200;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton3.Checked == false)
            {
                Form1.GlobalKomputer -= 1200;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton4.Checked == true)
            {
                Form1.GlobalKomputer += 1700;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton4.Checked == false)
            {
                Form1.GlobalKomputer -= 1700;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                Form1.GlobalKomputer += 600;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton5.Checked == false)
            {
                Form1.GlobalKomputer -= 600;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton6.Checked == true)
            {
                Form1.GlobalKomputer += 1500;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton6.Checked == false)
            {
                Form1.GlobalKomputer -= 1500;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton7.Checked == true)
            {
                Form1.GlobalKomputer += 1200;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton7.Checked == false)
            {
                Form1.GlobalKomputer -= 1200;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton8.Checked == true)
            {
                Form1.GlobalKomputer += 1700;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton8.Checked == false)
            {
                Form1.GlobalKomputer -= 1700;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton9.Checked == true)
            {
                Form1.GlobalKomputer += 1600;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton9.Checked == false)
            {
                Form1.GlobalKomputer -= 1600;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton10.Checked == true)
            {
                Form1.GlobalKomputer += 2500;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton10.Checked == false)
            {
                Form1.GlobalKomputer -= 2500;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton11.Checked == true)
            {
                Form1.GlobalKomputer += 3500;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton11.Checked == false)
            {
                Form1.GlobalKomputer -= 3500;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
        }











        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            
        }






        private void groupBox3_Enter(object sender, EventArgs e)
        {
            if (radioButton18.Checked == true)
            {
                Form1.GlobalKomputer += 400;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton18.Checked == false)
            {
                Form1.GlobalKomputer -= 400;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton19.Checked == true)
            {
                Form1.GlobalKomputer += 800;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton19.Checked == false)
            {
                Form1.GlobalKomputer -= 800;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton20.Checked == true)
            {
                Form1.GlobalKomputer += 1600;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton20.Checked == false)
            {
                Form1.GlobalKomputer -= 1600;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
        }









        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            
        }












        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = comboBox1.SelectedItem;
            if (selectedItem == "Windows")
            {
                Form1.GlobalKomputer += 1000 - b;
                label6.Text = Form1.GlobalKomputer.ToString();
                b = 1000;
            }
            else if (selectedItem == "Linux")
            {
                Form1.GlobalKomputer += 0;
                label6.Text = Form1.GlobalKomputer.ToString();
                c = 0;
            }
            else if (selectedItem == "Mac OS")
            {
                Form1.GlobalKomputer += 2000 - i;
                label6.Text = Form1.GlobalKomputer.ToString();
                i = 2000;
            }
        }








        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Form1.GlobalKomputer += 1000;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if(checkBox1.Checked == false)
            {
                Form1.GlobalKomputer -= 1000;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                Form1.GlobalKomputer += 1500;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (checkBox2.Checked == false)
            {
                Form1.GlobalKomputer -= 1500;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                Form1.GlobalKomputer += 2000;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (checkBox3.Checked == false)
            {
                Form1.GlobalKomputer -= 2000;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                Form1.GlobalKomputer += 500;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (checkBox4.Checked == false)
            {
                Form1.GlobalKomputer -= 500;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                Form1.GlobalKomputer += 1000;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (checkBox5.Checked == false)
            {
                Form1.GlobalKomputer -= 1000;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked == true)
            {
                Form1.GlobalKomputer += 700;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
            if (radioButton2.Checked == false)
            {
                Form1.GlobalKomputer -= 700;
                label6.Text = Form1.GlobalKomputer.ToString();
            }
        }
















        private void label6_Click(object sender, EventArgs e)
        {
            
            label2.Text = Form1.GlobalKomputer.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm2 =  new Form1();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
