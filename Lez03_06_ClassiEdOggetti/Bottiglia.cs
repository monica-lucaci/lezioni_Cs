﻿using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_06_ClassiEdOggetti
{
    internal class Bottiglia
    {
        public string? materiale;
        public string? colore;
        public float diametro; 
        public float altezza;
        public string? contenuto;
        public float calcolaVolume()
        {
            float raggio = diametro / 2;
            float area = (float)Math.PI * (raggio * raggio);
            return area * altezza;

        }

        public void stampaDettagli()
        {
            Console.WriteLine($"{materiale} {colore} {diametro} {altezza} {contenuto}");
        }

    }
}
