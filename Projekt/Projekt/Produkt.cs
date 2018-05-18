using System;
using System.Collections.Generic;
using Data.Transformed.Implementation;

namespace Projekt
{
    public partial class Produkt : CopyableWithDefaultValuesBase
    {
        public int ProduktId { get; set; }
        public string ProduktNavn { get; set; }
        public int? FkMaterialeId { get; set; }
        public int? FkTypeId { get; set; }
        public override void SetDefaultValues()
        {
            
        }
    }
}
