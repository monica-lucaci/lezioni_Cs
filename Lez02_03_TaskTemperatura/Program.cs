namespace Lez02_03_TaskTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float temp = 38.2f;


            //if (temp < 42.0f && temp > 35.0f && temp <= 37.5) {
            //    Console.WriteLine($"la tua temperatura e {temp} quindi pui entrare");

            //} else
            //{
            //    Console.WriteLine($"la tua temperatura e {temp} quindi hai la febbre e non puoi entrare");
            //}

            //if (temp <= 42.0f && temp >= 35.0f)
            //{
            //    Console.WriteLine($"la tua temperatura e {temp} quindi pui entrare");

            //} 
            //else
            //{
            //    Console.WriteLine($"la tua temperatura e {temp} quindi hai la febbre e non puoi entrare");
            //}

            // Console.WriteLine("inserisci la tua eta");
            //string? inputUtente = Console.ReadLine();


            //try
            // {
            //     int valoreConvertito = Convert.ToInt32(inputUtente);
            //     if (valoreConvertito >= 18)
            //         Console.WriteLine("sei maggiorene");
            //     else
            //         Console.WriteLine("sei minorenne");

            // } catch(FormatException ex) 
            // {
            //     Console.WriteLine($"errore di formato");
            // } catch(Exception ex) 
            // {
            //     Console.WriteLine($"Errore generico");
            // } finally 
            // {
            // Console.WriteLine("Programma terminato");
            // }


            // Console.ReadLine();




            string provincia = "BO";

            switch (provincia ) 
            {
                case "AQ":
                    Console.WriteLine("L'Aquila");
                    break;
                case "PE":
                    Console.WriteLine("pescara");
                    break;
                case "BO":
                    Console.WriteLine("Bologna");
                    break;
                default:
                    Console.WriteLine("non trovato");
                    break;
            }

        }
    }
}
 