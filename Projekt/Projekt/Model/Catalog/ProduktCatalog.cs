using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Model.Base;

namespace Projekt.Model.Catalog
{
    public class ProduktCatalog : CatalogAppBase<Produkt>
    {
        private static ProduktCatalog _instance;

        public static ProduktCatalog Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProduktCatalog();
                    Load();
                }

                return _instance;
            }
        }

        public static async void Load()
        {
            await _instance.LoadAsync();
        }
        private ProduktCatalog()
        {
        }
    }
}
