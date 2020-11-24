namespace Form_Lab
{
    partial class Form08_click
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
            this.button_click01 = new System.Windows.Forms.Button();
            this.button_click02 = new System.Windows.Forms.Button();
            this.button_click03 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_click01
            // 
            this.button_click01.Location = new System.Drawing.Point(36, 26);
            this.button_click01.Name = "button_click01";
            this.button_click01.Size = new System.Drawing.Size(145, 74);
            this.button_click01.TabIndex = 0;
            this.button_click01.Text = "button_click01";
            this.button_click01.UseVisualStyleBackColor = true;
            this.button_click01.Click += new System.EventHandler(this.button_click01_Click);
            // 
            // button_click02
            // 
            this.button_click02.Location = new System.Drawing.Point(37, 125);
            this.button_click02.Name = "button_click02";
            this.button_click02.Size = new System.Drawing.Size(143, 86);
            this.button_click02.TabIndex = 1;
            this.button_click02.Text = "button_click02";
            this.button_click02.UseVisualStyleBackColor = true;
            // 
            // button_click03
            // 
            this.button_click03.Location = new System.Drawing.Point(38, 240);
            this.button_click03.Name = "button_click03";
            this.button_click03.Size = new System.Drawing.Size(142, 87);
            this.button_click03.TabIndex = 2;
            this.button_click03.Text = "button_click03";
            this.button_click03.UseVisualStyleBackColor = true;
            // 
            // Form08_click
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_click03);
            this.Controls.Add(this.button_click02);
            this.Controls.Add(this.button_click01);
            this.Name = "Form08_click";
            this.Text = "Form08_click";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_click01;
        private System.Windows.Forms.Button button_click02;
        private System.Windows.Forms.Button button_click03;
    }
}