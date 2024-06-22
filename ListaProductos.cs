using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10fun2
{
    internal class ListaProductos
    {
        
    public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public ListaProductos(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}

