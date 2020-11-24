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
    public partial class Form_18_enum : Form
    {
        public Form_18_enum()
        {
            InitializeComponent();
        }

        private void but_menu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("名稱: "+lodinrole.admin +"\n"+"數值: "+(int)lodinrole.admin);
        }

        private void but_admin_Click(object sender, EventArgs e)
        {
            int a = 1;
            if (a == 1)
            {
                but_menu.Enabled = true;
            }
            else
            {
                but_menu.Enabled = false;
                MessageBox.Show("驗證失敗");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            const int a = 1;
            const int b = 2;

            int x = 1;

            if (x == a)
            {
                but_menu.Enabled = true;
            }
            else
            {
                but_menu.Enabled = false;
                MessageBox.Show("驗證失敗");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lodinrole roler = lodinrole.user;   //驗證失敗
     //lodinrole roler = lodinrole.admin;    //驗證成功

            //陣列跟陣列判斷
            if ( roler == lodinrole.admin)
            {
                but_menu.Enabled = true;
            }
            else
            {
                but_menu.Enabled = false;
                MessageBox.Show("驗證失敗");
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lodinrole roler = lodinrole.admin;

            switch (roler)
            {
                case lodinrole.admin:
                    but_menu.Enabled = true;
                    break;
                case lodinrole.user:
                    but_menu.Enabled = false;
                    MessageBox.Show("驗證失敗");
                    break;
            }
        }
    }
}
