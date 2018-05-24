using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Model.Base;

namespace Projekt.Model.Catalog
{
    public class TypeCatalog : CatalogAppBase<Type>
    {
        private static TypeCatalog _instance;

        public static TypeCatalog Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TypeCatalog();
                    Load();
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
