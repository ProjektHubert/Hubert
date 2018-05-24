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
    public class ProduktListePageViewModel : PageViewModelCRUD<ProduktListe>
    {
        public ProduktListePageViewModel() : base(ProduktListeCatalog.Instance, new List<string>(), new List<string>())
        {
            ProduktListeCatalog.Instance.LoadEnds += InstanceOnLoadEnds;
        }
        private void InstanceOnLoadEnds()
        {
            OnPropertyChanged(nameof(ItemCollection));
        }
        public override IDataWrapper<ProduktListe> CreateDataViewModel(ProduktListe obj)
        {
            return new ProduktListeDataViewModel(obj);
        }

    }
}
