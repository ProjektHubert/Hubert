using System;
using System.Collections.Generic;
using Data.InMemory.Interfaces;

namespace Admin
{
    public partial class Butik : ICopyable, IStorable
    {
        public Butik()
        {
            ProduktListes = new HashSet<ProduktListe>();
        }

        public int ButikId { get; set; }
        public string Adresse { get; set; }
        public string Tlf { get; set; }

        public ICollection<ProduktListe> ProduktListes { get; set; }
        public ICopyable Copy()
        {
            return (MemberwiseClone() as ICopyable);
        }

        public int Key
        {
            get { return ButikId; }
            set { }
        }

        public override string ToString()
        {
            return $"{ButikId}";
        }
    }
}
