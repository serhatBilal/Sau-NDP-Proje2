/****************************************************************************
**			    SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				NESNEYE DAYALI PROGRAMLAMA DERSİ
**			    2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:3
**				ÖĞRENCİ ADI............:Serhat BİLAL
**				ÖĞRENCİ NUMARASI.......:B191210309
**              DERSİN ALINDIĞI GRUP...:A
****************************************************************************/
using System;
using System.Windows.Forms;

namespace ndpOdev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void urunEkleButon_Click(object sender, EventArgs e)
        {
            tlLabel.Visible = true; // TL yazan Label genel kdvli toplam fiyat yazdığında görünür oluyor.

            adetListBox.Items.Clear();
            urunListBox.Items.Clear();
            kdvliListBox.Items.Clear();
            Sepet kdvHesabı = new Sepet();
            int genelToplam = 0;

            if (laptopNumerik.Value == 0 && telNumerik.Value == 0 && buzdolabiNumerik.Value == 0 && tvNumerik.Value == 0) // Sepete Hiç ürün eklenmezse verilen hata
                MessageBox.Show("Sepet Boş");

            if (telNumerik.Value != 0)
            {
                if (Convert.ToInt32(telStokuLabel.Text) >= Convert.ToInt32(telNumerik.Value)) //ürün stok kontrolü
                {
                    string fiyat = (kdvHesabı.KdvUygula(Convert.ToInt32(telNumerik.Value), "CepTelefonu")).ToString();
                    adetListBox.Items.Add(telNumerik.Value.ToString());
                    urunListBox.Items.Add("Cep Telefonu");
                    kdvliListBox.Items.Add(fiyat + " TL");
                    genelToplam = genelToplam + kdvHesabı.KdvliGenelToplam(Convert.ToInt32(fiyat));
                    int telStokDus = Convert.ToInt32(telStokuLabel.Text) - Convert.ToInt32(telNumerik.Value);
                    telStokuLabel.Text = telStokDus.ToString();
                }
                else
                {
                    MessageBox.Show("Yeterli Cep Telefonu Stoku Yok!"); //yeteri kadar stok olmadıgında verilen hata
                    telNumerik.Value = 0;
                }
            }
            if (laptopNumerik.Value != 0)
            {
                if (Convert.ToInt32(laptopStokuLabel.Text) >= Convert.ToInt32(laptopNumerik.Value))
                {
                    string fiyat = (kdvHesabı.KdvUygula(Convert.ToInt32(laptopNumerik.Value), "Laptop")).ToString();
                    adetListBox.Items.Add(laptopNumerik.Value.ToString());
                    urunListBox.Items.Add("Laptop");
                    kdvliListBox.Items.Add(fiyat + " TL");
                    kdvHesabı.KdvliGenelToplam(Convert.ToInt32(fiyat));
                    genelToplam = genelToplam + kdvHesabı.KdvliGenelToplam(Convert.ToInt32(fiyat));
                    int pcStokDus = Convert.ToInt32(laptopStokuLabel.Text) - Convert.ToInt32(laptopNumerik.Value);
                    laptopStokuLabel.Text = pcStokDus.ToString();
                }
                else
                {
                    MessageBox.Show("Yeterli Laptop Stoku Yok!");
                    laptopNumerik.Value = 0;
                }
            }
            if (buzdolabiNumerik.Value != 0)
            {
                if (Convert.ToInt32(buzdolabiStokuLabel.Text) >= Convert.ToInt32(buzdolabiNumerik.Value))
                {
                    string fiyat = (kdvHesabı.KdvUygula(Convert.ToInt32(buzdolabiNumerik.Value), "Buzdolabı")).ToString();
                    adetListBox.Items.Add(buzdolabiNumerik.Value.ToString());
                    urunListBox.Items.Add("Buzdolabı");
                    kdvliListBox.Items.Add(fiyat + " TL");
                    kdvHesabı.KdvliGenelToplam(Convert.ToInt32(fiyat));
                    genelToplam = genelToplam + kdvHesabı.KdvliGenelToplam(Convert.ToInt32(fiyat));
                    int buzdolabıStokDus = Convert.ToInt32(buzdolabiStokuLabel.Text) - Convert.ToInt32(buzdolabiNumerik.Value);
                    buzdolabiStokuLabel.Text = buzdolabıStokDus.ToString();
                }
                else
                {
                    MessageBox.Show("Yeterli Buzdolabı Stoku Yok!");
                    buzdolabiNumerik.Value = 0;
                }
            }
            if (tvNumerik.Value != 0)
            {
                if (Convert.ToInt32(tvStokuLabel.Text) >= Convert.ToInt32(tvNumerik.Value))
                {
                    string fiyat = (kdvHesabı.KdvUygula(Convert.ToInt32(tvNumerik.Value), "LedTv")).ToString();
                    adetListBox.Items.Add(tvNumerik.Value.ToString());
                    urunListBox.Items.Add("Led Tv");
                    kdvliListBox.Items.Add(fiyat + " TL");
                    genelToplam = genelToplam + kdvHesabı.KdvliGenelToplam(Convert.ToInt32(fiyat));
                    int tvStokDus = Convert.ToInt32(tvStokuLabel.Text) - Convert.ToInt32(tvNumerik.Value);
                    tvStokuLabel.Text = tvStokDus.ToString();
                }
                else
                {
                    MessageBox.Show("Yeterli Televizyon Stoku Yok!");
                    tvNumerik.Value = 0;
                }
            }
            kdvliFiyatLabel.Text = genelToplam.ToString();

        }

        private void sepetTemizleButon_Click(object sender, EventArgs e)
        {
            int televizyonStokYenile = Convert.ToInt32(tvStokuLabel.Text) + Convert.ToInt32(tvNumerik.Value); //sepet temizlendiğinde var olan stok ve seçilmiş ürünlerin tekrar stoga eklenmesi
            int laptopStokYenile = Convert.ToInt32(laptopStokuLabel.Text) + Convert.ToInt32(laptopNumerik.Value);
            int buzdolabiStokYenile = Convert.ToInt32(buzdolabiStokuLabel.Text) + Convert.ToInt32(buzdolabiNumerik.Value);
            int telefonStokYenile = Convert.ToInt32(telStokuLabel.Text) + Convert.ToInt32(telNumerik.Value);

            adetListBox.Items.Clear(); //ListBoxların içlerinin boşaltılması
            urunListBox.Items.Clear();
            kdvliListBox.Items.Clear();

            tvStokuLabel.Text = televizyonStokYenile.ToString(); // Stok'un ekrana yazılması
            laptopStokuLabel.Text = laptopStokYenile.ToString();
            buzdolabiStokuLabel.Text = buzdolabiStokYenile.ToString();
            telStokuLabel.Text = telefonStokYenile.ToString();

            tvNumerik.Value = 0;
            buzdolabiNumerik.Value = 0;
            laptopNumerik.Value = 0;
            telNumerik.Value = 0;
            kdvliFiyatLabel.Text = "0";

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            tlLabel.Visible = false;
            Random rastgeleStokDegeriAta = new Random();

            int tvStoku = rastgeleStokDegeriAta.Next(1, 100);
            LedTv televizyon = new LedTv("LedTv", "VESTEL", "Flat", "Full HD", tvStoku, 4000, Convert.ToInt32(tvNumerik.Value), "1050", "1000");
            tvStokuLabel.Text = tvStoku.ToString();

            int buzdolabiStoku = rastgeleStokDegeriAta.Next(1, 100);
            Buzdolabı buzdolabi = new Buzdolabı("Buzdolabı", "VESTEL", "2019 Yaz", "A++", buzdolabiStoku, 3500, Convert.ToInt32(buzdolabiNumerik.Value), "3*1 metre", "A Sınıfı");
            buzdolabiStokuLabel.Text = buzdolabiStoku.ToString();

            int telStoku = rastgeleStokDegeriAta.Next(1, 100);
            CepTel cepTelefonu = new CepTel("Cep Tel", "OPPO", "A9", "48 MB Kamera", telStoku, 2500, Convert.ToInt32(telNumerik.Value), "1 GB", "3 GB RAM", "5000 mAh");
            telStokuLabel.Text = telStoku.ToString();

            int laptopStoku = rastgeleStokDegeriAta.Next(1, 100);
            Laptop notebook = new Laptop("Laptop", "ASUS", "ROG", "i7 İşlemci", laptopStoku, 6000, Convert.ToInt32(laptopNumerik.Value), "512 GB SSD ", "16 GB RAM", "4500 Amper", "1050*1870", "15.6");
            laptopStokuLabel.Text = laptopStoku.ToString();

        }
    }
}
