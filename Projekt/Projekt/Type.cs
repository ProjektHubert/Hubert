using System;
using System.Collections.Generic;
using Data.Transformed.Implementation;

namespace Projekt
{
    public partial class Type : CopyableWithDefaultValuesBase
    {
        public int TypeId { get; set; }
        public string TypeNavn { get; set; }
        public override void SetDefaultValues()
        {
            
        }
    }
}
