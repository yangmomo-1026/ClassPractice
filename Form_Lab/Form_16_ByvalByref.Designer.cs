namespace Form_Lab
{
    partial class Form_16_ByvalByref
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
            this.but_val = new System.Windows.Forms.Button();
            this.but_ref = new System.Windows.Forms.Button();
            this.but_reff = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_val
            // 
            this.but_val.Location = new System.Drawing.Point(86, 61);
            this.but_val.Name = "but_val";
            this.but_val.Size = new System.Drawing.Size(110, 65);
            this.but_val.TabIndex = 0;
            this.but_val.Text = "By Val";
            this.but_val.UseVisualStyleBackColor = true;
            this.but_val.Click += new System.EventHandler(this.but_val_Click);
            // 
            // but_ref
            // 
            this.but_ref.Location = new System.Drawing.Point(231, 61);
            this.but_ref.Name = "but_ref";
            this.but_ref.Size = new System.Drawing.Size(110, 65);
            this.but_ref.TabIndex = 1;
            this.but_ref.Text = "By Ref";
            this.but_ref.UseVisualStyleBackColor = true;
            this.but_ref.Click += new System.EventHandler(this.but_ref_Click);
            // 
            // but_reff
            // 
            this.but_reff.Location = new System.Drawing.Point(373, 61);
            this.but_reff.Name = "but_reff";
            this.but_reff.Size = new System.Drawing.Size(110, 65);
            this.but_reff.TabIndex = 2;
            this.but_reff.Text = "By Ref 強制";
            this.but_reff.UseVisualStyleBackColor = true;
            this.but_reff.Click += new System.EventHandler(this.but_reff_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "out參數";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_16_ByvalByref
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.but_reff);
            this.Controls.Add(this.but_ref);
            this.Controls.Add(this.but_val);
            this.Name = "Form_16_ByvalByref";
            this.Text = "Form_16_ByvalByref";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_val;
        private System.Windows.Forms.Button but_ref;
        private System.Windows.Forms.Button but_reff;
        private System.Windows.Forms.Button button1;
    }
}