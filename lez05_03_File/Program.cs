namespace lez05_03_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "\\Users\\utente\\Desktop\\test.txt";

            //string path = Path.GetDirectoryName(typeof(Program).Assembly.Location);

            string contenuto = "Ciao Giovanni Pace";

            contenuto = "Ciao Mario Rossi";

            //SCRITTURA

            //try
            //{
            //    if (path is not null)
            //    {
            //        using (StreamWriter sw = new StreamWriter(path))
            //        {
            //            sw.WriteLine(contenuto);
            //            sw.WriteLine("CIAO");
            //            sw.WriteLine("Hello");
                        

            //        }

            //        Console.WriteLine("Tutto ok!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}



            //LETTURA

            try
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    string? line;

                    while ((line = sr.ReadLine()) != null )
                    {
                        Console.WriteLine(line);
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
        }
    }
}
