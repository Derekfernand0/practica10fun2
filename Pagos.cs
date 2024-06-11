using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10fun2
{
    internal class Pagos
    {
        private int idpago;
        private DateTime fecha;
        private string formadepago;
        private double monto;
        private int idcarrito;
        private long numtargeta;
        //getter y setter

        public long Numtargeta
        {
            get { return this.numtargeta; }
            set { this.numtargeta = value; }
        }
        public string Formadepago
        {
            get { return this.formadepago; }
            set { this.formadepago = value; }
        }
        public int Idpago
        {
            get { return this.idpago; }
            set { this.idpago = value; }
        }
        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }
        public double Monto
        {
            get { return this.monto; }
            set { this.monto = value; }
        }
        public int Idcarrito
        {
            get { return this.idcarrito; }
            set { this.idcarrito = value; }
        }   
    }
}
