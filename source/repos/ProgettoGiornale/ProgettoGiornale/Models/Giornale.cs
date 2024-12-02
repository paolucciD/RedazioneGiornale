using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoGiornale.Models
{
    public class Giornale
    {
        private List<Articolo> Articoli { get; set; }

        public Giornale()
        {
            Articoli = new List<Articolo>();
        }

        public void AggiungiArticolo(Articolo ar)
        {
            Articoli.Add(ar);
        }

        public int TrovaArticolo(Articolo ar)
        {
            for (int i = 0; i < Articoli.Count; i++)
            {
                if (Articoli[i] == ar)
                {
                    return i;
                }
            }
            return -1;
        }

        public void CreaCommentoNormale(int indx, string t)
        {
            Commento c = new Commento(t);
            for (int i = 0; i < Articoli.Count; i++)
            {
                if (i == indx)
                {
                    Articoli[i].AggiungiCommento(c);
                }
            }
        }

        public void CreaCommentoRedazione(int indx, string t)
        {
            Commento c = new CommentoDellaRedazione(t);
            for (int i = 0; i < Articoli.Count; i++)
            {
                if (i == indx)
                {
                    Articoli[i].AggiungiCommento((CommentoDellaRedazione)c);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Articoli.Count; i++)
            {
                sb.AppendLine($"{Articoli[i].ToString()}");
            }
            return sb.ToString();
        }
    }
}