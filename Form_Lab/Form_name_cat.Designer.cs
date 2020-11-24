namespace Form_Lab
{
    partial class Form_name_cat
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_name_cat));
            this.button_name = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.labe_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_name
            // 
            this.button_name.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_name.Location = new System.Drawing.Point(239, 223);
            this.button_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_name.Name = "button_name";
            this.button_name.Size = new System.Drawing.Size(129, 55);
            this.button_name.TabIndex = 0;
            this.button_name.Text = "按鈕";
            this.button_name.UseVisualStyleBackColor = true;
            this.button_name.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(239, 192);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(130, 22);
            this.textBox_name.TabIndex = 1;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // labe_name
            // 
            this.labe_name.AutoSize = true;
            this.labe_name.BackColor = System.Drawing.Color.Transparent;
            this.labe_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe_name.Location = new System.Drawing.Point(236, 164);
            this.labe_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labe_name.Name = "labe_name";
            this.labe_name.Size = new System.Drawing.Size(53, 17);
            this.labe_name.TabIndex = 2;
            this.labe_name.Text = "名字：";
            // 
            // Form_name_cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(388, 291);
            this.Controls.Add(this.labe_name);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_name);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_name_cat";
            this.Text = "Form_cat";
            this.Load += new System.EventHandler(this.Form_name_cat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label labe_name;
    }
}

