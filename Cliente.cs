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
        protected int id;
        protected string name;
        protected string description;
        protected int cp;
        protected string estado;
        protected string municipio;
        protected string referencia;
        protected string correo;
        protected int telefono;
        protected string rfc;
        //getter y setter
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
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
        public int Cp
        {
            get { return this.cp; }
            set { this.cp = value; }
        }
        public string Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        public string Municipio
        {
            get { return this.municipio; }
            set { this.municipio = value; }
        }
        public string Referencia
        {
            get { return this.referencia; }
            set { this.referencia = value; }
        }
        public string Correo
        {
            get { return this.Correo; }
            set { this.correo = value; }
        }
        public int Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }
        public string RFC
        {
            get { return this.rfc; }
            set { this.rfc = value; }
        }

        //crear la lista de targeta
    }
}
