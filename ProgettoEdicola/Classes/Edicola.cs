using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoEdicola.Classes
{
    internal class Edicola
    {
        public string? Nome {  get; set; }
        protected List<Pubblicazioni> elenco { get; set; } = new List<Pubblicazioni>();

        public Edicola(string? nome)
        {
            Nome = nome;
        }

        public void Aggiungi(Pubblicazioni pub)
        {
            elenco.Add(pub);
        }

        public void rimuovi(Pubblicazioni pub)
        {
            elenco.Remove(pub);
        }

        public void aggiorna(Pubblicazioni pub)
        {
           
        }

        public void elencoPubblicazioni()
        {
            Console.WriteLine($"------- EDICOLA: {Nome} ----------");
            foreach (Pubblicazioni pub in elenco)
            {
                pub.stampaDettagli();
            }
        }


    }
}
