using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace anketodevi.Models
{   
    
    public class Soru
    {
        public Soru() {

            secildimi = false;
            
        }
        public int Id { get; set; }
        public string Tanim { get; set; }
        public string icerik { get; set; }
        public bool secildimi { get; set; }
    }
}