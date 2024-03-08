using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_07_InfoHidingIncapsulamento.Classes
{
    internal class Monopattino
    {
        public string? Marca { private get; set; }

        public  float VelMax { get; } = 24.0f;

        private int numPersone;

        public int NumPersone
        {
            get { return numPersone; }
            set {
                if (value >= 0)
                    numPersone = value;
                else
                    Console.WriteLine();
                 }
        }

    }
}
