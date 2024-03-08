using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez05_02_StaticiEreditari.Classes
{
    internal abstract class Giocattolo
    {
        public string? Materiale { get; set; }
        public int EtaMinima { get; set; } = 3;

        //public static int Contatore { get; private set; } = 0;


        //si usa protected in modo che gli eredi possono ereditare l'attributo ma non dall'esterno.
        protected static int contatore; //attributi private non vengono ereditati

        //si mette static in modo da essere disponibile da subito, se non lo metto devo usare "new"
        public static int Contatore
        {
            get { return contatore; }
            set { contatore = value; }  // - si toglie il set 
        }

          
        public Giocattolo()
        {
            Console.WriteLine("[GIOCATTOLO] Costruttore invocato");
            Contatore++;
        }
    }
}
