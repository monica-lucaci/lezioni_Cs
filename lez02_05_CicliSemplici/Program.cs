namespace lez02_05_CicliSemplici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * while(condizione){
             *         //corpo da eseguire
             * }
             * 
             * 
             * 
             */

            //int indice = 0;

            //while (indice < 5)
            //{
            //    Console.WriteLine("CIAO");

            //    indice++;
            //}

            //bool inserimentoAbilitato = true;

            //while (inserimentoAbilitato)
            //   {
            //       Console.WriteLine("inserisci il tuo nome o digita q per uscire");
            //       string? inputUtente = Console.ReadLine();

            //       if (inputUtente != null && inputUtente.Equals("Q"))
            //           inserimentoAbilitato = false;
            //       else
            //           Console.WriteLine($"Ciao {inputUtente}");
            //   }


            bool invitato = true;
            string lista = "";

            while (invitato)
            {
                Console.WriteLine("se vuoi essere invitato inserisci i dettagli richiesti oppure digita Q per uscire ");
                string? scelta = Console.ReadLine();

                if (scelta != null && scelta.Equals("Q"))
                {
                    invitato = false;
                }else
                {
                    Console.WriteLine($"scrivi il tuo nome");
                    string? nome = Console.ReadLine();
                    Console.WriteLine($"scrivi il tuo cognome");
                    string? cognome = Console.ReadLine();
                    string fullname = nome + " " + cognome;
             
                    lista = lista + fullname + ",";

                }
                    Console.WriteLine(lista);




            }










             
        }
    }
}
