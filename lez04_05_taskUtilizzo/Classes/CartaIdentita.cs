﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez04_05_taskUtilizzo.Classes
{
    internal class CartaIdentita : CodiceFiscale
    {

      
        public DateTime DataEmissione { get; set; }

        private string? luogoEmissione;

        public string? LuogoEmissione
        {
            get { return luogoEmissione; }
            set
            {
                if(value is not null && (value.Equals("Comune") || value.Equals("Zecca dello stato")))
                    luogoEmissione = value; 
            }
        }



        public override string? ToString()
        {
            return $"[ID]  {DataEmissione} ";
        }


    }
}
