namespace Form_Lab
{
    partial class Form_累加
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
            this.but_more = new System.Windows.Forms.Button();
            this.lab_num = new System.Windows.Forms.Label();
            this.but_back = new System.Windows.Forms.Button();
            this.gb_static = new System.Windows.Forms.GroupBox();
            this.but_static = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gb_static.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_more
            // 
            this.but_more.Location = new System.Drawing.Point(12, 92);
            this.but_more.Name = "but_more";
            this.but_more.Size = new System.Drawing.Size(143, 90);
            this.but_more.TabIndex = 0;
            this.but_more.Text = "累加";
            this.but_more.UseVisualStyleBackColor = true;
            this.but_more.Click += new System.EventHandler(this.but_more_Click);
            // 
            // lab_num
            // 
            this.lab_num.AutoSize = true;
            this.lab_num.Location = new System.Drawing.Point(178, 26);
            this.lab_num.Name = "lab_num";
            this.lab_num.Size = new System.Drawing.Size(0, 12);
            this.lab_num.TabIndex = 1;
            // 
            // but_back
            // 
            this.but_back.Location = new System.Drawing.Point(214, 93);
            this.but_back.Name = "but_back";
            this.but_back.Size = new System.Drawing.Size(164, 88);
            this.but_back.TabIndex = 2;
            this.but_back.Text = "後加";
            this.but_back.UseVisualStyleBackColor = true;
            this.but_back.Click += new System.EventHandler(this.but_back_Click);
            // 
            // gb_static
            // 
            this.gb_static.Controls.Add(this.button2);
            this.gb_static.Controls.Add(this.but_static);
            this.gb_static.Location = new System.Drawing.Point(444, 85);
            this.gb_static.Name = "gb_static";
            this.gb_static.Size = new System.Drawing.Size(319, 97);
            this.gb_static.TabIndex = 3;
            this.gb_static.TabStop = false;
            this.gb_static.Text = "static";
            // 
            // but_static
            // 
            this.but_static.Location = new System.Drawing.Point(39, 31);
            this.but_static.Name = "but_static";
            this.but_static.Size = new System.Drawing.Size(105, 43);
            this.but_static.TabIndex = 0;
            this.but_static.Text = "static";
            this.but_static.UseVisualStyleBackColor = true;
            this.but_static.Click += new System.EventHandler(this.but_static_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_累加
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_static);
            this.Controls.Add(this.but_back);
            this.Controls.Add(this.lab_num);
            this.Controls.Add(this.but_more);
            this.Name = "Form_累加";
            this.Text = "Form_累加";
            this.gb_static.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_more;
        private System.Windows.Forms.Label lab_num;
        private System.Windows.Forms.Button but_back;
        private System.Windows.Forms.GroupBox gb_static;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button but_static;
    }
}