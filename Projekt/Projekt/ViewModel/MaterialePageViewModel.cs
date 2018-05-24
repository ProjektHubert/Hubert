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
    public class MaterialePageViewModel : PageViewModelCRUD<Materiale>
    {
        public MaterialePageViewModel(ICatalog<Materiale> catalog, List<string> immutableControls, List<string> mutableControls) : base(catalog, immutableControls, mutableControls)
        {
            MaterialeCatalog.Instance.LoadEnds += InstanceOnLoadEnds;
        }
        private void InstanceOnLoadEnds()
        {
            OnPropertyChanged(nameof(ItemCollection));
        }
        public override IDataWrapper<Materiale> CreateDataViewModel(Materiale obj)
        {
            return new MaterialeDataViewModel(obj);
        }
    }
}