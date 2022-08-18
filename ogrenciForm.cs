using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SınavProje
{
    public partial class ogrenciForm : Form
    {
        public ogrenciForm()
        {
            InitializeComponent();
        }

        private void ogrenciForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ogrenciAEbtn_Click(object sender, EventArgs e)
        {
            GirisForm fr = new GirisForm();
            fr.Show();
            this.Hide();

        }

        private void ogrencigbtn_Click(object sender, EventArgs e)
        {
            string satir = "";
            StreamReader sr = new StreamReader("ogrenciBilgi.txt");


            while (true)
            {
                satir = sr.ReadLine();

                if (satir == null)
                {
                    ogrenciBilgilbl.Text = "Bilgileriniz bulunamamıştır. Lütfen kontrol edin.";
                    break;
                }
                string[] notlar = satir.Split(' ');
                string isim = notlar[0] /*+ " " + notlar[1]*/;
                string TC =notlar[1];
                string ad = TCtxtbx.Text;
                string numara =TCsifretxtbx.Text;
                //ogretmenBilgilbl.Text = isim + TC;


                if ((isim == ad) && (TC == numara))
                {
                    Sınavekrani fr = new Sınavekrani();
                    fr.Show();
                    break;
                }
            }
            sr.Close();
        }
    }
}
