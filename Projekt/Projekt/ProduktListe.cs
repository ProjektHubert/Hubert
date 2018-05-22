using System;
using System.Collections.Generic;
using Data.Transformed.Implementation;

namespace Projekt
{
    public partial class ProduktListe : CopyableWithDefaultValuesBase
    {
        public int FkProduktId { get; set; }
        public int FkButikId { get; set; }
        public string Pris { get; set; }
        public int? Antal { get; set; }
        public int Stoerrelse { get; set; }
        public override void SetDefaultValues()
        {
            
        }
    }
}
