using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial.Producto.Domain
{
    public class ProductoSimple :  Productos
    {
        
        
        public int Cantidad { get; private set; }
        private string Tipo { get; set; }


        public ProductoSimple(string id, string nombre, decimal costo, decimal precio, string tipo) : base(id, nombre, costo, precio)
        {
            Cantidad = 0;
            Tipo = tipo;
        }

        public string Agregar(int cantidad)
        {
            if (cantidad >= 0)
            {
                this.Cantidad += cantidad;
                return $"{Nombre} Nueva cantidad: {Cantidad}";
            }
            return "Error, el registro debe ser mayor a cero";
        }

        public override string RegistrarSalida(int cantidad)
        {
            if (cantidad >= 0)
            {
                this.Cantidad -= cantidad;
                return $"Nueva salida: {Nombre}, cantidad:{cantidad}, costo:{getCosto()}, precio:{Precio}";
            }
            return "Error, Salida menor o igual a 0";
        }

        public override decimal getCosto()
        {
            return Costo;
        }
    }
    }
}
