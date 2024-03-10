using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoEdicola.Classes
{
    internal abstract class Pubblicazioni
    {
        
        public string? Titolo {  get; set; }
        public DateTime DataPubblicazione { get; set; }

        public bool HasDisponibilita { get; set; }

        protected static int quantita;


        //metodi
        public static int Quantita
        {
            get { return quantita; }
        }

        public Pubblicazioni()
        {
            Console.WriteLine("[PUBBLICAZIONE] costruttore invocato");
            quantita++;
        }

        public virtual void stampaDettagli()
        {
            Console.WriteLine($"[PUBBLICAZIONI] {Titolo} {HasDisponibilita} {Quantita}");
        }


    }
}
