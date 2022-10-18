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
        int b = 0;
        int c = 0;
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
            var selectedItem = comboBox1.SelectedItem;
            if (selectedItem == "DELL")
            {
                if(comboBox2.selectedItem = "60")
                {

                }
                if (comboBox2.selectedItem = "75")
                {

                }
                if ( = "144")
                {

                }
                if (comboBox2.selectedItem = "165")
                {

                }
            }
            else if (selectedItem == "Microsoft")
            {
                
            }
            else if (selectedItem == "Lenovo")
            {
                
            }
            else if (selectedItem == "APPLE")
            {

            }
            else if (selectedItem == "SAMSUNG")
            {

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
