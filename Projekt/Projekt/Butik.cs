using System;
using System.Collections.Generic;
using Data.Transformed.Implementation;

namespace Projekt
{
    public partial class Butik : CopyableWithDefaultValuesBase
    {
        public Butik()
        {
            ProduktListes = new HashSet<ProduktListe>();
        }

        public int ButikId { get; set; }
        public string Adresse { get; set; }
        public string Tlf { get; set; }

        public ICollection<ProduktListe> ProduktListes { get; set; }
        public override void SetDefaultValues()
        {

        }
    }
   
}
