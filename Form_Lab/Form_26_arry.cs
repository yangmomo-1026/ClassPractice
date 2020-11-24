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
    public partial class Form_26_arry : Form
    {
        public Form_26_arry()
        {
            InitializeComponent();
        }

        private void btn_arry_Click(object sender, EventArgs e)
        {
            int[] arr = new int[3] { 1, 2, 3 };
            
            int[] arr2 = new int[2];
            arr2[0] = 1;
            arr2[1] = 2;

            int[] arr3 = { 1, 2, 3 };


            MessageBox.Show("arr[2] :" + arr[2] + "\n" + "arr2[1] :" + arr2[1] + "\n" + "arr3[2] :" + arr3[2]);

        }

        private void btn_arry_2_Click(object sender, EventArgs e)
        {
            int[,] brr = new int[3, 3];
            brr[ 2 , 1 ] = 8;
            brr[ 2 , 2 ] = 9;

            int[,] brr2 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int[,] brr3 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            MessageBox.Show("brr[ 2 , 1 ] : " + brr[2, 1] +"\n"+ "brr2[ 2 , 1 ] : " + brr2[2, 1] + "\n"+ "brr3[ 2 , 1 ] : " + brr3[2, 1]);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Class_member[] crr = new Class_member[2];
            //crr[0].Name = new Class_member();
            //crr[0].Name = "YO";
            //crr[0].Age = 30;
            //crr[1].Name = "WE";
            //crr[1].Age = 20;

            //MessageBox.Show(crr[0].Name + " , " + crr[0].Age);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] drr = take(20);
            string ResultShow = "";
            //for (int id = 0; id < drr.Length; id++)
            //{
            //    ResultShow += drr[id] + "\n";
            //}

            foreach( int item in drr)
            {
                ResultShow += item + "\n";
            }


            MessageBox.Show(ResultShow);


        }
        int[] take(int len)
        {
            int[] result = new int[len];

            for (int i = 0; i < len; i++)
            {
                result[i] = i + 1;
            }
            return result;
        }
}
}
