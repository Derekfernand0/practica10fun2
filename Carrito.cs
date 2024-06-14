using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10fun2
{

    // hola
    internal class Carrito
    {
        private int idcarrito;
        private DateTime fecha;
        private int idcliente;

        public int Idcarrito
        {
            get { return this.idcarrito; }
            set { this.idcarrito = value; }
        }
        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }
        public int Idcliente
        {
            get { return this.idcliente; }
            set { this.idcliente = value; }
        }
        //list del detalle de carrito
    }
}
