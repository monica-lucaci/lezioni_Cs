using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez04_taskRoomAndObject.Classes
{
    internal class Oggetto
    {
        public string Name { get; }
        public string Description { get; }
        public int Value { get; }

        public Oggetto(string name, string description, int value)
        {
            Name = name;
            Description = description;
            Value = value;
        }

        public override string ToString()
        {
            return $"[OGGETTO] {Name} - {Description} - Valore: {Value}";
        }
    }
}
