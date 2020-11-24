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
    public partial class Form_member : Form
    {
        public Form_member()
        {
            InitializeComponent();
        }

        private void button_member_Click(object sender, EventArgs e)
        {
            Class_member MEME = new Class_member();
            MEME.Name = "MEME";
            MEME.Age = 20;

            //string Member = "會員名字：" + MEME.Name + "/n會員年齡" + MEME.Age ;
            //MessageBox.Show( Member );

            Class_member YOYO = new Class_member()
            {
                Name="YOYO",
                Age=22,
            };

            string Member = "會員名字:" + YOYO.Name + "\n會員年齡" + YOYO.Age;
            string Member_2 = Member + "\n----------\n會員名字:" + MEME.Name + "\n會員年齡" + MEME.Age;

            MessageBox.Show(Member_2);

        }

        
    }
}
