using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace listeproje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<string> ad = new List<string>();
        List<string> soyad = new List<string>();
        List<string> kitap_ad = new List<string>();
        List<string> tel = new List<string>();
        List<string> tarih = new List<string>();
        int sayac = 0;
        private void Kaydet_Click(object sender, EventArgs e)
        {
            string deger = txtad.Text + " " + txtsoyad.Text + " " + txtktp.Text + " " + mskdtel.Text + " " + dtptrh.Text;
            sirala.Items.Add(deger);


            ad.Add(txtad.Text);
            soyad.Add(txtsoyad.Text);
            kitap_ad.Add(txtktp.Text);
            tel.Add(mskdtel.Text);
            tarih.Add(dtptrh.Text);
            sayac++;

            txtad.Text = "";
            txtsoyad.Text = "";
            txtktp.Text = "";
            mskdtel.Text = "";
            dtptrh.Value = DateTime.Now;

        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            sirala.Items.Clear();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            int sonuc = ad.Where(k => k.Contains(txtara.Text)).Count();
            MessageBox.Show(txtara.Text + "de aradığın isim listede " + sonuc + " bulunmaktadır");
            txtara.Text = "";
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string silinecekKelime = txtara.Text; // TextBox'ta girilen kelimeyi alın

            for (int i = sirala.Items.Count - 1; i >= 0; i--)
            {
                string listBoxMetni = sirala.Items[i].ToString();
                if (listBoxMetni.Contains(silinecekKelime))
                {
                    sirala.Items.RemoveAt(i);
                    MessageBox.Show("Belirtilen kelimeye sahip veri silindi.");
                    return; // İlk eşleşmeyi sildikten sonra işlemi sonlandır
                }
            }

            // Eğer belirtilen kelimeye sahip öğe bulunamazsa, kullanıcıya bir mesaj gösterin
            MessageBox.Show("Belirtilen kelimeye sahip veri bulunamadı.");
        }

        private void btnsecsil_Click(object sender, EventArgs e)
        {
            if (sirala.SelectedIndex >= 0)
            {
                sirala.Items.RemoveAt(sirala.SelectedIndex);
                MessageBox.Show("Veri silindi");
            }
            else
            {
                MessageBox.Show("Lütfen bir öğe seçin.");
            }
        }
    }
}

