
namespace SınavProje
{
    partial class GirisForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ogrenciglbl = new System.Windows.Forms.Label();
            this.ogretmenglbl = new System.Windows.Forms.Label();
            this.GirisBilgilbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ogrenciglbl
            // 
            this.ogrenciglbl.BackColor = System.Drawing.Color.Firebrick;
            this.ogrenciglbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ogrenciglbl.Location = new System.Drawing.Point(154, 373);
            this.ogrenciglbl.Name = "ogrenciglbl";
            this.ogrenciglbl.Size = new System.Drawing.Size(149, 61);
            this.ogrenciglbl.TabIndex = 0;
            this.ogrenciglbl.Text = "Öğrenci Giriş";
            this.ogrenciglbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ogrenciglbl.Click += new System.EventHandler(this.ogrencibtn_Click);
            // 
            // ogretmenglbl
            // 
            this.ogretmenglbl.BackColor = System.Drawing.Color.Firebrick;
            this.ogretmenglbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ogretmenglbl.Location = new System.Drawing.Point(572, 373);
            this.ogretmenglbl.Name = "ogretmenglbl";
            this.ogretmenglbl.Size = new System.Drawing.Size(149, 61);
            this.ogretmenglbl.TabIndex = 1;
            this.ogretmenglbl.Text = "Öğretmen Giriş";
            this.ogretmenglbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ogretmenglbl.Click += new System.EventHandler(this.ogretmenglbl_Click);
            // 
            // GirisBilgilbl
            // 
            this.GirisBilgilbl.BackColor = System.Drawing.Color.SlateBlue;
            this.GirisBilgilbl.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisBilgilbl.Location = new System.Drawing.Point(255, 208);
            this.GirisBilgilbl.Name = "GirisBilgilbl";
            this.GirisBilgilbl.Size = new System.Drawing.Size(375, 114);
            this.GirisBilgilbl.TabIndex = 2;
            this.GirisBilgilbl.Text = "Sınav sistemi giriş ekranına hoş geldiniz.\r\nlütfen size uygun seçeneği seçiniz.";
            this.GirisBilgilbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SınavProje.Properties.Resources.exam;
            this.pictureBox1.Location = new System.Drawing.Point(336, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(870, 529);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GirisBilgilbl);
            this.Controls.Add(this.ogretmenglbl);
            this.Controls.Add(this.ogrenciglbl);
            this.Name = "GirisForm";
            this.Text = "Sınav Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ogrenciglbl;
        private System.Windows.Forms.Label ogretmenglbl;
        private System.Windows.Forms.Label GirisBilgilbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

