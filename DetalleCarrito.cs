using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10fun2
{
    internal class DetalleCarrito
    {
        protected int idcarrito;
        protected string sku;
        protected double cantidad;

        public int Idcarrito
        {
            get { return this.idcarrito; }
            set { this.idcarrito = value; }
        }
        public string Sku
        {
            get { return this.sku; }
            set { this.sku = value; }
        }
        public double Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }
    }
}
