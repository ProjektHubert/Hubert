using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Data.Implementation;

namespace Projekt.ViewModel
{
    public class MaterialeDataViewModel : DataViewModelBase<Materiale>
    {
        public MaterialeDataViewModel(Materiale obj) : base(obj)
        {
        }

        public int MaterialeID
        {
            get { return DataObject.MaterialeId; }
        }

        public string MaterialeNavn
        {
            get { return DataObject.MaterialeNavn; }
        }
        public override string ToString()
        {
            return $"{MaterialeID}";
        }
    }
}