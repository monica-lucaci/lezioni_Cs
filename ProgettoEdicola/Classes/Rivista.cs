using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoEdicola.Classes
{
    internal class Rivista : Pubblicazioni
    {
        public string? Tipo { get; set; }

        protected static int quantitaRiviste;


        //COSTRUTTORE
        public Rivista(string? titolo, DateTime dataPubblicazione, bool hasDisponibilita, string? tipo)
        {
            Titolo = titolo;
            DataPubblicazione = dataPubblicazione;
            HasDisponibilita = hasDisponibilita;
            Tipo = tipo;
            quantitaRiviste++;
        }


        public static int QuantitaRiviste
        {
            get { return quantitaRiviste; }
        }



        public override void stampaDettagli()
        {
            Console.WriteLine($"[RIVISTA] {Titolo} {HasDisponibilita} {QuantitaRiviste}");
        }




    }
}
