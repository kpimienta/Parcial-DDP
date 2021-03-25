using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial.Producto.Domain
{
    public class ProductoSimple :  Productos
    {
        
        public decimal PrecioFinal { get; protected set; }

        public ProductoSimple(string id, string nombre, int cantidad, decimal costo, decimal precioFinal) : base(id, nombre, cantidad, costo)
        {

        }

        public override string Agregar(int valor, string nombre)
        {
            if (valor <= 0)
            {
                return "Error, el registro debe ser mayor a cero";
            }
            if ( Cantidad == 0 && valor > 0)
            {
                Cantidad += valor;
                return $"Se agregó correctamente";
            }
            throw new NotImplementedException();
        }

        public string AumentarCantidad(int val, bool entrada)
        {
            
            if ( entrada == true )
            {
                Cantidad = Cantidad + val;
                return $"la cantidad del producto: {Nombre} es {Cantidad} ";
            }
            if(entrada == false)
            {
                Cantidad = Cantidad - val;
                return $"la cantidad del producto: {Nombre} es {Cantidad} ";
            }
            throw new NotImplementedException();
        }
    }
}
