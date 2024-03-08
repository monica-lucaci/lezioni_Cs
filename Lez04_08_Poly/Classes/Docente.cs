using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez04_08_Poly.Classes
{
    internal class Docente : Persona
    {
        public string? Materia { get; set; }
        public string? Dipartimento { get; set; }

        public Docente(string? nome, string? cognome, string? dipartimento, string? materia)
        {
             
        }
    }
}
