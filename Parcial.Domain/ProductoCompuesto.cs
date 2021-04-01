using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial.Producto.Domain
{
    public class ProductoCompuesto : Productos
    {
        private List<Productos> Producto { get; set; }
        public ProductoCompuesto(string id, string nombre, decimal precio, List<Productos> productos) : base(id, nombre, 0, precio)
        {
            Producto = productos;
            getCosto();
        }

        public override string RegistrarSalida(int cantidad)
        {
            foreach (var item in Producto)
            {
                item.RegistrarSalida(cantidad);
            }

            return $"Nueva salida: {Nombre}, cantidad:{cantidad}, costo:{Costo}, precio:{Precio}";

        }
        public override decimal getCosto()
        {
            decimal total = 0;
            foreach (var item in Producto)
            {
                total += item.getCosto();
            }
            this.Costo = total;
            return total;
        }

    }
}
