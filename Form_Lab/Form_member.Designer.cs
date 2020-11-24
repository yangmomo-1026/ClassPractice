namespace Form_Lab
{
    partial class Form_member
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
            this.button_member = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_member
            // 
            this.button_member.Location = new System.Drawing.Point(319, 43);
            this.button_member.Name = "button_member";
            this.button_member.Size = new System.Drawing.Size(124, 87);
            this.button_member.TabIndex = 0;
            this.button_member.Text = "button_member";
            this.button_member.UseVisualStyleBackColor = true;
            this.button_member.Click += new System.EventHandler(this.button_member_Click);
            // 
            // Form_member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_member);
            this.Name = "Form_member";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_member;
    }
}