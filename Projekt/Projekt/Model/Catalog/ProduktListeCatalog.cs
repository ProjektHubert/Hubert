using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.Model.Base;

namespace Admin.Model.Catalog
{
    public class ProduktListeCatalog : CatalogAppBase<ProduktListe>
    {
        private static ProduktListeCatalog _instance;

        public static ProduktListeCatalog Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProduktListeCatalog();
                    // Load();
                }

                return _instance;
            }
        }

        public static async void Load()
        {
            await _instance.LoadAsync();
        }
    }
}
