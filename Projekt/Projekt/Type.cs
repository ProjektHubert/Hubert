using System;
using System.Collections.Generic;
using Data.InMemory.Interfaces;
using Data.Transformed.Implementation;

namespace Projekt
{
    public partial class Type : ICopyable, IStorable
    {
        public Type()
        {
            Produkts = new HashSet<Produkt>();
        }

        public int TypeId { get; set; }
        public string TypeNavn { get; set; }

        public ICollection<Produkt> Produkts { get; set; }

        public ICopyable Copy()
        {
            return (MemberwiseClone() as ICopyable);
        }

        public int Key
        {
            get { return TypeId; }
            set { }
        }

        public override string ToString()
        {
            return $"{TypeId}";
        }
    }
}
