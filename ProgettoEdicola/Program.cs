using ProgettoEdicola.Classes;

namespace ProgettoEdicola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pubblicazioni uno = new Rivista("Popcorn", 5f, "A123", new DateTime(2024, 01, 10), false, "moda");
            Pubblicazioni due = new Giornale(2.3f, "A123", "Gazeta", new DateTime(2024, 02, 29), false, "news");
            Pubblicazioni tre = new Rivista("magazine", 2.3f, "A123", new DateTime(2024, 03, 11), true, "scandal");
            Pubblicazioni quattro = new Giornale(2.3f, "A123", "Gazeta", new DateTime(2022, 10, 12), true, "sport");
            Pubblicazioni cinque = new Giornale(2.3f, "A123", "HELLO", new DateTime(2022, 10, 12), true, "qualcoaa");
            Pubblicazioni sei = new Rivista("magazine", 2.3f, "A123", new DateTime(2024, 03, 04), true, "scandal");
            Pubblicazioni sette = new Rivista("magazine", 2.3f, "A123", new DateTime(2024, 04, 04), true, "scandal");



            Edicola laMiaEdicola = new Edicola("The best Edicola", "via Cristoforo 112");

            laMiaEdicola.Aggiungi(uno);
            laMiaEdicola.Aggiungi(due);
            laMiaEdicola.Aggiungi(tre);
            laMiaEdicola.Aggiungi(quattro);
            laMiaEdicola.Aggiungi(cinque);
            laMiaEdicola.Aggiungi(sei);
            laMiaEdicola.Aggiungi(sette);


            //laMiaEdicola.ElencoPubblicazioni();


            //laMiaEdicola.Rimuovi(tre);

            //laMiaEdicola.ElencoPubblicazioni();


            // laMiaEdicola.Aggiorna(due);

            //laMiaEdicola.VendiPubblicazione(sei,1);
            //laMiaEdicola.VendiPubblicazione(sette, 1);
            //laMiaEdicola.VendiPubblicazione(quattro, 1);
            //laMiaEdicola.VendiPubblicazione(quattro, 1);
            //laMiaEdicola.VisualizzaStoricoVenditePerPubblicazione("giornale");
            //laMiaEdicola.VisualizzaStoricoVenditePerCategoria("scandal");
            //laMiaEdicola.VisualizzaStoricoVenditePerData(new DateTime(2024, 03, 10));
            //laMiaEdicola.ElencoPubblicazioni();

            //laMiaEdicola.CercaPerTitolo("magazine");

            //laMiaEdicola.FiltraPerDisponibilita();
            //laMiaEdicola.FiltraPerTermineRicerca("scandal");


            Cliente cliente1 = new Cliente("Mario", "Rossi", 31);
           
            DateTime dataScadenza1 = DateTime.Now.AddMonths(6); 
            Cliente cliente2 = new Cliente("Giulia", "Verdi", 28);
            Cliente cliente3 = new Cliente("Monica", "Monica", 32);
            DateTime dataScadenza2 = DateTime.Now.AddMonths(12);

            laMiaEdicola.SottoscriviRivista(cliente1, (Rivista)tre, dataScadenza1);
            laMiaEdicola.SottoscriviRivista(cliente2, (Rivista)tre, dataScadenza2);

            Rivista nuovaEdizione = (Rivista)tre;
            DateTime dataPubblicazione = DateTime.Now;
            laMiaEdicola.ConsegnaNuovaEdizione(nuovaEdizione, dataPubblicazione);
        }

    }
    }

