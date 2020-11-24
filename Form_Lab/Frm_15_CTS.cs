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
    public partial class Frm_15_CTS : Form
    {
        public Frm_15_CTS()
        {
            InitializeComponent();
        }

        private void but_valuetype_Click(object sender, EventArgs e)
        {
            int A = 1;
            int B = 2;
            MessageBox.Show("A是 " + A + " B是 " + B);
            A = B;
            MessageBox.Show("A是 " + A + " B是 " + B);

            //int C;
            MessageBox.Show("C是 " + CC);
        }
        int CC;

        private void but_go_Click(object sender, EventArgs e)
        {

            Class_member WEE = new Class_member() { Name = "WEE", Age = 50 };
            Class_member COCO = WEE;
            MessageBox.Show(COCO.Name);
            WEE.Name = "COCO BOBO";
            MessageBox.Show(COCO.Name);

        }
    }
}
