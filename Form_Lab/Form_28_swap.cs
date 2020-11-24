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
    public partial class Form_28_swap : Form
    {
        public Form_28_swap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;
            MessageBox.Show($" a = {a} , b = {b}");
            swapp<int>(ref a, ref b);
            MessageBox.Show($" a = {a} , b = {b}");
        }

        //void swap (ref int I1 , ref int I2)
        //{
        //    int T = I1;
        //    I1 = I2;
        //    I2 = T;
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            string A = "AAA", B = "BBB";
            MessageBox.Show($" A = {A} , B = {B}");
            swapp<string>(ref A, ref B);
            MessageBox.Show($" A = {A} , B = {B}");
        }

        //void swap (ref string S1 , ref string S2)
        //{
        //    string S = S1;
        //    S1 = S2;
        //    S2 = S;
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            string name = "Weeee" , name2 = "Ruaaaa";
            MessageBox.Show($" name = {name} , name2 = {name2}");

            swapp<string>(ref name, ref name2);
            MessageBox.Show($" name = {name} , name2 = {name2}");
        }

        void swapp<M>(ref M N1, ref M N2)
        {
            M T = N1;
            N1 = N2;
            N2 = T;
        }

    }
}
