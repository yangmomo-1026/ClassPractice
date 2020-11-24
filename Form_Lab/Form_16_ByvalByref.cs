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
    public partial class Form_16_ByvalByref : Form
    {
        public Form_16_ByvalByref()
        {
            InitializeComponent();
        }

        private void but_val_Click(object sender, EventArgs e)
        {
            int A = 55;
            MessageBox.Show( A.ToString() );
            Val(A);
            MessageBox.Show( A.ToString() );
        }

        void Val ( int age)
        {
            age = 10;
        }

        private void but_ref_Click(object sender, EventArgs e)
        {
            string[] strA = new string[3];
            strA[0] = "A";
            strA[1] = "B";
            strA[2] = "C";
            MessageBox.Show(strA[0]);
            BB(strA);
            MessageBox.Show(strA[0]);

        }

        void BB(string[] val)
        {
            val[0] = "GoGo宜得利";
        }

        private void but_reff_Click(object sender, EventArgs e)
        {
            int a = 40;
            MessageBox.Show(a.ToString());
            addref(ref a);
            MessageBox.Show(a.ToString());

        }

        void addref(ref int x)
        {
            x = 55;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int refent = 10;
            MessageBox.Show(refent.ToString());

            Output(out refent);
            MessageBox.Show(refent.ToString());
        }

        void Output(out int y)
        {
            y = 500;

        }
    }
}
