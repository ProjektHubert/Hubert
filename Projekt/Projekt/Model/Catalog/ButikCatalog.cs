using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Model.Base;

namespace Projekt.Model.Catalog
{
    public class ButikCatalog : CatalogAppBase<Butik>
    {
        private static ButikCatalog _instance;

        public static ButikCatalog Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ButikCatalog();
                    // Load();
                }

                return _instance;
            }
        }

        public static async void Load()
        {
            await _instance.LoadAsync();
        }
        private ButikCatalog()
        { }
    }
}