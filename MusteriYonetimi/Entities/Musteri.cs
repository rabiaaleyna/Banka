using MusteriYonetimi.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriYonetimi.Entities
{
    public class Musteri : IEntity
    {
        public string Id { get; set; }
        public string MusteriNo { get; set; }
        public string KanalId { get; set; }
    }
}
