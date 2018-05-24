using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Transformed.Interfaces;
using Extensions.ViewModel.Implementation;
using Model.Interfaces;
using Projekt.Model.Catalog;

namespace Projekt.ViewModel
{
    public class ButikPageViewModel : PageViewModelCRUD<Butik>
    {
        public ButikPageViewModel(ICatalog<Butik> catalog, List<string> immutableControls, List<string> mutableControls) : base(catalog, immutableControls, mutableControls)
        {
            ButikCatalog.Instance.LoadEnds += InstanceOnLoadEnds;
        }
        private void InstanceOnLoadEnds()
        {
            OnPropertyChanged(nameof(ItemCollection));
        }

        public override IDataWrapper<Butik> CreateDataViewModel(Butik obj)
        {
            return new ButikDataViewModel(obj);
        }

    }
}
