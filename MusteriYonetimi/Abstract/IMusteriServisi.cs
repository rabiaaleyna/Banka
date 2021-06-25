using System;
using System.Collections.Generic;
using System.Text;
using MusteriYonetimi.Entities;

namespace MusteriYonetimi.Abstract
{
    public interface IMusteriServisi
    {
        void Kaydet(Musteri musteri);

        void Sil(Musteri musteri);
    }
}
