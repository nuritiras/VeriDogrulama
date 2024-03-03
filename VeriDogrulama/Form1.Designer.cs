namespace VeriDogrulama
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNumara = new System.Windows.Forms.TextBox();
            this.textAdSoyad = new System.Windows.Forms.TextBox();
            this.textDersNotu = new System.Windows.Forms.TextBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ders Notu";
            // 
            // textNumara
            // 
            this.textNumara.Location = new System.Drawing.Point(113, 22);
            this.textNumara.Name = "textNumara";
            this.textNumara.Size = new System.Drawing.Size(100, 20);
            this.textNumara.TabIndex = 3;
            this.textNumara.Validating += new System.ComponentModel.CancelEventHandler(this.textNumara_Validating);
            // 
            // textAdSoyad
            // 
            this.textAdSoyad.Location = new System.Drawing.Point(113, 53);
            this.textAdSoyad.Name = "textAdSoyad";
            this.textAdSoyad.Size = new System.Drawing.Size(206, 20);
            this.textAdSoyad.TabIndex = 4;
            this.textAdSoyad.Validating += new System.ComponentModel.CancelEventHandler(this.textAdSoyad_Validating);
            // 
            // textDersNotu
            // 
            this.textDersNotu.Location = new System.Drawing.Point(113, 80);
            this.textDersNotu.Name = "textDersNotu";
            this.textDersNotu.Size = new System.Drawing.Size(100, 20);
            this.textDersNotu.TabIndex = 5;
            this.textDersNotu.Validating += new System.ComponentModel.CancelEventHandler(this.textDersNotu_Validating);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(138, 123);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(75, 23);
            this.buttonKaydet.TabIndex = 6;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 164);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.textDersNotu);
            this.Controls.Add(this.textAdSoyad);
            this.Controls.Add(this.textNumara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Veri Doğrulama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNumara;
        private System.Windows.Forms.TextBox textAdSoyad;
        private System.Windows.Forms.TextBox textDersNotu;
        private System.Windows.Forms.Button buttonKaydet;
    }
}

