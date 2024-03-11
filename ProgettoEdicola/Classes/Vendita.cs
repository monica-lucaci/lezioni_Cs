using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoEdicola.Classes
{
    internal class Vendita
    {
        public Pubblicazioni? PubblicazioneVenduta { get; set; }
        public DateTime DataVendita { get; set; }
        public int Quantita { get; set; }
    }
}
