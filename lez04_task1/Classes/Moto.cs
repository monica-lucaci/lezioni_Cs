using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez04_task1.Classes
{
    internal class Moto : Veicoli
    {
        //public Moto(string? marca, int prezzo, string? colore)
        //{
        //    Marca = marca;
        //    Prezzo = prezzo;
        //    Colore = colore;
        //}

        public bool  HasPortaPacchi { get; set; }

        public override string? ToString()
        {
            Console.WriteLine($"{ HasPortaPacchi} {Marca} {Colore}")
        }


    }
}
