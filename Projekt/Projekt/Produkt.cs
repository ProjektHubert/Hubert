using System;
using System.Collections.Generic;

namespace Projekt
{
    public partial class Produkt
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
    }
}
