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
    partial class NewClass:Form                                                          //合併編輯的概念吧，要放在namespace下面
    {
        public void FatCat6()
        {
            MessageBox.Show("Partial Class!! ");             
        }

        private void button_FatCat_Click(object sender, EventArgs e)
        {

        }
    }
    public partial class Form_open_cat : Form
    {
        public Form_open_cat()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void button_open_cat_Click(object sender, EventArgs e)
        {
            Form_name_cat myclass = new Form_name_cat();
            myclass.Show();
        }

        private void Form_open_cat_Load(object sender, EventArgs e)
        {

        }

        private void button_cat_talk_Click(object sender, EventArgs e)      //沒有回傳值的方法
        {
            cat_interduse();
        }
        void cat_interduse()
        {
            string Name = "Small Black";
            MessageBox.Show(Name + " is my cat !");
        }

        private void button_age_Click(object sender, EventArgs e)     //有回傳值的方法
        {
            int Y =YearAge(23);                                                                       //定義變數一定要記得設定型態
            MessageBox.Show(Y.ToString());                                              //MessageBox.Show只吃字串，整數要轉
        }

        int YearAge(int Age) 
        {
            int x = DateTime.Now.Year - Age;
            return x;
        }

        
        private void button_FatCat_Click(object sender, EventArgs e)
        {
            NewClass CAT = new NewClass();
            //CAT.FatCat1();
            CAT.FatCat2();
            //CAT.FatCat3();
            CAT.FatCat4();
           
        }

        private void button_FATCAT_封裝_Click(object sender, EventArgs e)
        {
            NewClass CAT = new NewClass();
            CAT.FatCat5();
        }

        private void button_PartialClass_Click(object sender, EventArgs e)
        {
            NewClass CAT = new NewClass();
            CAT.FatCat6();
        }
    }
}

