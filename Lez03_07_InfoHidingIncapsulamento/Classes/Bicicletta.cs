using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_07_InfoHidingIncapsulamento.Classes
{
    internal class Bicicletta
    {
        public string? Marca { get; set; }

        public string? Tipo { get; set; }
        public bool HasCampanello { get; set; } = false;

        public Bicicletta() 
        {
            Console.WriteLine("Costruttore di default invocato");  
        }

        public Bicicletta(string? marca, string? tipo, bool hasCampanello)
        {
            Marca = marca;
            Tipo = tipo;
            HasCampanello = hasCampanello;
            Console.WriteLine();
        }
    }
}
