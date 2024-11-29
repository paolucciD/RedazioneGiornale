using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoGiornale.Models
{
    public class Articolo: IEquals
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

        public void AggiungiCommento(Commento c)
        {
            this.Commenti.Add(c);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Titolo} di {this.Autore}");
            for(int i = 0; i < this.Commenti.Count;i++)
            {
                sb.Append($"\n {this.Commenti[i]}");
            }
            return sb.ToString();
        }

        public static bool operator ==(Articolo a1, Articolo a2)
        {
            return a1.Autore == a2.Autore && a1.Titolo == a2.Titolo;
        }

        public static bool operator !=(Articolo a1, Articolo a2)
        {
            return !(a1.Autore == a2.Autore && a1.Titolo == a2.Titolo);
        }
    }
}