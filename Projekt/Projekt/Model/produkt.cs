using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Model
{
    class Produkt
    {
        private int _produktID;
        private string _produktNavn;
        private int _martrialeID;
        private int _størrelse;
        private int _typeID;
        private string _pris;


        public Produkt()
        {
        }
        public int ProduktID
        {
            get => _produktID;
            set => _produktID = value;
        }
        public string ProduktNavn
        {
            get => _produktNavn;
            set => _produktNavn = value;
        }

        internal static void Add(Produkt i)
        {
            throw new NotImplementedException();
        }

        public int MartrialeID
        {
            get => _martrialeID;
            set => _martrialeID = value;
        }
        public int Størrelse
        {
            get => _størrelse;
            set => _størrelse = value;
        }
        public int TypeID
        {
            get => _typeID;
            set => _typeID = value;
        }
        public string Pris
        {
            get => _pris;
            set => _pris = value;
        }
        public string antal { get; internal set; }
        public static object instances { get; internal set; }

        public static implicit operator ObservableCollection<object>(Produkt v)
        {
            throw new NotImplementedException();
        }
    }

}
