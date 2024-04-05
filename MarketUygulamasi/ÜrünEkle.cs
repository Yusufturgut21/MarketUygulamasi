using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using static Market.ÜrünEkle;

namespace Market
{
    public partial class ÜrünEkle : Form
    {
        public class Ürün
        {
            public string Marka { get; set; }
            public string SeriNo { get; set; }
            public string Tür { get; set; }
            public decimal Fiyat { get; set; }
            public int Miktar { get; set; }
        }
        public class Personel
        {
            public string isim { get; set; }
            public string soyisim { get; set; }
        }
        public class Günsonu
        {
            public string personelad { get; set; }
            public int bakiye { get; set; }
            public string Tarih { get; set; } // Tarih değişkenini tanımlayın
        }

        private List<Personel> personelListesi = new List<Personel>();
        private List<Günsonu> günList = new List<Günsonu> ();
        private List<Ürün> ürünListesi = new List<Ürün>();
        private string dosyaYolu = "ürünler.xml";
        private string dosyaYolu1 = "personel.xml";
        private string dosyaYolu2 = "günsonu.xml";
        public ÜrünEkle()
        {
            InitializeComponent();
            VerileriYukle();
        }

        private void ÜrünEkle_Load(object sender, EventArgs e)
        {
            VerileriYukle();
        }




        private void hesapla_txt_Click(object sender, EventArgs e)
        {
            string seriNo = seri_txt.Text;
            int adet;

            if (!int.TryParse(adet_txt.Text, out adet) || adet <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir adet sayısı giriniz.");
                return;
            }

            var satılacakÜrün = ürünListesi.FirstOrDefault(u => u.SeriNo == seriNo);

            if (satılacakÜrün == null)
            {
                MessageBox.Show("Belirtilen seri numarasına ait ürün bulunamadı.");
                return;
            }

            decimal tutar = satılacakÜrün.Fiyat * adet;
            tutar_lbl.Text = tutar.ToString();

            decimal alınanPara;
            if (!decimal.TryParse(alinan_txt.Text, out alınanPara) || alınanPara < tutar)
            {
                MessageBox.Show("Lütfen geçerli bir para miktarı giriniz.");
                return;
            }

            borc_lbl.Text = (alınanPara - tutar).ToString();

            if (satılacakÜrün.Miktar < adet)
            {
                MessageBox.Show("Belirtilen seri numarasına ait ürünün miktarı yetersiz.");
                return;
            }

          
        }

        private void VerileriKaydet()
        {
            // Ürünleri kaydet
            XmlSerializer serializer = new XmlSerializer(typeof(List<Ürün>));
            using (StreamWriter sw = new StreamWriter(dosyaYolu))
            {
                serializer.Serialize(sw, ürünListesi);
            }

            // Personel listesi için ayrı bir serializer ve dosya yolunu kullan
            serializer = new XmlSerializer(typeof(List<Personel>));
            using (StreamWriter sw = new StreamWriter(dosyaYolu1))
            {
                serializer.Serialize(sw, personelListesi);
            }

            // Günsonu raporlarını kaydet
            serializer = new XmlSerializer(typeof(List<Günsonu>));
            using (StreamWriter sw = new StreamWriter(dosyaYolu2))
            {
                serializer.Serialize(sw, günList);
            }
        }


        private void VerileriYukle()
        {

            // Ürünleri yükle
            if (File.Exists(dosyaYolu))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Ürün>));

                using (StreamReader sr = new StreamReader(dosyaYolu))
                {
                    ürünListesi = (List<Ürün>)serializer.Deserialize(sr);
                }

                foreach (Ürün ürün in ürünListesi)
                {
                    listBox1.Items.Add($"{ürün.Marka} - {ürün.SeriNo} - {ürün.Tür} - {ürün.Fiyat} - {ürün.Miktar} ");
                }

