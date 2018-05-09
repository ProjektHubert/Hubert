using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Model
{
    class Martriale
    {
        private int _martrialeID;
        private string _martrialeNavn;

        public int MartrialeID
        {
            get => _martrialeID;
            set => _martrialeID = value;
        }
        public string MartrialeNavn
        {
            get => _martrialeNavn;
            set => _martrialeNavn = value;
        }
    }
}
