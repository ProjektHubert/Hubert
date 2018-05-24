using System;
using System.Collections.Generic;
using Data.InMemory.Interfaces;
using Data.Transformed.Implementation;

namespace Projekt
{
    public partial class Materiale : ICopyable, IStorable
    {
        public Materiale()
        {
            Produkts = new HashSet<Produkt>();
        }

        public int MaterialeId { get; set; }
        public string MaterialeNavn { get; set; }

        public ICollection<Produkt> Produkts { get; set; }

        public ICopyable Copy()
        {
            return (MemberwiseClone() as ICopyable);
        }

        public int Key
        {
            get { return MaterialeId; }
            set { }
        }

        public override string ToString()
        {
            return $"{MaterialeId}";
        }
    }
}
