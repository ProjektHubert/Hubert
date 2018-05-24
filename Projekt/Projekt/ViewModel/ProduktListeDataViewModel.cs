using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Model.Catalog;
using ViewModel.Data.Implementation;

namespace Projekt.ViewModel
{
    public class ProduktListeDataViewModel : DataViewModelBase<ProduktListe>
    {
        public ProduktListeDataViewModel(ProduktListe obj) : base(obj)
        {
        }

        public int fkProduktID
        {
            get { return DataObject.FkProduktId; }
        }

        public int fkButikID
        {
            get { return DataObject.FkButikId; }
        }

        public string Pris
        {
            get { return DataObject.Pris; }
        }

        public int? Antal
        {
            get { return DataObject.Antal; }
        }

        public int Stoerrelse
        {
            get { return DataObject.Stoerrelse; }
        }
        public override string ToString()
        {
            Produkt pn = ProduktCatalog.Instance.Read(fkProduktID);
            Produkt pt = ProduktCatalog.Instance.Read(fkProduktID);
            Produkt pm = ProduktCatalog.Instance.Read(fkProduktID);
            Butik b = ButikCatalog.Instance.Read(fkButikID);

            return $"{pn.ProduktNavn}, {pt.Type} {pm.Materiale},{b.Adresse}, {Antal}, {Stoerrelse}, {Pris}kr";
        }
    }
}
