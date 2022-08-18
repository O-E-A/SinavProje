using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SınavProje
{
    class Ogrenci
    {
        private string ad;
        private string soyad;
        private string TC;
        private string numara;
        private List<string> ogrencilerList = new List<string>();
        private void ogrenci(string ad, string soyad, string TC, string numara)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.TC = TC;
            this.numara = numara;
        }
        private void degerata()
        {
            string satir = "";
            StreamReader sr = new StreamReader("ogrenciBilgi.txt");

            while (true)
            {
                satir = sr.ReadLine();

                if (satir == null)
                {
                    break;
                }
                string[] ogrenciler = satir.Split(' ');
                string ad = ogrenciler[0];
                string soyad = ogrenciler[1];
                string TC = ogrenciler[2];
                string numara = ogrenciler[3];

                ogrenci(ad, soyad, TC, numara);         
                ogrencilerList.Add(this.ad+" "+this.numara);        
            }
            sr.Close();
        }
        public string ogrenciyazdır()
        {
            string item1 = "";
            degerata();
            foreach (string item in ogrencilerList)
            {
                item1 += "\n" + item;
            }
            return item1;
        }
        public void ogrenciekle(string ogrenciBilgi)
        {
            StreamWriter Yaz = new StreamWriter("C:\\Users\\HP\\source\\repos\\SınavProje\\bin\\Debug\\grenciBilgi.txt");
            Yaz.WriteLine(ogrenciBilgi);
            Yaz.Close();
        }
    } 
}
