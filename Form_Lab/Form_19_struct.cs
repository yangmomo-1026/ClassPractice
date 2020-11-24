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
    public partial class Form_19_struct : Form
    {
        public Form_19_struct()
        {
            InitializeComponent();
        }

        string result;
        private void button1_Click(object sender, EventArgs e)
        {
            //Product pro;
            //pro.ProductName = tb_name.Text;
            //pro.ProductPrice = int.Parse(tb_price.Text);

            bool x;
            Product pro = new Product(tb_name.Text,tb_price.Text , out x);

            if (x == false)
            {
                MessageBox.Show("輸入錯誤");
                tb_price.Clear();
                tb_price.Focus();
                return;
            }
            result += $"產品名稱: {pro.ProductName}\n產品價錢: {pro.ProductPrice} ";
            //else
            //{
            //    result += $"產品名稱: {pro.ProductName}\n產品價錢: {pro.ProductPrice} \n-------------------------\n";
            //}
            //tb_name.Text = "";
            //tb_price.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = result+ "\n-------------------------\n";
        }
    }
}
