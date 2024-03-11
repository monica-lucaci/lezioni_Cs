using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoEdicola.Classes
{
    internal class Rivista : Pubblicazioni
    {
        //ATTRIBUTI
        public string? Categoria { get; set; }

        protected static int QuantitaRiviste { get; set; } = 0;

        //COSTRUTTORE
        public Rivista(string? titolo, float prezzo, string? codice, DateTime dataPubblicazione, bool hasDisponibilita, string? categoria)
        {
            Titolo = titolo;
            Prezzo = prezzo;
            Codice = codice;
            DataPubblicazione = dataPubblicazione;
            HasDisponibilita = hasDisponibilita;
            Categoria = categoria;
            QuantitaRiviste++;
            QuantitaDisponibile = 1;
        }

        //METODI
      
        public override void StampaDettagli()
        {
            Console.WriteLine($"[RIVISTA] {Titolo} {Prezzo} {Categoria} {HasDisponibilita} {QuantitaRiviste}");
        }
        public void DiminuisciRiviste()
        {
            QuantitaRiviste--;
        }




    }
}
