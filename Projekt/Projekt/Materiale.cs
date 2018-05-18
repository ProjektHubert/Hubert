using System;
using System.Collections.Generic;
using Data.Transformed.Implementation;

namespace Projekt
{
    public partial class Materiale : CopyableWithDefaultValuesBase
    {
        public int MaterialeId { get; set; }
        public string MaterialeNavn { get; set; }
        public override void SetDefaultValues()
        {
            
        }
    }
}
