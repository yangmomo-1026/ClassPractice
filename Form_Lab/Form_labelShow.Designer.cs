namespace Form_Lab
{
    partial class Form_labelShow
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
            this.button_change = new System.Windows.Forms.Button();
            this.label_Show = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(537, 87);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(142, 89);
            this.button_change.TabIndex = 0;
            this.button_change.Text = "Change";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // label_Show
            // 
            this.label_Show.AutoSize = true;
            this.label_Show.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Show.Location = new System.Drawing.Point(348, 118);
            this.label_Show.Name = "label_Show";
            this.label_Show.Size = new System.Drawing.Size(102, 21);
            this.label_Show.TabIndex = 1;
            this.label_Show.Text = "labelShow";
            // 
            // Form_labelShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Show);
            this.Controls.Add(this.button_change);
            this.Name = "Form_labelShow";
            this.Text = "Form_labelShow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Label label_Show;
    }
}