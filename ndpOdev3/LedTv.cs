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
    public class LedTv : Urun
    {
        public string EkranBoyutu, EkranCozunurlugu;

        public LedTv(string Ad, string Marka, string Model, string Ozellik, int StokAdedi, int HamFiyat, int SecilenAdet, string EkranBoyutu, string EkranCozunurlugu) : base(Ad, Marka, Model, Ozellik, StokAdedi, HamFiyat, SecilenAdet)
        {
            this.EkranBoyutu = EkranBoyutu;
            this.EkranCozunurlugu = EkranCozunurlugu;
            Random LedTvStok = new Random();
            StokAdedi = LedTvStok.Next(1, 100);
        }
    }
}

