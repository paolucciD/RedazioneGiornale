﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoGiornale.Models
{
    internal interface IEquatable
    {
        public bool Equals(Articolo other);
    }
}