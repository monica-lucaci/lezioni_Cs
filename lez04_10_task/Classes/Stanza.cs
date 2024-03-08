using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez04_10_task.Classes
{
    internal class Stanza 
    {
        public string? Name { get; set; }
        public Stanza() { } 

   
        public virtual void stampaDettaglio()
        {
            Console.WriteLine($"[Stanza]{Name}");
        }
    }
}
