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

            var producto = new ProductoSimple("1", "Pan", 0, 2000, 5000);
            var resultado = producto.Agregar(0, "pan");
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

            var producto = new ProductoSimple("1", "Pan", 2, 2000, 5000);
            var resultado = producto.Agregar(2, "pan");
            Assert.AreEqual($"Registro exitoso", resultado);

        }

    }
}