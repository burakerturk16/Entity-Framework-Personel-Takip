using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfPersonelOtomasyonu
{
  public  class Personeller
    {  
        [Key]
        public Guid PerID { get; set; }
        public string PerAdi { get; set; }
        public string PerSoyad { get; set; }
        public string PerEmail { get; set; }
        public string PerTelno { get; set; }
    }
}

