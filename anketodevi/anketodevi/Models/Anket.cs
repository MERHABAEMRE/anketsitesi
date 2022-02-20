using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace anketodevi.Models
{
    public class Anket
    {
        public  int SoruId { get; set; }
        public  List<Soru> sorulist { get; set; }
    }
}