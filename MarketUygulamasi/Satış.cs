using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Market
{
    public partial class Satış : Form
    {
        // ÜrünEkle formuna referans oluşturma
        private ÜrünEkle ürünEkleFormu;

        public Satış(ÜrünEkle ürünEkleFormu)
        {
            InitializeComponent();
            this.ürünEkleFormu = ürünEkleFormu; // ÜrünEkle formuyla ilişkiyi kur
        }

        // Satış formundaki satış butonuna tıklama olayı
        private void satış_btn_Click(object sender, EventArgs e)
        {
          
        }

        private void hesapla_txt_Click(object sender, EventArgs e)
        {
            // Hesaplama işlemleri...
        }
    }
}
