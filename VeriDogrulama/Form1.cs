using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriDogrulama
{
    public partial class Form1 : Form
    {
        ErrorProvider ep = new ErrorProvider();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textNumara_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(textNumara.Text, out int sonuc))
            {
                ep.SetError(textNumara, "");
            }
            else
            {
                e.Cancel = true;
                ep.SetError(textNumara, "Numara girişi hatalı");
            }
        }

        private void textAdSoyad_Validating(object sender, CancelEventArgs e)
        {
            if (textAdSoyad.Text == "")
            {
                e.Cancel = true;
                ep.SetError(textAdSoyad, "Adı ve soyadı giriniz.");
            }
            else
            {
                ep.SetError(textAdSoyad, "");
            }
        }

        private void textDersNotu_Validating(object sender, CancelEventArgs e)
        {
            int dersNotu;
            if (int.TryParse(textDersNotu.Text, out dersNotu))
            {
                if (dersNotu < 0 || dersNotu > 100)
                {
                    e.Cancel = true;
                    ep.SetError(textDersNotu, "0 - 100 arasında değer giriniz.");
                }
                else
                {
                    ep.SetError(textDersNotu, "");
                }
            }
            else
            {
                e.Cancel = true;
                ep.SetError(textDersNotu, "Sayısal değer giriniz.");
            }
        }
    }
}
