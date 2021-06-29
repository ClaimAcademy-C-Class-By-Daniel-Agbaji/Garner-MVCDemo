using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudioMVC.Entities
{
    public class Audio
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Amps { get; set; }
        public string Dac { get; set; }
        public string Headphones { get; set; }
        public string Iem { get; set; }
    }
}
