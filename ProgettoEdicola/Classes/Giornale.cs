using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoEdicola.Classes
{
    internal class Giornale : Pubblicazioni
    {
        //ATTRIBUTI
        public string? Redazione { get; set; }

        protected static int QuantitaGiornali { get; set; } = 0;

        //COSTRUTTORE
        public Giornale(float prezzo, string? codice, string? titolo, DateTime dataPubblicazione, bool hasDisponibilita, string? redazione)
        {  
            Prezzo = prezzo;
            Codice = codice;
            Titolo = titolo;
            DataPubblicazione = dataPubblicazione;
            HasDisponibilita = hasDisponibilita;
            Redazione = redazione;
            QuantitaGiornali++;
            QuantitaDisponibile = 1;

        }
        public override void StampaDettagli()
        {
            Console.WriteLine($"[GIORNALE] {Titolo} {Redazione} {Prezzo} {HasDisponibilita} {QuantitaGiornali}");
        }

        public void DiminuisciGiornali()
        {
            QuantitaGiornali--;
        }
    
    }


}
