using NUnit.Framework;
using System.Collections.Generic;
using System;
using System.Text;
using Parcial.Producto.Domain;




namespace Productos.Domain.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /*Escenario de prueba:	Registro menor o igual a cero incorrecto
         HU01	Entrada de producto
         DADO	Un registro de entrada de productos
         CUANDO	El registro sea menor o igual a cero
        ENTONCES	El sistema mostrará un mensaje diciendo “Error, el registro debe ser mayor a cero”
        */

        [Test]
        public void NoPuedeRegistrarCantidadMenoroIgualaCero()
        {

            var producto = new ProductoSimple("1", "Pan", 3000, 0, "Combo");
            var resultado = producto.Agregar(0);
            Assert.AreEqual($"Error, el registro debe ser mayor a cero", resultado);

        }

        /*Escenario de prueba:	Registro correcto mayor a cero
        HU01	Entrada de producto
        DADO	Un registro de entrada de productos
        CUANDO	El registro sea mayor a cero
        ENTONCES	El sistema mostrará un mensaje diciendo “Registro exitoso”
        */
         
        [Test]

        public void PuedeRegistrarCantidadMayoraCero()
        {

            var producto = new ProductoSimple("1", "Pan", 2000, 4000, "Preparar");
            var resultado = producto.Agregar(2);
            Assert.AreEqual($"Se agregó correctamente", resultado);

        }

        /*
         DADO que se ha registrado un nuevo producto simple
         CUANDO se ingrese el producto al inventario
         ENTONCES el sistema deberá aumentar la cantidad existente 
         */
        [Test]
        public void EntradaDebeAumentarCantidad()
        {
            ProductoSimple prod = new ProductoSimple("001", "Salchicha", 1000, 0, "Preparacion");

            //Act
            var respuesta = prod.Agregar(10);

            //Assert
            Assert.AreEqual("Salchicha Nueva cantidad: 10", respuesta);
        }

        /*
      DADO que se ha registrado un nuevo producto simple
      CUANDO se registre una salida
      ENTONCES el sistema deberá disminuir la cantidad existente en inventario
      */
        [Test]
        public void SalidaProductoSimpleDebeDisminuirCantidad()
        {
            //Arrange
            ProductoSimple prod = new ProductoSimple("002", "CocaCola", 1000, 3000, "Venta");
            //Act
            prod.Agregar(10);
            var respuesta = prod.RegistrarSalida(7);
            //Assert
            Assert.AreEqual("Nueva salida: Salchicha, cantidad:7, costo:1000, precio:3000", respuesta);
        }

    }
}