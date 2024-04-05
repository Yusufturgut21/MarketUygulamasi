namespace Market
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            ÜrünEkle Ürün = new ÜrünEkle(); // 'new' kelimesi doðru syntax ile kullanýlmalýdýr.
            Ürün.ShowDialog(); // 'ShowDialog' metodu, 'personel' nesnesine ait bir metot olduðu için 'personel' nesnesiyle çaðrýlmalýdýr.
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PersonelEkle personel = new PersonelEkle(); // 'new' kelimesi doðru syntax ile kullanýlmalýdýr.
            personel.ShowDialog(); // 'ShowDialog' metodu, 'personel' nesnesine ait bir metot olduðu için 'personel' nesnesiyle çaðrýlmalýdýr.
        }
    }
}
