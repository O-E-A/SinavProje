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
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void ogrencibtn_Click(object sender, EventArgs e)
        {
            ogrenciForm fr = new ogrenciForm();
            fr.Show();
            this.Hide();
        }

        private void ogretmenglbl_Click(object sender, EventArgs e)
        {
            ogretmenForm fr = new ogretmenForm();
            fr.Show();
            this.Hide();
        }
    }
}
