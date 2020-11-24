using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Lab
{
    public partial class Form_name_cat : Form
    {
        public Form_name_cat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //事件 
        {
            string Name = textBox_name.Text;
            Console.WriteLine(Name);
            MessageBox.Show("Hello " + Name + "! ");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form_name_cat_Load(object sender, EventArgs e)
        {

        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
