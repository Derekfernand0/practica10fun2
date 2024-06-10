using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10fun2
{
    internal class targeta
    {
        //datos de targeta
        protected long idtargeta;
        protected int cvc;
        protected DateTime fdv;
        protected string tipo;
        protected string banco;
        protected int cliente;
        //getter y setter
        public long Idtargeta
        {
            get { return this.idtargeta; }
            set { this.idtargeta = value; }
        }
        public int CVC
        {
            get { return this.cvc; }
            set { this.cvc = value; }
        }
        public DateTime FDV
        {
            get { return this.fdv; }
            set { this.fdv = value; }
        }
        public string Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }
        public string Banco
        {
            get { return this.banco; }
            set { this.banco = value; }
        }
        public int Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }
        //lista de targeta
        private List<Targeta> targeta = new List<Targeta>();
        Targeta tg = new Targeta();
    }
}
