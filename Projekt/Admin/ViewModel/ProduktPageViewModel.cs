using System.Collections.Generic;
using Data.Transformed.Interfaces;
using Extensions.ViewModel.Implementation;
using Admin.Model.Catalog;

namespace Admin.ViewModel
{
    public class ProduktPageViewModel : PageViewModelCRUD<Produkt>
    {
        public ProduktPageViewModel() : base(ProduktCatalog.Instance, new List<string>(), new List<string>())
        {
            ProduktCatalog.Instance.LoadEnds += InstanceOnLoadEnds;
        }

        private void InstanceOnLoadEnds()
        {
            OnPropertyChanged(nameof(ItemCollection));
        }

        public override IDataWrapper<Produkt> CreateDataViewModel(Produkt obj)
        {
            return new ProduktDataViewModel(obj);
        }
    }
}
