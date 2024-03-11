using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoEdicola.Classes
{
    internal class Sottoscrizione
    {
        public Cliente Cliente { get; set; }
        public Rivista Rivista { get; set; }
        public DateTime DataScadenza { get; set; }

    }
}
