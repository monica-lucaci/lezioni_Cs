using lez04_05_taskUtilizzo.Classes;

namespace lez04_05_taskUtilizzo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona Monica = new Persona()
            {
                Nome = "Maria",
                Cognome = "Lucaci",
                Cf = new CodiceFiscale()
                {
                    CF = "LCCNRM56Z12314",
                    DataScadenza = "12.12.28"
                },
                CartaIdentita = new CartaIdentita()
                {
                    Codice = "CA12345",
                    DataScadenza = "12.12.30",

                }
            };
        }
    }
}
