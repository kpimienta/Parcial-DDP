using System;
using System.Collections.Generic;
using System.Text;


namespace Parcial.Producto.Domain
{
    public class Inventario
    {
        public Inventario(List<ProductoSimple> productos)
        {
            Producto = productos;
        }

        public List<ProductoSimple> Producto { get; private set; }

        private ProductoSimple BuscarProducto(string id)
        {
            foreach (var item in Producto)
            {
                if (item.Id.Equals(id)) return item;
            }
            return null; 
        }

        public string RegistrarProducto(ProductoSimple producto)
        {
            if (producto.Cantidad<=0)
            {
                return "Error, el registro debe ser mayor a cero";
            }

            var productoExistente = BuscarProducto(producto.Id);
            
            if(productoExistente == null)
            {
                Producto.Add(producto);
                return $"la cantidad del producto {producto.Nombre} es {producto.Cantidad}";
            }
            throw new NotImplementedException();
        }
        

        
    }
}
