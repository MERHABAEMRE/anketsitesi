using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace anketodevi.Models
{
    public class Anketlistesi
    {
        public int AnketId { get; set; }
        public List<Anket> Anketlist { get; set; }
    }
}