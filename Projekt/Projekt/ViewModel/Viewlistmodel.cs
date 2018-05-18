using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.ViewModel
{
    public class Viewlistmodel
    {
        private Produkt _domainObject;

        public Viewlistmodel(produkt domainObject)
        {
            _domainObject = domainObject;
        }
        public Produkt DomainObject
        {
            get { return _domainObject; }
        }
        public string Description
        {
            get { return _domainObject.ProduktNavn + _domainObject.MartrialeNavn + _domainObject.TypeNavn + _domainObject.Størrelse ? _domainObject.Pris + _domainObject.Antal; }
        }
    }
}
