
namespace SınavProje
{
    partial class ogretmenForm
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
            this.kaditxtbx = new System.Windows.Forms.TextBox();
            this.kadisifretxtbx = new System.Windows.Forms.TextBox();
            this.ogretmenBilgilbl = new System.Windows.Forms.Label();
            this.ogretmengbtn = new System.Windows.Forms.Button();
            this.ogretmenAEbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kaditxtbx
            // 
            this.kaditxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaditxtbx.Location = new System.Drawing.Point(415, 229);
            this.kaditxtbx.Name = "kaditxtbx";
            this.kaditxtbx.Size = new System.Drawing.Size(230, 34);
            this.kaditxtbx.TabIndex = 0;
            this.kaditxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kadisifretxtbx
            // 
            this.kadisifretxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kadisifretxtbx.Location = new System.Drawing.Point(415, 308);
            this.kadisifretxtbx.Name = "kadisifretxtbx";
            this.kadisifretxtbx.Size = new System.Drawing.Size(230, 34);
            this.kadisifretxtbx.TabIndex = 1;
            this.kadisifretxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ogretmenBilgilbl
            // 
            this.ogretmenBilgilbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ogretmenBilgilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogretmenBilgilbl.ForeColor = System.Drawing.Color.DarkGray;
            this.ogretmenBilgilbl.Location = new System.Drawing.Point(176, 86);
            this.ogretmenBilgilbl.Name = "ogretmenBilgilbl";
            this.ogretmenBilgilbl.Size = new System.Drawing.Size(523, 102);
            this.ogretmenBilgilbl.TabIndex = 2;
            this.ogretmenBilgilbl.Text = "Öğretmen giriş bilgilerinizi giriniz.";
            this.ogretmenBilgilbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ogretmengbtn
            // 
            this.ogretmengbtn.BackColor = System.Drawing.Color.Gray;
            this.ogretmengbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogretmengbtn.Location = new System.Drawing.Point(509, 388);
            this.ogretmengbtn.Name = "ogretmengbtn";
            this.ogretmengbtn.Size = new System.Drawing.Size(124, 56);
            this.ogretmengbtn.TabIndex = 3;
            this.ogretmengbtn.Text = "Giriş";
            this.ogretmengbtn.UseVisualStyleBackColor = false;
            this.ogretmengbtn.Click += new System.EventHandler(this.ogretmengbtn_Click);
            // 
            // ogretmenAEbtn
            // 
            this.ogretmenAEbtn.BackColor = System.Drawing.Color.Gray;
            this.ogretmenAEbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogretmenAEbtn.Location = new System.Drawing.Point(261, 388);
            this.ogretmenAEbtn.Name = "ogretmenAEbtn";
            this.ogretmenAEbtn.Size = new System.Drawing.Size(124, 56);
            this.ogretmenAEbtn.TabIndex = 8;
            this.ogretmenAEbtn.Text = "Ana Ekran";
            this.ogretmenAEbtn.UseVisualStyleBackColor = false;
            this.ogretmenAEbtn.Click += new System.EventHandler(this.ogretmenAEbtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(190, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Öğretmen Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(199, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şifre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ogretmenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(907, 549);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ogretmenAEbtn);
            this.Controls.Add(this.ogretmengbtn);
            this.Controls.Add(this.ogretmenBilgilbl);
            this.Controls.Add(this.kadisifretxtbx);
            this.Controls.Add(this.kaditxtbx);
            this.Name = "ogretmenForm";
            this.Text = "Öğretmen Giriş Ekranı";
            this.Load += new System.EventHandler(this.ogretmenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kaditxtbx;
        private System.Windows.Forms.TextBox kadisifretxtbx;
        private System.Windows.Forms.Label ogretmenBilgilbl;
        private System.Windows.Forms.Button ogretmengbtn;
        private System.Windows.Forms.Button ogretmenAEbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}