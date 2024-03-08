using lez04_taskRoomAndObject.Classes;
using System.Runtime.InteropServices.Marshalling;

namespace lez04_taskRoomAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creazione delle stanze
            Stanza cucina = new Stanza("Cucina");
            Stanza soggiorno = new Stanza("Soggiorno");
            Stanza dormitorio = new Stanza("Camera da letto");

            // Aggiunta degli oggetti alle stanze
            cucina.Aggiungi(new Oggetto("Tostapane", "Bianco e utile", 80));
            cucina.Aggiungi(new Oggetto("Frullatore", "nero", 30));
            soggiorno.Aggiungi(new Oggetto("Divano", "Comodo", 1000));
            soggiorno.Aggiungi(new Oggetto("TV", "Come perdere tempo che non hai", 500));
            dormitorio.Aggiungi(new Oggetto("Letto", "cosi puoi dormire", 700));
            dormitorio.Aggiungi(new Oggetto("Comodino", "appoggia cose che non sai dove mettere", 100));

            // Visualizzazione delle informazioni sulle stanze
            Console.WriteLine("----- Le tue stanze -----");
            Console.WriteLine($"{cucina}\n{soggiorno}\n{dormitorio}");



        }
    }
}
