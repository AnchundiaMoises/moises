using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaElextronica
{
    class Factura_C_Sin_Registro
    {
        public Factura_C_Sin_Registro()
        {
        //    this.DatosCliente = new List<ClienteSinRegistro>();
        }
        //public List<ClienteSinRegistro> DatosCliente { get; set; }
        public ClienteSinRegistro Datos1 { get; set; }
        public Calculos_a_pagar_sin_Registro Factura1 { get; set; }
     //   Calculos_a_pagar_sin_Registro c1 = new Calculos_a_pagar_sin_Registro();
       /* public void Facturacion()
        {
            Console.WriteLine("Subtotal...:" + c1.CalcularSubtotal());
            Console.WriteLine("Descuento...:" + c1.CalcularDescuento());
            Console.WriteLine("Su total es..:" + c1.CalcularTotal());
           // this.Factura1 = c1;
         }        */             
        public void LlenarDatos()
        {
            ClienteSinRegistro clienteSinRegistro = new ClienteSinRegistro();
            Console.WriteLine("Escriba su Nombre"); clienteSinRegistro.Nombres = Console.ReadLine();
            Console.WriteLine("Escriba su Apellido"); clienteSinRegistro.Apellido = Console.ReadLine();
            Console.WriteLine("Escriba su Numero de cedula"); clienteSinRegistro.Cedula = Console.ReadLine();
            Console.WriteLine("Escriba su Correo"); clienteSinRegistro.Email = Console.ReadLine();
            Console.WriteLine("Escriba su Contraseña"); clienteSinRegistro.Contraseña = Console.ReadLine();
            Console.WriteLine("Escriba su Telefono"); clienteSinRegistro.Telefono = Console.ReadLine();
            this.Datos1 = clienteSinRegistro;
        }
    }
}
