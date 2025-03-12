using System;
using System.Windows.Forms;
using AttributeLibrary; // DLL içindeki sınıfı kullanıyoruz.

namespace AttributeWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Adi = txtAdi.Text;
            ogrenci.Soyadi = txtSoyadi.Text;
            ogrenci.Bolum = txtBolum.Text;

            if (!ZorunluAlanAttribute.Dogrula(ogrenci))
            {
                MessageBox.Show("Öğrenci bilgileri doğrulamadan geçemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Form başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    public class Ogrenci
    {
        [ZorunluAlan]
        public string Adi;
        [ZorunluAlan]
        public string Soyadi;
        [ZorunluAlan]
        public string Bolum;
    }
}

