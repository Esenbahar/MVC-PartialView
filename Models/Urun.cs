using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace mvcintermediate.Models
{
    public class Urun 
    {
        public int UrunId { get; set; }
        public String UrunAdi { get; set; }
        public String Aciklama { get; set; }
        public double Fiyat { get; set; }
        public bool Satistami { get; set; }

        
    }
}