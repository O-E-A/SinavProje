
namespace SınavProje
{
    partial class ogrenciForm
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
            this.ogrenciBilgilbl = new System.Windows.Forms.Label();
            this.TCtxtbx = new System.Windows.Forms.TextBox();
            this.TCsifretxtbx = new System.Windows.Forms.TextBox();
            this.ogrencigbtn = new System.Windows.Forms.Button();
            this.ogrenciAEbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ogrenciBilgilbl
            // 
            this.ogrenciBilgilbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ogrenciBilgilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciBilgilbl.ForeColor = System.Drawing.Color.DarkGray;
            this.ogrenciBilgilbl.Location = new System.Drawing.Point(201, 96);
            this.ogrenciBilgilbl.Name = "ogrenciBilgilbl";
            this.ogrenciBilgilbl.Size = new System.Drawing.Size(523, 102);
            this.ogrenciBilgilbl.TabIndex = 3;
            this.ogrenciBilgilbl.Text = "Öğrenci giriş bilgilerinizi giriniz.";
            this.ogrenciBilgilbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TCtxtbx
            // 
            this.TCtxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TCtxtbx.Location = new System.Drawing.Point(355, 263);
            this.TCtxtbx.Name = "TCtxtbx";
            this.TCtxtbx.Size = new System.Drawing.Size(254, 34);
            this.TCtxtbx.TabIndex = 4;
            this.TCtxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TCtxtbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TCsifretxtbx
            // 
            this.TCsifretxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TCsifretxtbx.Location = new System.Drawing.Point(355, 339);
            this.TCsifretxtbx.Name = "TCsifretxtbx";
            this.TCsifretxtbx.PasswordChar = '*';
            this.TCsifretxtbx.Size = new System.Drawing.Size(254, 34);
            this.TCsifretxtbx.TabIndex = 5;
            this.TCsifretxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TCsifretxtbx.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ogrencigbtn
            // 
            this.ogrencigbtn.BackColor = System.Drawing.Color.Gray;
            this.ogrencigbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrencigbtn.Location = new System.Drawing.Point(521, 417);
            this.ogrencigbtn.Name = "ogrencigbtn";
            this.ogrencigbtn.Size = new System.Drawing.Size(124, 56);
            this.ogrencigbtn.TabIndex = 6;
            this.ogrencigbtn.Text = "Giriş";
            this.ogrencigbtn.UseVisualStyleBackColor = false;
            this.ogrencigbtn.Click += new System.EventHandler(this.ogrencigbtn_Click);
            // 
            // ogrenciAEbtn
            // 
            this.ogrenciAEbtn.BackColor = System.Drawing.Color.Gray;
            this.ogrenciAEbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciAEbtn.Location = new System.Drawing.Point(289, 417);
            this.ogrenciAEbtn.Name = "ogrenciAEbtn";
            this.ogrenciAEbtn.Size = new System.Drawing.Size(124, 56);
            this.ogrenciAEbtn.TabIndex = 7;
            this.ogrenciAEbtn.Text = "Ana Ekran";
            this.ogrenciAEbtn.UseVisualStyleBackColor = false;
            this.ogrenciAEbtn.Click += new System.EventHandler(this.ogrenciAEbtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(141, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Öğrenci TC numarası:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(146, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 34);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ogrenciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(919, 552);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ogrenciAEbtn);
            this.Controls.Add(this.ogrencigbtn);
            this.Controls.Add(this.TCsifretxtbx);
            this.Controls.Add(this.TCtxtbx);
            this.Controls.Add(this.ogrenciBilgilbl);
            this.Name = "ogrenciForm";
            this.Text = "Öğrenci Giriş Ekranı";
            this.Load += new System.EventHandler(this.ogrenciForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ogrenciBilgilbl;
        private System.Windows.Forms.TextBox TCtxtbx;
        private System.Windows.Forms.TextBox TCsifretxtbx;
        private System.Windows.Forms.Button ogrencigbtn;
        private System.Windows.Forms.Button ogrenciAEbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}