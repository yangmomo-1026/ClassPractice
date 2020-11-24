using System;
using System.Collections;
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
    public partial class Form_29_employee : Form
    {
        public Form_29_employee()
        {
            InitializeComponent();
        }
        ArrayList La = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            employee emp;
            emp.name = textBox1.Text;
            emp.age = Convert.ToInt32(textBox2.Text);
            La.Add(emp);
            show();
        }

        void show()
        {
            label3.Text = "員工資料\n==============\n" + La.Count;
            for (int i = 0 ; i<La.Count ; i++)
            {
                label3.Text += $"姓名 : { ((employee)La[i]).name}\n年齡 : { ((employee) La[i]).age}\n-----------\n";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            employee emp;
            emp.name = textBox1.Text;
            emp.age = Convert.ToInt32(textBox2.Text);
            La.Insert(0 , emp) ;
            show();
        }


    }
}
