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


namespace ndpOdev3
{
    public class Urun
    {
        public string Marka;
        public string Ad;
        public string Model;
        public string Ozellik;
        public int StokAdedi;
        public int SecilenAdet;
        public int HamFiyat;
        public Urun(string Ad, string Marka, string Model, string Ozellik, int StokAdedi, int HamFiyat, int SecilenAdet)
        {
            this.Ad = Ad;
            this.Marka = Marka;
            this.Model = Model;
            this.Ozellik = Ozellik;
            Random UrunStok = new Random();
            StokAdedi = UrunStok.Next(1, 100);
            this.HamFiyat = HamFiyat;
            this.SecilenAdet = SecilenAdet;
        }

    }

}

