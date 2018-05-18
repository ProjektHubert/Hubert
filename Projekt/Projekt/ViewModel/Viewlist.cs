using Projekt.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.ViewModel
{
     class Viewlist
    {
        private Produkt _produktCatalog;
        private ObservableCollection<Produkt> _displayProdukt;

        private Produkt _selectProdukt;

        private Produkt _newprodukt;

        private RelayCommand _changeList;

        public ProduktList()
        {
            _newprodukt = new Produkt();
            _produktCatalog = Produkt.instances;

            _displayProdukt = _produktCatalog;

        }

        private class RelayCommand
        {
        }
    }
     
    
}
