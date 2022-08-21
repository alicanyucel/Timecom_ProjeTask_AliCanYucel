namespace Timecom_ProjeTask_AliCanYucel
{
    partial class Hesaplamalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hesaplamalar));
            this.dtgHesaplamalar = new System.Windows.Forms.DataGridView();
            this.btnPersonelGetir = new System.Windows.Forms.Button();
            this.btnMaasHesaplat = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHesaplamalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgHesaplamalar
            // 
            this.dtgHesaplamalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHesaplamalar.Location = new System.Drawing.Point(12, 12);
            this.dtgHesaplamalar.Name = "dtgHesaplamalar";
            this.dtgHesaplamalar.Size = new System.Drawing.Size(766, 301);
            this.dtgHesaplamalar.TabIndex = 0;
            // 
            // btnPersonelGetir
            // 
            this.btnPersonelGetir.Location = new System.Drawing.Point(45, 383);
            this.btnPersonelGetir.Name = "btnPersonelGetir";
            this.btnPersonelGetir.Size = new System.Drawing.Size(116, 23);
            this.btnPersonelGetir.TabIndex = 1;
            this.btnPersonelGetir.Text = "Personelleri Getir";
            this.btnPersonelGetir.UseVisualStyleBackColor = true;
            // 
            // btnMaasHesaplat
            // 
            this.btnMaasHesaplat.Location = new System.Drawing.Point(227, 383);
            this.btnMaasHesaplat.Name = "btnMaasHesaplat";
            this.btnMaasHesaplat.Size = new System.Drawing.Size(101, 23);
            this.btnMaasHesaplat.TabIndex = 2;
            this.btnMaasHesaplat.Text = "Maaş Hesaplat";
            this.btnMaasHesaplat.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(429, 383);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(603, 383);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "Geri Gel";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // Hesaplamalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnMaasHesaplat);
            this.Controls.Add(this.btnPersonelGetir);
            this.Controls.Add(this.dtgHesaplamalar);
            this.Name = "Hesaplamalar";
            this.Text = "Timecom Hesaplamalar";
            this.Load += new System.EventHandler(this.Hesaplamalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHesaplamalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgHesaplamalar;
        private System.Windows.Forms.Button btnPersonelGetir;
        private System.Windows.Forms.Button btnMaasHesaplat;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGeri;
    }
}