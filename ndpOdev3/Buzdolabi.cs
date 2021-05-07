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
    class Buzdolabı : Urun
    {
        public string IcHacim, EnerjiSinifi;

        public Buzdolabı(string Ad, string Marka, string Model, string Ozellik, int StokAdedi, int HamFiyat, int SecilenAdet, string IcHacim, string EnerjiSinifi) : base(Ad, Marka, Model, Ozellik, StokAdedi, HamFiyat, SecilenAdet)
        {

            this.IcHacim = IcHacim;
            this.EnerjiSinifi = EnerjiSinifi;
            Random BuzdolabıStok = new Random();
            StokAdedi = BuzdolabıStok.Next(1, 100);
        }

    }
}
