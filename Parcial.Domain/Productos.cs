using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial.Producto.Domain
{
    public abstract class Productos
    {
        public Productos(string id, string nombre, int costo,  decimal precio)
        {
            Id = id;
            Nombre = nombre;
            Costo = 0;
            Precio = 0;
        }

        public string Id { get; }
        public string Nombre { get; }
        public int Costo { get; protected set; }
        public decimal Precio { get; protected set;  }

        
        public abstract decimal getCosto();
        public abstract string RegistrarSalida(int cantidad);
    }
}
