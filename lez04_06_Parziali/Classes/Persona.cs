﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez04_06_Parziali.Classes
{

    internal partial class Persona
    {
        public string? CodiceFiscale { get; set; }

        public override string ToString()
        {
            return $"[PERSONA] {Nome} {Cognome} {CodiceFiscale}";
        }

    }
    internal partial class Persona
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
    };
}
