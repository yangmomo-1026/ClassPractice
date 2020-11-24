

namespace Form_Lab
{
    partial class NewClass
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
            this.button_open_cat = new System.Windows.Forms.Button();
            this.button_cat_talk = new System.Windows.Forms.Button();
            this.button_age = new System.Windows.Forms.Button();
            this.button_FatCat = new System.Windows.Forms.Button();
            this.button_FATCAT_封裝 = new System.Windows.Forms.Button();
            this.button_PartialClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_open_cat
            // 
            this.button_open_cat.Location = new System.Drawing.Point(23, 21);
            this.button_open_cat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_open_cat.Name = "button_open_cat";
            this.button_open_cat.Size = new System.Drawing.Size(119, 72);
            this.button_open_cat.TabIndex = 0;
            this.button_open_cat.Text = "打開貓貓";
            this.button_open_cat.UseVisualStyleBackColor = true;
            // 
            // button_cat_talk
            // 
            this.button_cat_talk.Location = new System.Drawing.Point(157, 21);
            this.button_cat_talk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_cat_talk.Name = "button_cat_talk";
            this.button_cat_talk.Size = new System.Drawing.Size(119, 72);
            this.button_cat_talk.TabIndex = 1;
            this.button_cat_talk.Text = "貓貓說話";
            this.button_cat_talk.UseVisualStyleBackColor = true;
            // 
            // button_age
            // 
            this.button_age.Location = new System.Drawing.Point(288, 21);
            this.button_age.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_age.Name = "button_age";
            this.button_age.Size = new System.Drawing.Size(119, 72);
            this.button_age.TabIndex = 2;
            this.button_age.Text = "暴露年齡";
            this.button_age.UseVisualStyleBackColor = true;
            // 
            // button_FatCat
            // 
            this.button_FatCat.Location = new System.Drawing.Point(23, 117);
            this.button_FatCat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_FatCat.Name = "button_FatCat";
            this.button_FatCat.Size = new System.Drawing.Size(119, 72);
            this.button_FatCat.TabIndex = 3;
            this.button_FatCat.Text = "測試存取";
            this.button_FatCat.UseVisualStyleBackColor = true;
            this.button_FatCat.Click += new System.EventHandler(this.button_FatCat_Click);
            // 
            // button_FATCAT_封裝
            // 
            this.button_FATCAT_封裝.Location = new System.Drawing.Point(157, 117);
            this.button_FATCAT_封裝.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_FATCAT_封裝.Name = "button_FATCAT_封裝";
            this.button_FATCAT_封裝.Size = new System.Drawing.Size(119, 72);
            this.button_FATCAT_封裝.TabIndex = 4;
            this.button_FATCAT_封裝.Text = "測試封裝";
            this.button_FATCAT_封裝.UseVisualStyleBackColor = true;
            // 
            // button_PartialClass
            // 
            this.button_PartialClass.Location = new System.Drawing.Point(288, 117);
            this.button_PartialClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_PartialClass.Name = "button_PartialClass";
            this.button_PartialClass.Size = new System.Drawing.Size(119, 72);
            this.button_PartialClass.TabIndex = 5;
            this.button_PartialClass.Text = "Partial Class";
            this.button_PartialClass.UseVisualStyleBackColor = true;
            // 
            // NewClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 300);
            this.Controls.Add(this.button_PartialClass);
            this.Controls.Add(this.button_FATCAT_封裝);
            this.Controls.Add(this.button_FatCat);
            this.Controls.Add(this.button_age);
            this.Controls.Add(this.button_cat_talk);
            this.Controls.Add(this.button_open_cat);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewClass";
            this.Text = "Form_open_cat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_open_cat;
        private System.Windows.Forms.Button button_cat_talk;
        private System.Windows.Forms.Button button_age;
        private System.Windows.Forms.Button button_FatCat;
        private System.Windows.Forms.Button button_FATCAT_封裝;
        private System.Windows.Forms.Button button_PartialClass;

    }
}