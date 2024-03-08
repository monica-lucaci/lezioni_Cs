using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez04_05_taskUtilizzo.Classes
{
    internal class CodiceFiscale
    {
        public string? Codice { get; set; }
        public DateTime? DataScadenza { get; set; }

        public override string? ToString()
        {
            return $"[CODICEFISCALE] {Codice} {DataScadenza}";
        }
    }
}
