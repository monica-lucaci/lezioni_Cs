namespace Lez03_06_ClassiEdOggetti
{
    internal class Program
    {

        


        static void Main(string[] args)
        {
            Bottiglia coca = new Bottiglia();
            coca.materiale = "PET";
            coca.colore = "trasparente";
            coca.diametro = 12.5f;
            coca.altezza = 25.0f;
            coca.contenuto = "cola";

            Console.WriteLine(coca.calcolaVolume());
            coca.stampaDettagli();


            Bottiglia acqua = new Bottiglia()
            {
                contenuto = "acqua",
                colore = "blu"
                
            };

        }
    }
}
