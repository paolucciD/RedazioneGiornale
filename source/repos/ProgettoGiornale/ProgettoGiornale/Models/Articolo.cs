using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoGiornale.Models
{
    public class Articolo
    {
        public string Titolo { get; set; }
        public string Autore { get; set; }
        private List<Commento> Commenti { get; set; }

        public Articolo(string t, string a)
        {
            this.Titolo = t;
            this.Autore = a;
            this.Commenti = new List<Commento>();
        }

        p
    }
}