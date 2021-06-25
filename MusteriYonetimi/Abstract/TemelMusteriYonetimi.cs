using MusteriYonetimi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriYonetimi.Abstract
{
    public abstract class TemelMusteriYonetimi : IMusteriServisi
    {
        public void Kaydet(Musteri musteri)
        {
            Console.WriteLine("Kaydedildi : " + musteri.MusteriNo);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Silindi : " + musteri.MusteriNo);
        }
    }
}
