using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoGiornale.Models
{
    public class CommentoDellaRedazione : Commento
    {
        public CommentoDellaRedazione(string t) : base(t)
        {

        }

        public override string ToString()
        {
            return $"***" + base.ToString();
        }
    }
}