using Lez05_01_Statici.Classes;

namespace Lez05_01_Statici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automobile autoUno = new Automobile("Blu");
            Automobile autoDue = new Automobile("Gialla");

            Console.WriteLine(Automobile.Contatore);

            Automobile.stampaContattore(); 
        
        }
    }
}
