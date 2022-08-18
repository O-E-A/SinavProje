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
    public partial class ogretmenForm : Form
    {
        public ogretmenForm()
        {
            InitializeComponent();
        }

        private void ogretmenAEbtn_Click(object sender, EventArgs e)
        {
            GirisForm fr = new GirisForm();
            fr.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ogretmenForm_Load(object sender, EventArgs e)
        {

        }

        private void ogretmengbtn_Click(object sender, EventArgs e)
        {
            string satir = "";
            StreamReader sr = new StreamReader("ogretmenBilgi.txt");
           

            while (true)
            {
                satir = sr.ReadLine();

                if (satir == null)
                {
                    ogretmenBilgilbl.Text = "Bilgileriniz bulunamamıştır. Lütfen kontrol edin.";
                    break;
                }
                string[] notlar = satir.Split(' ');
                string isim = notlar[0] +" "+ notlar[1];
                int TC = Convert.ToInt32(notlar[2]);
                string ad = kaditxtbx.Text;
                int numara = Convert.ToInt32(kadisifretxtbx.Text);
                //ogretmenBilgilbl.Text = isim + TC;


                if ((isim == ad) && (TC==numara))
                {
                    ogretmenİslemForm fr = new ogretmenİslemForm();
                    fr.Show();
                    this.Hide();
                    break;
                }
                //listBox1.Items.Add(satir);
                //string[] notlar = satir.Split(' ');
                //double ort = 0.4 * Convert.ToDouble(notlar[1]) + 0.6 * Convert.ToDouble(notlar[2]);
                //listBox2.Items.Add(notlar[0] + "\t" + " : " + ort);
            }
            sr.Close();
        }
    }
}
