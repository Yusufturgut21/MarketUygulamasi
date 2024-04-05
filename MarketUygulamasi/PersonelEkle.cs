using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Market
{
    public partial class PersonelEkle : Form
    {
        // Örnek bir Personel sınıfı
        public class Personel
        {
            public string isim { get; set; }
            public string soyisim { get; set; }
        }

        // Personel nesnelerini saklayacak bir liste
        private List<Personel> personelListesi = new List<Personel>();

        // XML dosyasının adı ve yolunu tanımlayalım
        private string dosyaYolu = "personel.xml";

        public PersonelEkle()
        {
            InitializeComponent();

            // Program başladığında kaydedilmiş verileri yükle
            VerileriYukle();
        }

        private void button1_Click(object sender, EventArgs e)
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
            listBox1.Items.Add(yeniPersonel.isim + " " + yeniPersonel.soyisim);

            // Yeni personeli XML dosyasına kaydedelim
            VerileriKaydet();

            MessageBox.Show("Personel başarıyla eklendi.");

            ad.Clear();
            soyad.Clear();
        }

        private void VerileriKaydet()
        {
            // Serialize işlemi için XmlSerializer nesnesi oluştur
            XmlSerializer serializer = new XmlSerializer(typeof(List<Personel>));

            // StreamWriter ile dosyayı oluştur veya aç
            using (StreamWriter sw = new StreamWriter(dosyaYolu))
            {
                // Personel listesini XML dosyasına yaz
                serializer.Serialize(sw, personelListesi);
            }
        }

        private void VerileriYukle()
        {
            // Dosya mevcut değilse işlemi sonlandır
            if (!File.Exists(dosyaYolu))
                return;

            // Serialize işlemi için XmlSerializer nesnesi oluştur
            XmlSerializer serializer = new XmlSerializer(typeof(List<Personel>));

            // StreamReader ile dosyayı oku
            using (StreamReader sr = new StreamReader(dosyaYolu))
            {
                // XML dosyasından personel listesini oku
                personelListesi = (List<Personel>)serializer.Deserialize(sr);
            }

            // Personel listesindeki her bir personeli ListBox'a ekle
            foreach (Personel personel in personelListesi)
            {
                listBox1.Items.Add(personel.isim + " " + personel.soyisim);
            }
        }
    }
}
