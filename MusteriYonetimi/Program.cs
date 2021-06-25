using System;
using MusteriYonetimi.Abstract;
using MusteriYonetimi.Concrete;
using MusteriYonetimi.Entities;

namespace MusteriYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            TemelMusteriYonetimi musteriYonetimi = new GercekMusteriYonetimi();
            musteriYonetimi.Kaydet(musteri: new Musteri { Id = "1" , MusteriNo = "11" , KanalId = "111" });
            Console.ReadLine();

            TemelMusteriYonetimi musteriYonetimi1 = new GercekMusteriYonetimi();
            musteriYonetimi1.Kaydet(musteri: new Musteri { Id = "2", MusteriNo = "22", KanalId = "222" });
            Console.ReadLine();

            TemelMusteriYonetimi musteriYonetimi3 = new GercekMusteriYonetimi();
            musteriYonetimi3.Sil(musteri: new Musteri { Id = "2", MusteriNo = "22", KanalId = "222" });
            Console.ReadLine();

        }
    }
}
