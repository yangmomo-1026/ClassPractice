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
    public partial class Form_22 : Form
    {
        public Form_22()
        {
            InitializeComponent();
        }

        bool change = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (change == true)
            {
                button1.BackColor = Color.DarkOrchid;
            }
            else
            {
                button1.BackColor = Color.Orange;
            }
            change = !change;
        }

        bool change2 = true;
        private void button2_Click(object sender, EventArgs e)
        {
           button2.BackColor = change2 ? Color.Bisque : Color.DarkRed;
           change2 = !change2;
        }

        bool x;
        int score;
        private void btn_score_Click(object sender, EventArgs e)
        {

            int score;
            x = int.TryParse(tb_score.Text , out score);
            if (x)
            {
                if (score <= 100 && score >= 90)
                    label_score.Text = "A";
                else if (score < 90 && score >= 80)
                    label_score.Text = "B";
                else if (score < 80 && score >= 70)
                    label_score.Text = "C";
                else if (score < 70 && score >= 60)
                    label_score.Text = "D";
                else
                    label_score.Text = "E";
            }
            else
            {
                MessageBox.Show("輸入錯誤");
                return;
            }
        }

        private void btn_switch_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("你的名字是XXX?", "your name?", MessageBoxButtons.YesNoCancel);
            switch (result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("yes");
                    break;
                case DialogResult.No:
                    MessageBox.Show("NO");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("cancle");
                    break;
            }
        }

        private void btn_while_Click(object sender, EventArgs e)
        {
            int i = 0;
            string result = "";
            while (i <= 10)
            {
                result += i+ "\n";
                i++;
            }
            MessageBox.Show(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = 0;
            string y= "";
            do
            { y += x + "\n";
                x++;
            } while (x <= 10);
            MessageBox.Show(y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x, y;
            string z = "";
            for (x = 0 , y = 10; y >= 0 && x <=10; x++ , y --)
            {
                z += y + " , " + x + "\n";
            }
            MessageBox.Show(z);
        }
    }
}
