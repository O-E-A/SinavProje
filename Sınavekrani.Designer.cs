
namespace SınavProje
{
    partial class Sınavekrani
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
            this.sürelbl = new System.Windows.Forms.Label();
            this.Sisimlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(606, 353);
            this.textBox1.TabIndex = 0;
            // 
            // sürelbl
            // 
            this.sürelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sürelbl.ForeColor = System.Drawing.SystemColors.Window;
            this.sürelbl.Location = new System.Drawing.Point(664, 12);
            this.sürelbl.Name = "sürelbl";
            this.sürelbl.Size = new System.Drawing.Size(206, 90);
            this.sürelbl.TabIndex = 1;
            this.sürelbl.Text = "Süre(sn)";
            this.sürelbl.Click += new System.EventHandler(this.sürelbl_Click);
            // 
            // Sisimlbl
            // 
            this.Sisimlbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.Sisimlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sisimlbl.ForeColor = System.Drawing.SystemColors.Window;
            this.Sisimlbl.Location = new System.Drawing.Point(675, 128);
            this.Sisimlbl.Name = "Sisimlbl";
            this.Sisimlbl.Size = new System.Drawing.Size(206, 44);
            this.Sisimlbl.TabIndex = 2;
            this.Sisimlbl.Text = "isim soyisim";
            this.Sisimlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sisimlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sınavekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(917, 574);
            this.Controls.Add(this.Sisimlbl);
            this.Controls.Add(this.sürelbl);
            this.Controls.Add(this.textBox1);
            this.Name = "Sınavekrani";
            this.Text = "Sınav Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label sürelbl;
        private System.Windows.Forms.Label Sisimlbl;
    }
}