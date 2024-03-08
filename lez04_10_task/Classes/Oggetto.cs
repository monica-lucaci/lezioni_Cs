using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez04_10_task.Classes
{
    internal abstract class Oggetto : Stanza
    {

        public string? Description { get; set; }

        public int Valore { get; set; }

        public Oggetto(string? name, string? description, int valore)
        {
            Name = name;
            Description = description;
            Valore = valore;

        }

        public override void stampaDettaglio()
        {
            Console.WriteLine($"[OGGETTO] {Name} {Description} {Valore}");
        }



    }
}
