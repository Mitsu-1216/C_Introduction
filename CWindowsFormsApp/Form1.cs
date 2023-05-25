using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_Enter(object sender, EventArgs e) {
            if (textBoxName.Text=="name") {
                textBoxName.Text="";
                textBoxName.ForeColor=Color.Black;
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e) {
            if (textBoxEmail.Text=="aiueo@example.com"){
                textBoxEmail.Text="";
                textBoxEmail.ForeColor=Color.Black;
            }
        }


        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text=="")
            {
                textBoxEmail.Text="aiueo@example.com";
                textBoxEmail.ForeColor=Color.Silver;
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text=="")
            {
                textBoxName.Text="name";
                textBoxName.ForeColor=Color.Silver;
            }
        }

        private void textBoxEmail_TextChanged_1(object sender, EventArgs e)
        {


        }
    }
}