                // Günsonu listesini yükle
                if (File.Exists(dosyaYolu2))
                {
                    XmlSerializer serializerGünsonu = new XmlSerializer(typeof(List<Günsonu>));

                    using (StreamReader sr = new StreamReader(dosyaYolu2))
                    {
                        günList = (List<Günsonu>)serializerGünsonu.Deserialize(sr);
                    }

                    // Mevcut verileri temizlemeden günsonu listesini ekleyelim
                    foreach (Günsonu gunsonu in günList)
                    {
                        günsonu.Items.Add($"{gunsonu.personelad} - {gunsonu.bakiye}-{gunsonu.Tarih}");
                    }
                }

            }
            // label14'ü günsonu verisine göre güncelle
            if (günList.Any())
            {
                label14.Text = günList.Sum(g => g.bakiye).ToString();
            }

            // Personel listesini yükle
            if (File.Exists(dosyaYolu1))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Personel>));

                using (StreamReader sr = new StreamReader(dosyaYolu1))
                {
                    personelListesi = (List<Personel>)serializer.Deserialize(sr);
                }

                foreach (Personel personel in personelListesi)
                {
                    listBox2.Items.Add(personel.isim + " " + personel.soyisim);

                    personelcombo.Items.Add(personel.isim + " " + personel.soyisim);
                }

            }

        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            string marka = marka_txt.Text;
            string seriNo = serino_txt.Text;
            string tür = tür_txt.Text;
            decimal fiyat;
            int miktar;

            if (string.IsNullOrEmpty(marka) || string.IsNullOrEmpty(seriNo) || string.IsNullOrEmpty(tür) ||
                !decimal.TryParse(fiyat_txt.Text, out fiyat) || !int.TryParse(miktar_txt.Text, out miktar))
            {
                MessageBox.Show("Lütfen tüm bilgileri eksiksiz ve doğru şekilde giriniz.");
                return;
            }


            // Yeni ürünü oluştur
            Ürün yeniÜrün = new Ürün
            {
                Marka = marka,
                SeriNo = seriNo,
                Tür = tür,
                Fiyat = fiyat,
                Miktar = miktar
            };

            // Eğer aynı seri numarasına sahip ürün zaten listeye ekliyse, ekleme işlemini yapma
            if (ürünListesi.Any(u => u.SeriNo == yeniÜrün.SeriNo))
            {
                MessageBox.Show("Bu seri numarasına sahip ürün zaten var.");
                return;
            }

            // Yeni ürünü listeye ekle
            ürünListesi.Add(yeniÜrün);

            // Verileri kaydet
            VerileriKaydet();

            // Listbox1'i temizle ve güncel ürün listesini tekrar yükle
            listBox1.Items.Clear();
            VerileriYukle();

            // Kullanıcıya geri bildirim göster
            MessageBox.Show("Ürün başarıyla eklendi.");

            // Giriş alanlarını temizle
            marka_txt.Clear();
            serino_txt.Clear();
            tür_txt.Clear();
            fiyat_txt.Clear();
            miktar_txt.Clear();

            label14.Text = günList.Sum(g => g.bakiye).ToString();
        }
        private decimal toplamSatisFiyati = 0;

        private void satiş_btn_Click(object sender, EventArgs e)
        {
            string seriNo = seri_txt.Text;
            int adet;

            if (!int.TryParse(adet_txt.Text, out adet) || adet <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir adet sayısı giriniz.");
                return;
            }

            var satılacakÜrün = ürünListesi.FirstOrDefault(u => u.SeriNo == seriNo);

            if (satılacakÜrün == null)
            {
                MessageBox.Show("Belirtilen seri numarasına ait ürün bulunamadı.");
                return;
            }

            if (satılacakÜrün.Miktar < adet)
            {
                MessageBox.Show("Belirtilen seri numarasına ait ürünün miktarı yetersiz.");
                return;
            }

            // Ürün miktarını güncelle
            satılacakÜrün.Miktar -= adet;

            // Satışın toplam fiyatını hesapla ve label14'e ekle
            decimal satisFiyati = satılacakÜrün.Fiyat * adet;
            toplamSatisFiyati += satisFiyati;
            label14.Text = toplamSatisFiyati.ToString();


            // XML dosyasına güncellenmiş ürün listesini kaydet
            VerileriKaydet();
            MessageBox.Show("Satış işlemi başarıyla gerçekleşti.");

            // Listbox1'i temizle ve güncel ürün listesini tekrar yükle
            listBox1.Items.Clear();
            VerileriYukle();
            label14.Text = toplamSatisFiyati.ToString();

            decimal tutar = satılacakÜrün.Fiyat * adet;
            tutar_lbl.Text = tutar.ToString();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string isim = ad.Text;
            string soyisim = soyad.Text;

            if (string.IsNullOrEmpty(isim) || string.IsNullOrEmpty(soyisim))
            {
                MessageBox.Show("Lütfen ad ve soyadı giriniz.");
                return;
            }

            Personel yeniPersonel = new Personel
            {
                isim = isim,
                soyisim = soyisim
            };

            personelListesi.Add(yeniPersonel);

            // ListBox'a personel bilgilerini ekleyelim
            listBox2.Items.Add(yeniPersonel.isim + " " + yeniPersonel.soyisim);

            // Yeni personeli XML dosyasına kaydedelim
            VerileriKaydet();

            MessageBox.Show("Personel başarıyla eklendi.");

            ad.Clear();
            soyad.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label14.Text = "";
        }

        private void personelcombo_Click(object sender, EventArgs e)
        {
            if (personelcombo.SelectedItem != null)
            {
                calisan.Text = personelcombo.SelectedItem.ToString();
            }
            else
            {
                calisan.Text = ""; // Eğer hiçbir öğe seçilmemişse, boş bir değer atayabilirsiniz.
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (personelcombo.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir personel seçin.");
                return;
            }

            string secilenPersonel = personelcombo.SelectedItem.ToString();
            int bakiye = 0;
            if (!string.IsNullOrEmpty(label14.Text))
            {
                bakiye = Convert.ToInt32(label14.Text);
            }

            // Tarih bilgisini doğru şekilde alıp kullanın
            string tarihBilgisi = DateTime.Now.ToString(); // Şu anki tarihi alın
            günsonu.Items.Add($"{secilenPersonel} - {bakiye} - {tarihBilgisi}");

            Günsonu günsonuRapor = new Günsonu
            {
                personelad = secilenPersonel,
                bakiye = bakiye,
                Tarih = tarihBilgisi // Tarih bilgisini atayın
            };
            günList.Add(günsonuRapor);
            VerileriKaydet(); // Verileri kaydetmek için bu satırı ekleyin
        }


    }
}