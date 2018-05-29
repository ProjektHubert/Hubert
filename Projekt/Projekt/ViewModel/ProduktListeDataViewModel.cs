using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Admin.Model.Catalog;
using ViewModel.Data.Implementation;

namespace Admin.ViewModel
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


        public string PNavn
        {
            get
            {
                Produkt pnavn = ProduktCatalog.Instance.Read(fkProduktID);
                return $"{(pnavn == null ? "(Tom)" : pnavn.ProduktNavn)}";
            }
        }
        public string PType
        {
            get
            {
                Produkt ptype = ProduktCatalog.Instance.Read(fkProduktID);
                return $"{(ptype == null ? "(Tom)" : ptype.Type)}";
            }
        }
        public string PMateriale
        {

            get
            {
                Produkt pmat = ProduktCatalog.Instance.Read(fkProduktID);
                return $"{(pmat == null ? "(Tom)" : pmat.Materiale)}";
            }

        }
        public string BAdresse
        {
            get
            {
                Butik badresse = ButikCatalog.Instance.Read(fkButikID);
                return $"{(badresse == null ? "(Tom)" : badresse.Adresse)}";
            }
        }
        public override string ToString()
        {
            Produkt pn = ProduktCatalog.Instance.Read(fkProduktID);
            Produkt pt = ProduktCatalog.Instance.Read(fkProduktID);
            Produkt pm = ProduktCatalog.Instance.Read(fkProduktID);
            Butik b = ButikCatalog.Instance.Read(fkButikID);



            return $"  {(pn == null ? "(not set)" : pn.ProduktNavn)}" +
                   $"  {(pt == null ? "(not set)" : pt.Type)}" +
                   $"  {(pm == null ? "(not set)" : pm.Materiale)}";
        }
    }
}
