using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Data.Implementation;

namespace Projekt.ViewModel
{
    class TypeDataViewModel : DataViewModelBase<Type>
    {
        protected TypeDataViewModel(Type obj) : base(obj)
        {
        }
    }
}
