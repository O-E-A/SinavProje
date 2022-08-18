using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SınavProje
{
    public partial class ogretmenİslemForm : Form
    {
        Ogrenci ogrenci = new Ogrenci();
        public ogretmenİslemForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //ogrenci.ogrencilerList;
            label1.Text = ogrenci.ogrenciyazdır();
        }
    }
}
