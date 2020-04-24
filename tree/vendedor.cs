using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    class vendedor
    {
        private int _nombre;
        private int _monto;
        private int _numero;
        public int Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }
        public int Monto
        {
            get
            {
                return this._monto;
            }
            set
            {
                this._monto = value;
            }
        }
        public int numero
        {
            get
            {
                return this._numero;
            }
            set
            {
                this._numero = value;
            }
        }
    }
}
