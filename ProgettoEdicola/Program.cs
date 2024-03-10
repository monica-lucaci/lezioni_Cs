using ProgettoEdicola.Classes;

namespace ProgettoEdicola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pubblicazioni uno = new Rivista("Popcorn",new DateTime(2024, 01, 10), true, "moda");
            Pubblicazioni due = new Giornale("Gazeta",new DateTime(2024,02,29),true,"news");
            Pubblicazioni tre = new Rivista ("magazine",new DateTime(2024,03,04), true,"scandal");
            Pubblicazioni quattro = new Giornale("Gazeta", new DateTime(2022, 10, 12), true, "sport");


            Edicola laMiaEdicola = new Edicola("The best Edicola");

            laMiaEdicola.Aggiungi(uno);
            laMiaEdicola.Aggiungi(due);
            laMiaEdicola.Aggiungi(tre);
            laMiaEdicola.Aggiungi(quattro);


            laMiaEdicola.elencoPubblicazioni();


            //lamiaedicola.rimuovi(due);

            //lamiaedicola.elencopubblicazioni();

        }
    }
}
