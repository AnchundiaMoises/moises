using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaElextronica
{
    class Factura_C_Registrado
    {
        public ClienteConRegistro Dato2 { get; set; }
        public void LlenarDatos()
        {
            ClienteConRegistro c2=new ClienteConRegistro();
            Console.WriteLine("Escriba su Nombre"); c2.Nombres = Console.ReadLine();
            Console.WriteLine("Escriba su Apellido"); c2.Apellido = Console.ReadLine();
            Console.WriteLine("Escriba su Numero de cedula"); c2.Cedula = Console.ReadLine();
            Console.WriteLine("Escriba su Correo"); c2.Email = Console.ReadLine();
            Console.WriteLine("Escriba su Contraseña"); c2.Contraseña = Console.ReadLine();
            Console.WriteLine("Escriba su Telefono"); c2.FechaInicioRegistro=new DateTime(11/02/2019);
            Console.WriteLine("Escriba su Telefono"); c2.FechaFinalisacion= new DateTime(11 / 02 / 2019);
            this.Dato2 = c2;
        }
    }
}
