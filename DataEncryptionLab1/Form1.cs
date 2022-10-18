using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEncryptionLab1_Kot_PC21_MH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_CLICK_OK(object sender, EventArgs e)
        {
            if (textBox1.Text == "Maksym" && textBox2.Text == "123")
            {
                label3.BackColor = Color.Green;
                MessageBox.Show("Hello, Maksym");
            }
            else
            {
                label3.BackColor= Color.Red;
                MessageBox.Show("Wrong login or password");
            }
        }
    }
}
