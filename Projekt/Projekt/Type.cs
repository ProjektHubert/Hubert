using System;
using System.Collections.Generic;

namespace Projekt
{
    public partial class Type
    {
        public Type()
        {
            Produkts = new HashSet<Produkt>();
        }

        public int TypeId { get; set; }
        public string TypeNavn { get; set; }

        public ICollection<Produkt> Produkts { get; set; }
    }
}
