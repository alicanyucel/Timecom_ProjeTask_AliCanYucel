namespace Timecom_ProjeTask_AliCanYucel
{
    partial class Personeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personeller));
            this.btnPersonelAra = new System.Windows.Forms.Button();
            this.btnPersonelDuzenle = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGeriGel = new System.Windows.Forms.Button();
            this.btnHesaplamayaGit = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersonelAra
            // 
            this.btnPersonelAra.Location = new System.Drawing.Point(114, 387);
            this.btnPersonelAra.Name = "btnPersonelAra";
            this.btnPersonelAra.Size = new System.Drawing.Size(75, 23);
            this.btnPersonelAra.TabIndex = 0;
            this.btnPersonelAra.Text = "Personel Ara";
            this.btnPersonelAra.UseVisualStyleBackColor = true;
            // 
            // btnPersonelDuzenle
            // 
            this.btnPersonelDuzenle.Location = new System.Drawing.Point(321, 387);
            this.btnPersonelDuzenle.Name = "btnPersonelDuzenle";
            this.btnPersonelDuzenle.Size = new System.Drawing.Size(117, 23);
            this.btnPersonelDuzenle.TabIndex = 1;
            this.btnPersonelDuzenle.Text = "Personel Düzenle";
            this.btnPersonelDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(209, 387);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(75, 23);
            this.btnYeniKayit.TabIndex = 2;
            this.btnYeniKayit.Text = "Yeni Kayit";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(462, 387);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGeriGel
            // 
            this.btnGeriGel.Location = new System.Drawing.Point(597, 387);
            this.btnGeriGel.Name = "btnGeriGel";
            this.btnGeriGel.Size = new System.Drawing.Size(75, 23);
            this.btnGeriGel.TabIndex = 4;
            this.btnGeriGel.Text = "Geri Gel";
            this.btnGeriGel.UseVisualStyleBackColor = true;
            this.btnGeriGel.Click += new System.EventHandler(this.btnGeriGel_Click);
            // 
            // btnHesaplamayaGit
            // 
            this.btnHesaplamayaGit.Location = new System.Drawing.Point(743, 387);
            this.btnHesaplamayaGit.Name = "btnHesaplamayaGit";
            this.btnHesaplamayaGit.Size = new System.Drawing.Size(114, 23);
            this.btnHesaplamayaGit.TabIndex = 5;
            this.btnHesaplamayaGit.Text = "Hesaplamaya Git";
            this.btnHesaplamayaGit.UseVisualStyleBackColor = true;
            this.btnHesaplamayaGit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Location = new System.Drawing.Point(13, 387);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(75, 23);
            this.btnAnaSayfa.TabIndex = 6;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // Personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.btnHesaplamayaGit);
            this.Controls.Add(this.btnGeriGel);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.btnPersonelDuzenle);
            this.Controls.Add(this.btnPersonelAra);
            this.Name = "Personeller";
            this.Text = "Timecom Personeller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonelAra;
        private System.Windows.Forms.Button btnPersonelDuzenle;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGeriGel;
        private System.Windows.Forms.Button btnHesaplamayaGit;
        private System.Windows.Forms.Button btnAnaSayfa;
    }
}