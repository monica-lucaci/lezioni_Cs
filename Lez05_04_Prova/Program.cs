using Lez05_04_Prova.Classes;

namespace Lez05_04_Prova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona gio = new Persona("Giovanni", "Pace", "PCAGNN");
            Persona val = new Persona("Giovanni", "Pace", "PCAGNN");
            Persona mon = new Persona("Giovanni", "Pace", "PCAGNN");

            string path = "C:\\Users\\utente\\Desktop\\file.txt";

            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(gio.esportaCsv());
                    sw.WriteLine(val.esportaCsv());
                    sw.WriteLine(mon.esportaCsv());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
