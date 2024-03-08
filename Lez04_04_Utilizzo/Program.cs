namespace Lez04_04_Utilizzo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indirizzo indi = new Indirizzo()
            //{
            //    Via = "via le mani dal naso",
            //    Cap = "11111",
            //    Citta = "farindola",
            //    Provincia = "CH"
            //};
            Utente gio = new Utente()
            {
                Nominativo = "Giovanni Pace",
                Spedizione = new Indirizzo()
                {
                    Via = "via le mani dal naso",
                    Cap = "11111",
                    Citta = "farindola",
                    Provincia = "CH"
                },
                Fatturazione = new Indirizzo ()
                {
                    Via = "'piazza la bomba e scappa'",
                    Cap = "85966",
                    Citta = "Roccacannuccia",
                    Provincia = "CH"
                }
        };
            Console.WriteLine(gio);
        }
    }
}
