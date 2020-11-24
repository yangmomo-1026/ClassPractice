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
    public partial class Form_累加 : Form
    {
        public Form_累加()
        {
            InitializeComponent();
        }

        int count =0;
        private void but_more_Click(object sender, EventArgs e)
        {
            count += 1;
            lab_num.Text = count + "次";
            Class_static.static_sum += 2;
            MessageBox.Show(Class_static.static_sum.ToString());

        }

        private void but_back_Click(object sender, EventArgs e)
        {
            int a = count++;
            lab_num.Text = a + "累加";
        }

        Class_static sl = new Class_static();
        private void but_static_Click(object sender, EventArgs e)
        {
            sl.sum += 1;
            MessageBox.Show(sl.sum.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class_static.static_sum += 2;
            MessageBox.Show(Class_static.static_sum.ToString());
        }
    }
}
