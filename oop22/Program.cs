using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ronahi Guven
            GercekMusteri musteri1=new GercekMusteri();
            musteri1.Adi = "Ronahi";
            musteri1.Soyadi = "Guven";
            musteri1.MusteriNo = "111111";
            musteri1.TcNo = "1111111111111";
            musteri1.Id = 1;

            //KodlamaIo

            TuzelMusteri musteri2=new TuzelMusteri();
            musteri2.SirketAdi = "KodlamaIo";
            musteri2.MusteriNo = "11111111111";
            musteri2.Id = 2;
            musteri2.VergiNo = "12344567890";

            //Gercek Musteri-Tuzel Musteri
            //SOLID
            Musteri musteri3 = new GercekMusteri();//new GercekMusteri();referans no
            Musteri musteri4 = new TuzelMusteri();//new TuzelMusteri();referans no
            CustomerManager.Ekle (musteri1);
            CustomerManager.Ekle(musteri2);

            Console.ReadLine();
        }
    }
}
