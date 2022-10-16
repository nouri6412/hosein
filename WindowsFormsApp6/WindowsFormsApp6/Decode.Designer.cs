namespace WindowsFormsApp6
{
    partial class Decode
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_product = new System.Windows.Forms.Label();
            this.txt_shift = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Decode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "کد محصول";
            // 
            // txt_product
            // 
            this.txt_product.AutoSize = true;
            this.txt_product.Location = new System.Drawing.Point(207, 138);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(56, 13);
            this.txt_product.TabIndex = 4;
            this.txt_product.Text = "کد محصول";
            // 
            // txt_shift
            // 
            this.txt_shift.AutoSize = true;
            this.txt_shift.Location = new System.Drawing.Point(207, 166);
            this.txt_shift.Name = "txt_shift";
            this.txt_shift.Size = new System.Drawing.Size(33, 13);
            this.txt_shift.TabIndex = 6;
            this.txt_shift.Text = "شیفت";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "شیفت";
            // 
            // txt_date
            // 
            this.txt_date.AutoSize = true;
            this.txt_date.Location = new System.Drawing.Point(207, 189);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(32, 13);
            this.txt_date.TabIndex = 8;
            this.txt_date.Text = "تاریخ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "تاریخ";
            // 
            // Decode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 348);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_shift);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_product);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Decode";
            this.Text = "Decode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_product;
        private System.Windows.Forms.Label txt_shift;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt_date;
        private System.Windows.Forms.Label label7;
    }
}