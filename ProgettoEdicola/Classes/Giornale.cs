using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoEdicola.Classes
{
    internal class Giornale : Pubblicazioni
    {
        public string? Tipo { get; set; }

        protected static int quantitaGiornali;

        public Giornale(string? titolo, DateTime dataPubblicazione, bool hasDisponibilita, string? tipo)
        {
            Titolo = titolo;
            DataPubblicazione = dataPubblicazione;
            HasDisponibilita = hasDisponibilita;
            Tipo = tipo;
            quantitaGiornali++;

        }

        public static int QuantitaGiornali
        {
            get { return quantitaGiornali; }
        }

        public override void stampaDettagli()
        {
            Console.WriteLine($"[GIORNALE] {Titolo} {HasDisponibilita} {QuantitaGiornali}");
        }
    }


}
