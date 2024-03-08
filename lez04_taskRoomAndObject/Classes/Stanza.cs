using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace lez04_taskRoomAndObject.Classes
{
    internal class Stanza
    {
        public string Name { get; }
        private List<Oggetto> objects;

        public Stanza(string name)
        {
            Name = name;
            objects = new List<Oggetto>();
        }

        public void Aggiungi(Oggetto obj)
        {
            objects.Add(obj);
        }

        public override string ToString()
        {
            string result = $"[STANZA] {Name}:";
            foreach (Oggetto obj in objects)
            {
                result += $"\n- {obj}";
            }
            return result;
        }


    }
}
