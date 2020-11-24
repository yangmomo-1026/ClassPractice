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
    public partial class Form08_click : Form
    {
        public Form08_click()
        {
            InitializeComponent();
        }

        private void button_click01_Click(object sender, EventArgs e)
        {
            //this.button_click01.Click += new System.EventHandler(this.button_click01_Click);
            button_click01.Click += new EventHandler(this.button_click02_Click);
        }

        private void button_click02_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click02");
        }

       

    }

}
