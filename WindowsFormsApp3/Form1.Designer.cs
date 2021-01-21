namespace WindowsFormsApp3
{
    partial class Form1
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
            this.nama = new System.Windows.Forms.Label();
            this.wontbecoded = new System.Windows.Forms.Label();
            this.makanan = new System.Windows.Forms.RadioButton();
            this.minuman = new System.Windows.Forms.RadioButton();
            this.textnama = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.listawal = new System.Windows.Forms.ListBox();
            this.listpilihan = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Location = new System.Drawing.Point(12, 20);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(58, 13);
            this.nama.TabIndex = 0;
            this.nama.Text = "Nama Item";
            // 
            // wontbecoded
            // 
            this.wontbecoded.AutoSize = true;
            this.wontbecoded.Location = new System.Drawing.Point(12, 85);
            this.wontbecoded.Name = "wontbecoded";
            this.wontbecoded.Size = new System.Drawing.Size(46, 13);
            this.wontbecoded.TabIndex = 1;
            this.wontbecoded.Text = "Kategori";
            // 
            // makanan
            // 
            this.makanan.AutoSize = true;
            this.makanan.Location = new System.Drawing.Point(332, 85);
            this.makanan.Name = "makanan";
            this.makanan.Size = new System.Drawing.Size(70, 17);
            this.makanan.TabIndex = 2;
            this.makanan.TabStop = true;
            this.makanan.Text = "Makanan";
            this.makanan.UseVisualStyleBackColor = true;
            this.makanan.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // minuman
            // 
            this.minuman.AutoSize = true;
            this.minuman.Location = new System.Drawing.Point(724, 85);
            this.minuman.Name = "minuman";
            this.minuman.Size = new System.Drawing.Size(68, 17);
            this.minuman.TabIndex = 3;
            this.minuman.TabStop = true;
            this.minuman.Text = "Minuman";
            this.minuman.UseVisualStyleBackColor = true;
            this.minuman.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // textnama
            // 
            this.textnama.Location = new System.Drawing.Point(151, 20);
            this.textnama.Name = "textnama";
            this.textnama.Size = new System.Drawing.Size(993, 20);
            this.textnama.TabIndex = 4;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(524, 117);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(75, 23);
            this.input.TabIndex = 5;
            this.input.Text = "INPUT";
            this.input.UseVisualStyleBackColor = true;
            this.input.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(549, 241);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(75, 23);
            this.buttonadd.TabIndex = 6;
            this.buttonadd.Text = ">";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(549, 291);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(75, 23);
            this.buttondelete.TabIndex = 7;
            this.buttondelete.Text = "X";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // listawal
            // 
            this.listawal.FormattingEnabled = true;
            this.listawal.Location = new System.Drawing.Point(62, 169);
            this.listawal.Name = "listawal";
            this.listawal.Size = new System.Drawing.Size(432, 407);
            this.listawal.TabIndex = 8;
            // 
            // listpilihan
            // 
            this.listpilihan.FormattingEnabled = true;
            this.listpilihan.Location = new System.Drawing.Point(673, 170);
            this.listpilihan.Name = "listpilihan";
            this.listpilihan.Size = new System.Drawing.Size(454, 407);
            this.listpilihan.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 589);
            this.Controls.Add(this.listpilihan);
            this.Controls.Add(this.listawal);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.input);
            this.Controls.Add(this.textnama);
            this.Controls.Add(this.minuman);
            this.Controls.Add(this.makanan);
            this.Controls.Add(this.wontbecoded);
            this.Controls.Add(this.nama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label wontbecoded;
        private System.Windows.Forms.RadioButton makanan;
        private System.Windows.Forms.RadioButton minuman;
        private System.Windows.Forms.TextBox textnama;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.ListBox listawal;
        private System.Windows.Forms.ListBox listpilihan;
    }
}

