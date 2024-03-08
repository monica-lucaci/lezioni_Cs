using Lez05_02_StaticiEreditari.Classes;

namespace Lez05_02_StaticiEreditari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Giocattolo auto1 = new Automobile();
            Giocattolo auto2 = new Automobile();
            Giocattolo tren = new Trenino();

            Console.WriteLine(Giocattolo.Contatore);

            List<Giocattolo> elenco = new List<Giocattolo>();
            elenco.Add(auto1);
            elenco.Add(auto2);
            elenco.Add(tren);

            foreach(Giocattolo gio in elenco)
            {
               if(gio.GetType() == typeof(Trenino))
                {
                    Trenino temp = (Trenino)gio;
                    temp.rumoreTrenino();
                }
            }  



        }
    }
}
