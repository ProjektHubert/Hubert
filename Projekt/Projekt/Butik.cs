using System;
using System.Collections.Generic;
using Data.Transformed.Implementation;

namespace Projekt
{
    public partial class Butik : CopyableWithDefaultValuesBase
    {
        public int ButikId { get; set; }
        public string Adresse { get; set; }
        public string Tlf { get; set; }
        public override void SetDefaultValues()
        {
            
        }
    }
}
