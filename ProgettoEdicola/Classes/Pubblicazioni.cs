using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoEdicola.Classes
{
    internal abstract class Pubblicazioni
    {
        
        public float Prezzo {  get; set; }
        public string? Codice {  get; set; }
        public string? Titolo {  get; set; }
        public DateTime DataPubblicazione { get; set; }

        public bool HasDisponibilita { get; set; }

        //protected static int quantita;

        protected int QuantitaDisponibile { get; set; }

        //metodi
        //public static int Quantita
        //{
        //    get { return quantita; }
        //}

        public Pubblicazioni()
        {
            Console.WriteLine("[PUBBLICAZIONE] costruttore invocato");
            QuantitaDisponibile++;
        }

        

        public abstract void StampaDettagli();

        public void Vendita(int quantita)
        {
            if (HasDisponibilita && QuantitaDisponibile >= quantita)
            {
                QuantitaDisponibile -= quantita;
                Console.WriteLine($"Vendute {quantita} copie di {Titolo}");
            }
            else
            {
                Console.WriteLine($"Non ci sono abbastanza copie disponibili di {Titolo} per soddisfare la richiesta.");
            }
        }


    }
}
