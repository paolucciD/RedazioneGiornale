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
            this.Articoli = new List<Articolo>();
        }

        public void AggiungiArticolo(Articolo ar)
        {
            this.Articoli.Add(ar);
        }

        public int TrovaArticolo (Articolo ar)
        {
            for (int i = 0; i < this.Articoli.Count; i++)
            {
                if (this.Articoli[i]==ar)
                {
                    return i;
                }
            }
            return -1;
        }

        public void CreaCommentoNormale(Articolo indx, string t)
        {
            Commento c = new Commento(t);
            for(int i = 0;i < this.Articoli.Count;i++)
            {
                if(this.Articoli[i]==indx)
                {
                    this.Articoli[i].AggiungiCommento(c);
                }
            }
        }

        public void CreaCommentoRedazione(Articolo indx, string t)
        {
            Commento c = new CommentoDellaRedazione(t);
            for (int i = 0; i < this.Articoli.Count; i++)
            {
                if (this.Articoli[i] == indx)
                {
                    this.Articoli[i].AggiungiCommento((CommentoDellaRedazione)c);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < this.Articoli.Count; i++)
            {
                sb.AppendLine($"{this.Articoli[i].ToString()}");
            }
            return sb.ToString();
        }
    }
}