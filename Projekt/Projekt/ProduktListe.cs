using System;
using System.Collections.Generic;

namespace Projekt
{
    public partial class ProduktListe
    {
        public int FkProduktId { get; set; }
        public int FkButikId { get; set; }
        public string Pris { get; set; }
        public int? Antal { get; set; }
        public int Stoerrelse { get; set; }

        public Butik FkButik { get; set; }
        public Produkt FkProdukt { get; set; }
    }
}
