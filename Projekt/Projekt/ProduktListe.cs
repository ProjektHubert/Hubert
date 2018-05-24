using System;
using System.Collections.Generic;
using Data.InMemory.Interfaces;
using Data.Transformed.Implementation;
using Projekt.Model.Catalog;

namespace Projekt
{
    public partial class ProduktListe : ICopyable, IStorable
    {
        public int FkProduktId { get; set; }
        public int FkButikId { get; set; }
        public string Pris { get; set; }
        public int? Antal { get; set; }
        public int Stoerrelse { get; set; }

        public Butik FkButik { get; set; }
        public Produkt FkProdukt { get; set; }

        public ICopyable Copy()
        {
            return (MemberwiseClone() as ICopyable);
        }

        public int Key
        {
            get { return 2351 * FkProduktId + 359 * FkButikId + 97 * Stoerrelse; }
            set { }
        }

        public override string ToString()
        {
            Produkt p = ProduktCatalog.Instance.Read(FkProduktId);
            return $"{p.ProduktNavn}, {FkButikId}, {Stoerrelse}";
        }
    }
}
