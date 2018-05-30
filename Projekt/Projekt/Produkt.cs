using System;
using System.Collections.Generic;
using Data.InMemory.Interfaces;

namespace Projekt
{
    public partial class Produkt : ICopyable, IStorable
    {
        public Produkt()
        {
            ProduktListes = new HashSet<ProduktListe>();
        }

        public int ProduktId { get; set; }
        public string ProduktNavn { get; set; }
        public string Materiale { get; set; }
        public string Type { get; set; }

        public ICollection<ProduktListe> ProduktListes { get; set; }
        public ICopyable Copy()
        {
            return (MemberwiseClone() as ICopyable);
        }

        public int Key
        {
            get { return ProduktId; }
            set { }
        }

        public override string ToString()
        {
            return $"{ProduktId}";
        }
    }
}
