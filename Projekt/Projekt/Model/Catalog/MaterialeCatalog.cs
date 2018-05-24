using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Model.Base;

namespace Projekt.Model.Catalog
{
    public class MaterialeCatalog : CatalogAppBase<Materiale>
    {
        private static MaterialeCatalog _instance;

        public static MaterialeCatalog Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MaterialeCatalog();
                    Load();
                }

                return _instance;
            }
        }

        public static async void Load()
        {
            await _instance.LoadAsync();
        }
        private MaterialeCatalog()
        { }
    }
}
