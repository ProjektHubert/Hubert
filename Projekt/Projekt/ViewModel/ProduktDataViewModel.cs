using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Data.Implementation;

namespace Projekt.ViewModel
{
    public class ProduktDataViewModel : DataViewModelBase<Produkt>
    {
        public ProduktDataViewModel(Produkt obj) : base(obj)
        {
        }

        public int ProduktID
        {
            get { return DataObject.ProduktId; }
        }
        public string ProduktNavn
        {
            get { return DataObject.ProduktNavn; }
        }
        public int? fkMaterialeID
        {
            get { return DataObject.FkMaterialeId; }
        }
        public int? fkTypeID
        {
            get { return DataObject.FkTypeId; }
        }
    }
}
