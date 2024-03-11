using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoEdicola.Classes
{
    internal class Edicola
    {
        //ATTRIBUTI
        public string? Nome { get; set; }
        public string? Indirizzo { get; set; }

        //LISTS
        protected List<Pubblicazioni> elenco { get; set; } = new List<Pubblicazioni>();
        protected List<Vendita> storicoVendite { get; set; } = new List<Vendita>();

        protected List<Sottoscrizione> sottoscrizioni = new List<Sottoscrizione>();

        //COSTRUTTORE
        public Edicola(string? nome, string? indirizzo)
        {
            Nome = nome;
            Indirizzo = indirizzo;
        }

        //METODI

        //1. Gestione dell'Inventario:
        public void Aggiungi(Pubblicazioni pub)
        {
            elenco.Add(pub);

        }

        public void Rimuovi(Pubblicazioni pub)
        {
            elenco.Remove(pub);
            if (pub.GetType() == typeof(Giornale))
            {
                Giornale temp = (Giornale)pub;

                temp.DiminuisciGiornali();
            }
            else if (pub.GetType() == typeof(Rivista))
            {
                Rivista temp = (Rivista)pub;

                temp.DiminuisciRiviste();
            }
        }

        public void Aggiorna(Pubblicazioni pub)
        {
            Console.WriteLine("Inserisci il nuovo prezzo: ");
            double nuovoPrezzo = Convert.ToDouble(Console.ReadLine());
            pub.Prezzo = (float)nuovoPrezzo;

            Console.WriteLine("Inserisci il nuovo titolo: ");
            string? nuovoTitolo = Console.ReadLine();
            pub.Titolo = nuovoTitolo;

            Console.WriteLine("Inserisci la nuova data di pubblicazione (AAAA-MM-GG): ");
            DateTime nuovaData = Convert.ToDateTime(Console.ReadLine());
            pub.DataPubblicazione = nuovaData;

            Console.WriteLine("La pubblicazione è disponibile? (true/false): ");
            bool nuovaDisponibilita = Convert.ToBoolean(Console.ReadLine());
            pub.HasDisponibilita = nuovaDisponibilita;

            Console.WriteLine("Pubblicazione aggiornata con successo.");

            //VERIFICA SE E GIORNALE O RIVISTA E FAI AGGIORNAMENTI SPECIFICI PER OGNIUNA


        }

        public void ElencoPubblicazioni()
        {
            Console.WriteLine($"------- EDICOLA: {Nome} ----------");
            foreach (Pubblicazioni pub in elenco)
            {
                pub.StampaDettagli();
            }
        }


        //2. Gestione delle Vendite:
        //vendita di una pubblicazione
        public void VendiPubblicazione(Pubblicazioni pub, int quantita)
        {
            pub.Vendita(quantita);
            elenco.Remove(pub);
            if (pub.GetType() == typeof(Giornale))
            {
                Giornale temp = (Giornale)pub;

                temp.DiminuisciGiornali();
            }
            else if (pub.GetType() == typeof(Rivista))
            {
                Rivista temp = (Rivista)pub;

                temp.DiminuisciRiviste();
            }
            storicoVendite.Add(new Vendita
            {
                PubblicazioneVenduta = pub,
                DataVendita = DateTime.Now,
                Quantita = quantita });
        }

        // storico delle vendite per categoria - solo nella rivista
        public void VisualizzaStoricoVenditePerCategoria(string categoria)
        {
            foreach (Vendita vendita in storicoVendite)


            {   //typeof
                if (vendita.PubblicazioneVenduta is Rivista && ((Rivista)vendita.PubblicazioneVenduta).Categoria == categoria)
                {
                    Console.WriteLine($"Data: {vendita.DataVendita}, Pubblicazione: {vendita.PubblicazioneVenduta.Titolo}, Quantità: {vendita.Quantita}");
                } else
                    Console.WriteLine("nessuna vendita per questa categoria");
            }
        }

        //storico vendite per pubblicazione
        public void VisualizzaStoricoVenditePerPubblicazione(string pubblicazione)
        {
            foreach (Vendita vendita in storicoVendite)
            {   //typeof
                if (vendita.PubblicazioneVenduta is Rivista && pubblicazione.ToLower() is "rivista")
                {
                    Console.WriteLine($" Hai venduto {vendita.Quantita} Riviste in data: {vendita.DataVendita}," +
                        $" Rivista: {vendita.PubblicazioneVenduta.Titolo}");

                } else if (vendita.PubblicazioneVenduta is Giornale && pubblicazione.ToLower() is "giornale")
                {
                    Console.WriteLine($" hai venduto {vendita.Quantita} Giornali in data: {vendita.DataVendita}," +
                        $" Giornale: {vendita.PubblicazioneVenduta.Titolo} ");
                }
                else
                    Console.WriteLine("nessuna vendita di questa pubblicazione");
            }
        }

        //storico endite per data
        public void VisualizzaStoricoVenditePerData(DateTime data)
        {
            foreach (Vendita vendita in storicoVendite)
            {
                if (vendita.DataVendita.Date == data.Date)
                {
                    Console.WriteLine($"In data: {vendita.DataVendita.Date}," +
                        $" hai venduto {vendita.Quantita}" +
                        $" Pubblicazione: {vendita.PubblicazioneVenduta.Titolo} ");

                } else
                    Console.WriteLine("nessuna vendita trovata per questa data ");
            }
        }


        //3. Ricerca e Filtraggio:
        //creazioni di liste 


        //Cercare le pubblicazioni per titolo

        public void CercaPerTitolo(string titolo)
        {
            List<Pubblicazioni> risultati = new List<Pubblicazioni>();
            foreach (Pubblicazioni pub in elenco)
            {
                if (pub.Titolo != null && pub.Titolo.ToLower().Contains(titolo.ToLower()))
                {
                    risultati.Add(pub);
                }
            }

            if (risultati.Count > 0)
            {
                Console.WriteLine($"Risultati della ricerca per il titolo '{titolo}':");
                foreach (Pubblicazioni pub in risultati)
                {
                    Console.WriteLine($"- Titolo: {pub.Titolo}, Prezzo: {pub.Prezzo}, Data di pubblicazione: {pub.DataPubblicazione}");
                }
            }
            else
            {
                Console.WriteLine($"Nessuna pubblicazione trovata con il titolo '{titolo}'.");
            }
        }

        //ricerca per data simile a titolo


        //ricerca per categoria-prima si verifica che sia una rivista e poi si procede con la ricerca;

        public void FiltraPerDisponibilita()
        {
            Console.WriteLine("Pubblicazioni disponibili:");
            foreach (Pubblicazioni pub in elenco)
            {
                if (pub.HasDisponibilita)
                {
                    pub.StampaDettagli();
                }
            }
        }

        //filtra per termine di ricerca

        public void FiltraPerTermineRicerca(string termineRicerca)
        {
            List<Pubblicazioni> risultati = new List<Pubblicazioni>();

            foreach (Pubblicazioni pub in elenco)
            {
                if (pub.Titolo != null && pub.Titolo.ToLower().Contains(termineRicerca.ToLower()))
                {
                    risultati.Add(pub);
                }
                else if (pub.Codice != null && pub.Codice.ToLower().Contains(termineRicerca.ToLower()))
                {
                    risultati.Add(pub);
                }
                else if (pub.DataPubblicazione.ToString("yyyy-MM-dd").Contains(termineRicerca.ToLower()))
                {
                    risultati.Add(pub);
                }
                else if (pub is Giornale giornale && giornale.Redazione != null && giornale.Redazione.ToLower().Contains(termineRicerca.ToLower()))
                {
                    risultati.Add(pub);
                }
                else if (pub is Rivista rivista && rivista.Categoria != null && rivista.Categoria.ToLower().Contains(termineRicerca.ToLower()))
                {
                    risultati.Add(pub);
                }
                else if (pub.Prezzo.ToString().Contains(termineRicerca))
                {
                    risultati.Add(pub);
                }
                else if (pub.HasDisponibilita.ToString().ToLower() == termineRicerca.ToLower())
                {
                    risultati.Add(pub);
                }
            }

            if (risultati.Count > 0)
            {
                Console.WriteLine($"Risultati della ricerca per '{termineRicerca}':");
                foreach (Pubblicazioni pub in risultati)
                {
                    pub.StampaDettagli();
                }
            }
            else
            {
                Console.WriteLine($"Nessun risultato trovato per '{termineRicerca}'.");
            }
        }


        //4. Gestione delle Sottoscrizioni:
        public void SottoscriviRivista(Cliente cliente, Rivista rivista, DateTime dataScadenza)
        {
            sottoscrizioni.Add(new Sottoscrizione
            { Cliente = cliente,
                Rivista = rivista,
                DataScadenza = dataScadenza
            });
        }


        public void ConsegnaNuovaEdizione(Rivista rivista,DateTime dataPubblicazione)
        {
            foreach(Sottoscrizione sottoscrizione in sottoscrizioni)

            {
                Console.WriteLine($"Sottoscrizione: {sottoscrizione.Rivista.Titolo}, Data di scadenza: {sottoscrizione.DataScadenza}");

                if (sottoscrizione.Rivista == rivista && sottoscrizione.DataScadenza >= dataPubblicazione)
                {
                    Console.WriteLine($"Consegna nuova edizione della rivista '{rivista.Titolo}' a {sottoscrizione.Cliente.Nome}");
                }
            }
        }




    }
   
}
