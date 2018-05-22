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
    public class ProduktPageViewModel : PageViewModelCRUD<Produkt>
    {
        public ProduktPageViewModel() : base(ProduktCatalog.Instance, new List<string>() ,new List<string>() )
        {
            ProduktCatalog.Instance.LoadEnds +=InstanceOnLoadEnds ;
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
