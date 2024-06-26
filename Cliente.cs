using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10fun2
{
    internal class Cliente
    {
        //datos de cliente
        public string name;
        public string description;
        public string x;
        public string y;
        public string referencia;
        public string z;
        public string ednrea;
        //getter y setter
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public string X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public string Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public string Z
        {
            get { return this.z; }
            set { this.z = value; }
        }
        public string Referencia
        {
            get { return this.referencia; }
            set { this.referencia = value; }
        }
        public string Ednrea
        {
            get { return this.ednrea; }
            set { this.ednrea = value; }
        }

    }
}
