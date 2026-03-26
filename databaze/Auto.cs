using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databaze
{
    public class Auto
    {
        public int Id { get; set; }
        public string Znacka { get; set; }
        public string ModelAuta { get; set; }
        public int RokVyroby { get; set; }
        public string Karoserie { get; set; }
        public int VykonKw { get; set; }
        public bool Mam { get; set; }
    }
}
