using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10fun2
{
    internal class ListaProductos
    {
        //tipo de dato de productos en pilincraft
        private string item;
        private double precio;
        private string descripcion;
        private string unidad;
        private string mod;
        private string tdm;
        //getter y setter
        public string Item
        {
            get { return this.item; }
            set { this.item = value; }
        }
        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }
        public double Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
        public string Unidad
        {
            get { return this.unidad; }
            set { this.unidad = value; }
        }
        public string Mod
        {
            get { return this.mod; }
            set { this.mod = value; }
        }
        public string Tdm
        {
            get { return this.tdm; }
            set { this.tdm = value; }
        }
    }
}
