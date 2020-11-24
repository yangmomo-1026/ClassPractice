namespace Form_Lab
{
    partial class Form_18_enum
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
            this.but_admin = new System.Windows.Forms.Button();
            this.but_menu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_admin
            // 
            this.but_admin.Location = new System.Drawing.Point(84, 97);
            this.but_admin.Name = "but_admin";
            this.but_admin.Size = new System.Drawing.Size(93, 53);
            this.but_admin.TabIndex = 0;
            this.but_admin.Text = "驗證";
            this.but_admin.UseVisualStyleBackColor = true;
            this.but_admin.Click += new System.EventHandler(this.but_admin_Click);
            // 
            // but_menu
            // 
            this.but_menu.Enabled = false;
            this.but_menu.Location = new System.Drawing.Point(236, 97);
            this.but_menu.Name = "but_menu";
            this.but_menu.Size = new System.Drawing.Size(93, 53);
            this.but_menu.TabIndex = 1;
            this.but_menu.Text = "menu";
            this.but_menu.UseVisualStyleBackColor = true;
            this.but_menu.Click += new System.EventHandler(this.but_menu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "驗證2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "驗證3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(84, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 53);
            this.button3.TabIndex = 4;
            this.button3.Text = "驗證4";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form_18_enum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.but_menu);
            this.Controls.Add(this.but_admin);
            this.Name = "Form_18_enum";
            this.Text = "Form_18_enum";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_admin;
        private System.Windows.Forms.Button but_menu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}