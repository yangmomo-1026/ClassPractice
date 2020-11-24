namespace Form_Lab
{
    partial class Form_26_arry
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
            this.btn_arry = new System.Windows.Forms.Button();
            this.btn_arry_2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_arry
            // 
            this.btn_arry.Location = new System.Drawing.Point(38, 65);
            this.btn_arry.Name = "btn_arry";
            this.btn_arry.Size = new System.Drawing.Size(147, 70);
            this.btn_arry.TabIndex = 0;
            this.btn_arry.Text = "一維陣列";
            this.btn_arry.UseVisualStyleBackColor = true;
            this.btn_arry.Click += new System.EventHandler(this.btn_arry_Click);
            // 
            // btn_arry_2
            // 
            this.btn_arry_2.Location = new System.Drawing.Point(38, 160);
            this.btn_arry_2.Name = "btn_arry_2";
            this.btn_arry_2.Size = new System.Drawing.Size(147, 70);
            this.btn_arry_2.TabIndex = 1;
            this.btn_arry_2.Text = "二維陣列";
            this.btn_arry_2.UseVisualStyleBackColor = true;
            this.btn_arry_2.Click += new System.EventHandler(this.btn_arry_2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "類別陣列";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 70);
            this.button2.TabIndex = 3;
            this.button2.Text = "陣列取值";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_26_arry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_arry_2);
            this.Controls.Add(this.btn_arry);
            this.Name = "Form_26_arry";
            this.Text = "Form_26_arry";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_arry;
        private System.Windows.Forms.Button btn_arry_2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}