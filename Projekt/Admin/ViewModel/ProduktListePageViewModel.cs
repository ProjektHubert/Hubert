using System.Collections.Generic;
using System.Linq;
using Data.Transformed.Interfaces;
using Extensions.ViewModel.Implementation;
using Projekt.Model.Catalog;

namespace Projekt.ViewModel
{
    public class ProduktListePageViewModel : PageViewModelCRUD<ProduktListe>
    {
        private string _text;
        //private int _textid;

        public ProduktListePageViewModel() : base(ProduktListeCatalog.Instance, new List<string>(), new List<string>())
        {
            ProduktListeCatalog.Instance.LoadEnds += InstanceOnLoadEnds;
            ProduktCatalog.Instance.LoadEnds += InstanceOnLoadEnds;
            ButikCatalog.Instance.LoadEnds += InstanceOnLoadEnds;

            InitCatalogs();
            _text = "";
            // _textid = _textid;

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
                return ItemCollection.Where(i => ProduktCatalog.Instance.Read(i.DataObject.FkProduktId).ProduktNavn.ToLower().Contains(_text.ToLower()));


                // return ItemCollection.Where(a => ProduktCatalog.Instance.Read(a.DataObject.FkProduktId).ProduktId.Equals(_textid));
            }
        }

        public string Sogetekst
        {
            get
            {
                return _text;
                //return _textid.ToString();
            }
            set
            {
                _text = value;
                // _textid = Convert.ToInt32(value);
                OnPropertyChanged();
                OnPropertyChanged(nameof(ItemCollectionFiltered));

            }
        }

    }
}
