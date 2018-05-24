using System;
using System.Collections.Generic;
using Data.InMemory.Interfaces;
using Data.Transformed.Implementation;
using ViewModel.Data.Implementation;

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
        public int? FkMaterialeId { get; set; }
        public int? FkTypeId { get; set; }

        public Materiale FkMateriale { get; set; }
        public Type FkType { get; set; }
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
