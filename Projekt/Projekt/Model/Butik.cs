using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Model
{
    class Butik
    {
        private int _butikID;
        private string _adresse;
        private int _tlf;

        public int ButikID
        {
            get => _butikID;
            set => _butikID = value;
        }
        public string Adresse
        {
            get => _adresse;
            set => _adresse = value
        }
        public int Tlf
        {
            get => _tlf;
            set => _tlf = value;
        }
    }
}
