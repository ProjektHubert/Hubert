using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Data.Implementation;

namespace Projekt.ViewModel
{
    public class TypeDataViewModel : DataViewModelBase<Type>
    {
        public TypeDataViewModel(Type obj) : base(obj)
        {
        }

        public int TypeID
        {
            get { return DataObject.TypeId; }
        }

        public string TypeNavn
        {
            get { return DataObject.TypeNavn; }
        }
        public override string ToString()
        {
            return $"{TypeID}";
        }
    }
}
