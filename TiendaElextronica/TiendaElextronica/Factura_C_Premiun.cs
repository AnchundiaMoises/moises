using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaElextronica
{
    class Factura_C_Premiun
    {
        ClientePremiun c3 = new ClientePremiun();
        public ClientePremiun Dato3 { get; set; }
 //       public decimal Facha() { return 
  //              c3.FechaDeInscre(); }
        public void LlenarDatos()
        {
           
            Console.WriteLine("Escriba su Nombre"); c3.Nombres = Console.ReadLine();
            Console.WriteLine("Escriba su Apellido"); c3.Apellido = Console.ReadLine();
            Console.WriteLine("Escriba su Numero de cedula"); c3.Cedula = Console.ReadLine();
            Console.WriteLine("Escriba su Correo"); c3.Email = Console.ReadLine();
            Console.WriteLine("Escriba su Contraseña"); c3.Contraseña = Console.ReadLine();
            Console.WriteLine("Escriba su Facha de inscriccion"); c3.FechaInscriccion = DateTime.Parse(Console.ReadLine ());
            Console.WriteLine("Escriba su Puntage"); c3.PuntageCom = Convert.ToInt32(Console.ReadLine());
            this.Dato3 = c3;
        }
     
       


    }
}
