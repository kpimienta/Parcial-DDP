using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial.Producto.Domain
{
    public abstract class Productos
    {
        public Productos(string id, string nombre, int cantidad,  decimal costo)
        {
            Id = id;
            Nombre = nombre;
            Cantidad = 0;
            Costo = 0;
        }

        public string Id { get; }
        public string Nombre { get; }
        public int Cantidad { get; protected set; }
        public decimal Costo { get; protected set;  }

        public abstract string Agregar(int valor, string nombre);
    }
}
