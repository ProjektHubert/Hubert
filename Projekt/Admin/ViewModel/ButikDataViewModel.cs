using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Data.Implementation;

namespace Projekt.ViewModel
{
    public class ButikDataViewModel : DataViewModelBase<Butik>
    {
        public ButikDataViewModel(Butik obj) : base(obj)
        {
        }

        public int ButikID
        {
            get { return DataObject.ButikId; }
        }

        public string Adresse
        {
            get { return DataObject.Adresse; }
        }

        public string Tlf
        {
            get { return DataObject.Tlf; }
        }
        public override string ToString()
        {
            return $"{ButikID}";
        }
    }
}