﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez05_02_StaticiEreditari.Classes
{
    internal class Automobile : Giocattolo
    {
        public bool HasBatterie { get; set; }

        public Automobile()
        {
            
            Console.WriteLine($"[AUTOMOBILE] costruttore invocato, sono il giocattolo {Contatore}");
            
        }

    }
}
