using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Data.Implementation;

namespace Admin.ViewModel
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
        public string Materiale
        {
            get { return DataObject.Materiale; }
        }
        public string Type
        {
            get { return DataObject.Type; }
        }
        public override string ToString()
        {
            return $"{ProduktID}";
        }
    }
}
