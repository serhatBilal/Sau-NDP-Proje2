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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndpOdev3
{
    public class Sepet
    {
        public double KdvUygula(int adet, string urun)
        {
            double kdvliFiyat = 0;
            if (urun == "Buzdolabı")
                kdvliFiyat = 3500 * 1.05 * adet;
            if (urun == "Laptop")
                kdvliFiyat = 6000 * 1.15 * adet;
            if (urun == "LedTv")
                kdvliFiyat = 4000 * 1.18 * adet;
            if (urun == "CepTelefonu")
                kdvliFiyat = 2500 * 1.20 * adet;
            return kdvliFiyat;
        }
        public void SepeteUrunEkle(Urun urun) { }
        public int KdvliGenelToplam(int toplanacak)
        {
            int toplam = 0;
            toplam = toplam + toplanacak;
            return toplam;
        }
        public void yazdır(int toplamm)
        {
        }
    }
}

