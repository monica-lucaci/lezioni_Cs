using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez04_10_task.Classes
{
    internal class Casa
    {
        public string? Indirizzo { get; set; }
        private List<Stanza> elenco { get; set; } = new List<Stanza>();

        public void aggiungi(Stanza stz)
        {
            elenco.Add(stz);
        }




    }
}
