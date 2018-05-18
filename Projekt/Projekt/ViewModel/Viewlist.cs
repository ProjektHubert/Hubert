using Projekt.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.ViewModel
{
     public class Viewlist 
    {
        private List<Produkt> _produkt;

        public List<Produkt> Produkts
        {
            get { return _produkt; }
        }

        public ProduktCatalog ()
        {
            _produkt = new List<Produkt>();
            _produkt.Add(new Produkt());
        }







        public ObservableCollection<Produkt> Produkts
        {
            get
            {
                return new ObservableCollection<Produkt>()
                {
                    new Produkt()
                };
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }


}
