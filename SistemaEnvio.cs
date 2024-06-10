using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10fun2
{
    internal class SistemaEnvio
    {
        private int idenvio;
        private int idcarrito;
        private double costeenvio;

        public int Idenvio
        {
            get { return this.idenvio; }
            set { this.idenvio = value; }
        }
        public int Idcarrito
        {
            get { return this.idcarrito; }
            set { this.idcarrito = value; }
        }
        public double Costeenvio
        {
            get { return this.costeenvio; }
            set { this.costeenvio = value; }
        }
    }
}
