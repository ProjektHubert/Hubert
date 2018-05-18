using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.InMemory.Interfaces;
using Extensions.Model.Implementation;

namespace Projekt.Model.Base
{
    public class CatalogAppBase<T> : EFCorePersistableCatalogAsync<HubertdbContext, T, T, T>
        where T : class, IStorable, ICopyable, new()


    {
        public override T CreateDomainObjectFromViewDataObject(T vmObj)
        {
            return vmObj;
        }

        public override T CreateViewDataObject(T vmObj)
        {
            return vmObj;
        }

        public override T CreatePersistentDataObject(T vmObj)
        {
            return vmObj;
        }

        public override T CreateDomainObjectFromPersistentDataObject(T vmObj)
        {
            return vmObj;
        }
    }
}
