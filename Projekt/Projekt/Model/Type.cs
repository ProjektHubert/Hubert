using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Model
{
    class Type
    {
        private int _typeID;
        private string _typeNavn;

        public int TypeID
        {
            get => _typeID;
            set => _typeID = value;
        }
        public string TypeNavn
        {
            get => _typeNavn;
            set => _typeNavn = value;
        }
    }

}
