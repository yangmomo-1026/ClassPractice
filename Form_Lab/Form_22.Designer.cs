﻿namespace Form_Lab
{
    partial class Form_22
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_score = new System.Windows.Forms.Button();
            this.tb_score = new System.Windows.Forms.TextBox();
            this.label_score = new System.Windows.Forms.Label();
            this.btn_switch = new System.Windows.Forms.Button();
            this.btn_while = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(28, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "btn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(201, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 79);
            this.button2.TabIndex = 1;
            this.button2.Text = "btn2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_score
            // 
            this.btn_score.Location = new System.Drawing.Point(512, 265);
            this.btn_score.Name = "btn_score";
            this.btn_score.Size = new System.Drawing.Size(138, 48);
            this.btn_score.TabIndex = 2;
            this.btn_score.Text = "輸入級數";
            this.btn_score.UseVisualStyleBackColor = true;
            this.btn_score.Click += new System.EventHandler(this.btn_score_Click);
            // 
            // tb_score
            // 
            this.tb_score.Location = new System.Drawing.Point(585, 227);
            this.tb_score.Name = "tb_score";
            this.tb_score.Size = new System.Drawing.Size(137, 22);
            this.tb_score.TabIndex = 3;
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Location = new System.Drawing.Point(635, 199);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(29, 12);
            this.label_score.TabIndex = 4;
            this.label_score.Text = "級數";
            // 
            // btn_switch
            // 
            this.btn_switch.Location = new System.Drawing.Point(512, 319);
            this.btn_switch.Name = "btn_switch";
            this.btn_switch.Size = new System.Drawing.Size(136, 48);
            this.btn_switch.TabIndex = 5;
            this.btn_switch.Text = "seitch";
            this.btn_switch.UseVisualStyleBackColor = true;
            this.btn_switch.Click += new System.EventHandler(this.btn_switch_Click);
            // 
            // btn_while
            // 
            this.btn_while.Location = new System.Drawing.Point(511, 373);
            this.btn_while.Name = "btn_while";
            this.btn_while.Size = new System.Drawing.Size(136, 48);
            this.btn_while.TabIndex = 6;
            this.btn_while.Text = "while";
            this.btn_while.UseVisualStyleBackColor = true;
            this.btn_while.Click += new System.EventHandler(this.btn_while_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(656, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 48);
            this.button3.TabIndex = 7;
            this.button3.Text = "do";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(656, 319);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 48);
            this.button4.TabIndex = 8;
            this.button4.Text = "For";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form_22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_while);
            this.Controls.Add(this.btn_switch);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.tb_score);
            this.Controls.Add(this.btn_score);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form_22";
            this.Text = "Form_22";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_score;
        private System.Windows.Forms.TextBox tb_score;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Button btn_switch;
        private System.Windows.Forms.Button btn_while;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}