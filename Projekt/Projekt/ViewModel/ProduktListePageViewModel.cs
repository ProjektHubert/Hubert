using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private string _text;

        public ProduktListePageViewModel() : base(ProduktListeCatalog.Instance, new List<string>(), new List<string>())
        {
            ProduktListeCatalog.Instance.LoadEnds += InstanceOnLoadEnds;
            ProduktCatalog.Instance.LoadEnds += InstanceOnLoadEnds;
            ButikCatalog.Instance.LoadEnds += InstanceOnLoadEnds;

            InitCatalogs();
            _text = "";
        }
        private void InstanceOnLoadEnds()
        {
            OnPropertyChanged(nameof(ItemCollectionFiltered));

        }

        public async void InitCatalogs()
        {
            await ProduktCatalog.Instance.LoadAsync();
            await ButikCatalog.Instance.LoadAsync();
            await ProduktListeCatalog.Instance.LoadAsync();

            int countProd = ProduktCatalog.Instance.All.Count;
            int countButik = ButikCatalog.Instance.All.Count;
            int countProdList = ProduktListeCatalog.Instance.All.Count;

        }
        public override IDataWrapper<ProduktListe> CreateDataViewModel(ProduktListe obj)
        {
            return new ProduktListeDataViewModel(obj);
        }

        public IEnumerable<IDataWrapper<ProduktListe>> ItemCollectionFiltered
        {
            get
            {
                return ItemCollection.Where(i => ProduktCatalog.Instance.Read(i.DataObject.FkProduktId).ProduktNavn.Contains(_text));
            }
        }

        public string Sogetekst
        {
            get { return _text;}
            set
            {
                _text = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ItemCollectionFiltered));
            }
        }

    }
}
