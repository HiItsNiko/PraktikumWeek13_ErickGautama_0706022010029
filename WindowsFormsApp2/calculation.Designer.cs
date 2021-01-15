namespace WindowsFormsApp2
{
    partial class calculation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Subtotal = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Discountbox = new System.Windows.Forms.CheckBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Discount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total:";
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Location = new System.Drawing.Point(505, 34);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(13, 13);
            this.Subtotal.TabIndex = 4;
            this.Subtotal.Text = "0";
            // 
            // Tax
            // 
            this.Tax.AutoSize = true;
            this.Tax.Location = new System.Drawing.Point(505, 84);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(13, 13);
            this.Tax.TabIndex = 5;
            this.Tax.Text = "0";
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Location = new System.Drawing.Point(505, 136);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(13, 13);
            this.Discount.TabIndex = 6;
            this.Discount.Text = "0";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(505, 209);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(13, 13);
            this.Total.TabIndex = 7;
            this.Total.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "%";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Input";
            // 
            // Discountbox
            // 
            this.Discountbox.AutoSize = true;
            this.Discountbox.Location = new System.Drawing.Point(39, 46);
            this.Discountbox.Name = "Discountbox";
            this.Discountbox.Size = new System.Drawing.Size(68, 17);
            this.Discountbox.TabIndex = 11;
            this.Discountbox.Text = "Discount";
            this.Discountbox.UseVisualStyleBackColor = true;
            this.Discountbox.CheckedChanged += new System.EventHandler(this.Discountbox_CheckedChanged);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(23, 125);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(224, 106);
            this.Calculate.TabIndex = 12;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // calculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Discountbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.Subtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "calculation";
            this.Text = "calculation";
            this.Load += new System.EventHandler(this.calculation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Discountbox;
        private System.Windows.Forms.Button Calculate;
    }
}