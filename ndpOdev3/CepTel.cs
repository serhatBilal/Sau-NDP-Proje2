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
    class CepTel : Urun
    {
        public string DahiliHafiza, RamKapasitesi, PilGucu;

        public CepTel(string Ad, string Marka, string Model, string Ozellik, int StokAdedi, int HamFiyat, int SecilenAdet, string DahiliHafiza, string RamKapasitesi, string PilGucu) : base(Ad, Marka, Model, Ozellik, StokAdedi, HamFiyat, SecilenAdet)
        {
            this.DahiliHafiza = DahiliHafiza;
            this.RamKapasitesi = RamKapasitesi;
            this.PilGucu = PilGucu;
            Random CepTelStok = new Random();
            StokAdedi = CepTelStok.Next(1, 100);
        }

    }
}

