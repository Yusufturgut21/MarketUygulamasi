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

            �r�nEkle �r�n = new �r�nEkle(); // 'new' kelimesi do�ru syntax ile kullan�lmal�d�r.
            �r�n.ShowDialog(); // 'ShowDialog' metodu, 'personel' nesnesine ait bir metot oldu�u i�in 'personel' nesnesiyle �a�r�lmal�d�r.
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PersonelEkle personel = new PersonelEkle(); // 'new' kelimesi do�ru syntax ile kullan�lmal�d�r.
            personel.ShowDialog(); // 'ShowDialog' metodu, 'personel' nesnesine ait bir metot oldu�u i�in 'personel' nesnesiyle �a�r�lmal�d�r.
        }
    }
}
