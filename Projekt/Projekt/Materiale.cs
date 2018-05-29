using System;
using System.Collections.Generic;

namespace Projekt
{
    public partial class Materiale
    {
        public Materiale()
        {
            Produkts = new HashSet<Produkt>();
        }

        public int MaterialeId { get; set; }
        public string MaterialeNavn { get; set; }

        public ICollection<Produkt> Produkts { get; set; }
    }
}
