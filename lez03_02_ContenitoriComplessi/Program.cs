namespace lez03_02_ContenitoriComplessi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] stuUno = { "Giovanni Pace", "AB12345", " PCAGNN" };
            //string[] stuDue = { "Valeria Verdi", "AB12346", " VLRVRD" };
            //string[] stuTre = { "Mario Rossi", "AB12347", " MRRRSS" };


            //string[][] elenco = { stuUno, stuDue, stuTre };

            //Console.WriteLine("codice fiscale:");
            //string? cf = Console.ReadLine();


            //for (int i = 0; i < elenco.Length; i++)
            //{



            //    if (cf is not null && elenco[i][2].ToUpper().Equals(cf.ToUpper().Trim()))
            //    {
            //        Console.WriteLine($"nome: {elenco[i][0]}\n Matricola: {elenco[i][1]}");
            //    }

            //    }
            //}


            string[] libro_1 = { "Il signore degli anelli", "JRRT", "123456-1225", "Casa ed 1" };
            string[] libro_2 = { "Il ritorno del re", "JRRT", "123456-1226", "Casa ed 1" };
            string[] libro_3 = { "Il visconte dimezzato", "I.Calvino", "987456-1225", "Casone editrice" };
            string[] libro_4 = { "Storia del buongiorno", "A. Christie", "456466-1225", "Casone editrice" };
            string[] libro_5 = { "Le due torri", "JRRT", "456463-1225", "Casa ed 1" };

            string[][] store = { libro_1, libro_2, libro_3, libro_4, libro_5 };

             Console.WriteLine("inserisci un autore:");
            string? autore = Console.ReadLine();

            int numeroLibri = 0;
            for (int i = 0; i < store.Length; i++)
            {

                if (autore is not null  && store[i][1].ToUpper().Equals(autore.ToUpper().Trim()))
                {
                    numeroLibri++;

                }
            }
            Console.WriteLine(numeroLibri);
            }

        }
    }

