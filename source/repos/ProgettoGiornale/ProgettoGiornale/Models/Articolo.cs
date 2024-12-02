using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoGiornale.Models
{
    public class Articolo : IEquatable<Articolo>
    {
        public string Titolo { get; set; }
        public string Autore { get; set; }
        private List<Commento> Commenti { get; set; }

        public Articolo(string t, string a)
        {
            Titolo = t;
            Autore = a;
            Commenti = new List<Commento>();
        }

        public void AggiungiCommento(Commento c)
        {
            Commenti.Add(c);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Titolo} di {Autore}");
            for (int i = 0; i < Commenti.Count; i++)
            {
                sb.Append($"\n {Commenti[i]}");
            }
            return sb.ToString();
        }

        //public static bool operator ==(Articolo a1, Articolo a2)
        //{
        //    return a1.Autore == a2.Autore && a1.Titolo == a2.Titolo;
        //}

        //public static bool operator !=(Articolo a1, Articolo a2)
        //{
        //    return !(a1.Autore == a2.Autore && a1.Titolo == a2.Titolo);
        //}

        public bool Equals(Articolo other)
        {
            if (other == null) return false;
            else
            {
                if (Titolo == other.Titolo && Autore == other.Autore) return true;
                else
                {
                    return false;
                }
            }
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Articolo other = obj as Articolo;
            if (other == null) return false;
            else
            {
                return Equals(other);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}