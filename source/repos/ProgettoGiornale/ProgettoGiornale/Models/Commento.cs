﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoGiornale.Models
{
    public class Commento
    {
        public string Testo { get; set; }

        public Commento(string t)
        {
            Testo = t;
        }

        public override string ToString()
        {
            return Testo;
        }
    }
}