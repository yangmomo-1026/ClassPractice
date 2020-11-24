namespace Form_Lab
{
    partial class Frm_15_CTS
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
            this.but_valuetype = new System.Windows.Forms.Button();
            this.but_go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_valuetype
            // 
            this.but_valuetype.Location = new System.Drawing.Point(40, 55);
            this.but_valuetype.Name = "but_valuetype";
            this.but_valuetype.Size = new System.Drawing.Size(140, 81);
            this.but_valuetype.TabIndex = 0;
            this.but_valuetype.Text = "Value Type";
            this.but_valuetype.UseVisualStyleBackColor = true;
            this.but_valuetype.Click += new System.EventHandler(this.but_valuetype_Click);
            // 
            // but_go
            // 
            this.but_go.Location = new System.Drawing.Point(258, 55);
            this.but_go.Name = "but_go";
            this.but_go.Size = new System.Drawing.Size(216, 81);
            this.but_go.TabIndex = 1;
            this.but_go.Text = "指向";
            this.but_go.UseVisualStyleBackColor = true;
            this.but_go.Click += new System.EventHandler(this.but_go_Click);
            // 
            // Frm_15_CTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_go);
            this.Controls.Add(this.but_valuetype);
            this.Name = "Frm_15_CTS";
            this.Text = "Frm_15_CTS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_valuetype;
        private System.Windows.Forms.Button but_go;
    }
}