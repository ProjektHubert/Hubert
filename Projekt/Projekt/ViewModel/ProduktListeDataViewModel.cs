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
            Produkt p = ProduktCatalog.Instance.Read(fkProduktID);
            return $"{p.ProduktNavn}, {fkButikID}, {Stoerrelse}";
        }
    }
}
