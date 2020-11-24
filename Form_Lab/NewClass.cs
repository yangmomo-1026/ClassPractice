using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Lab
{
    struct Product
    {
        public string ProductName;
        public string ProductPrice;
        public Product (string name, string price , out bool z)     //建構函數
        {
            ProductName = name;
            ProductPrice = price;
            int y = 0;
            z = int.TryParse( price , out y );
        }

    }
    partial class NewClass
    {
        private void FatCat1() 
        {
            MessageBox.Show("Private, FatCat1. ");
        }
        public void FatCat2()
        {
            MessageBox.Show("Public, FatCat2. ");
        }

        void FatCat3()
        {
            MessageBox.Show("Nothing, FatCat3. ");
        }

        internal void FatCat4()
        {
            MessageBox.Show("Internal, FatCat4. ");
        }
        public void FatCat5()
        {
            FatCat1();
            FatCat3();
        }

        
    }
}
