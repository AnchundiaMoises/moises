using System;

namespace TiendaElextronica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a tienda Thech!");
            ListaDeProductos listaDeProductos = new ListaDeProductos();
            listaDeProductos.GeneraProductos();
            listaDeProductos.imprimirlistado();


            //Factura factura1 = new Factura();
            FacturaCarrito carrito = new FacturaCarrito();
            string opcion;
            do
            {
                Console.WriteLine("Ingrese el codigo del producto");
                int codigo = int.Parse(Console.ReadLine());

                DetalleFactura detalleFactura = new DetalleFactura();
                detalleFactura.ProductoCarrito = listaDeProductos.StockProductos[codigo - 1];

                Console.WriteLine("Ingrese la cantidad del producto");
                int cantidadproducto = int.Parse(Console.ReadLine());

                detalleFactura.Cantidad = cantidadproducto;

               

                carrito.Detalle.Add(detalleFactura);

                Console.WriteLine("Escriba A seguir agregrandio productus S para salir");
                opcion = Console.ReadLine();


            } while (opcion != "S");

            int menu;
            Console.WriteLine("------------------Bienvenidos al proceso de facturacion ----------------------");
            Console.WriteLine("1.si es no afilado" +
                              " \n2.-SI es Registrado" +
                               "\n3.-Si es Premiun\n");menu =int.Parse( Console.ReadLine());

            switch(menu)
            { case 1:
                 
                    Calculos_a_pagar_sin_Registro factura = new Calculos_a_pagar_sin_Registro();
                    Factura_C_Sin_Registro f1 = new Factura_C_Sin_Registro();
                    Console.WriteLine("------------------Desea ingresar sus datos----------------------");
                    Console.WriteLine("si o no");string op = Console.ReadLine();
                    if (op == "si") { f1.LlenarDatos(); } else { }
                    decimal expor = 0;
                     Console.WriteLine("----------------------Productos comprados------------------------");
                    Console.WriteLine("Productos -----------Cantidad---------Precio");
                    foreach (var item in carrito.Detalle)
                    {
                   Console.WriteLine("{0}{1}\t\t{2}\t\t{3}", item.ProductoCarrito.Codigo, item.ProductoCarrito.Descripcion, item.Cantidad, item.ProductoCarrito.Precio);
                   expor = expor + (item.Cantidad * item.ProductoCarrito.Precio);
                    }
                    //  factura.CalcularSubtotal(item.Cantidad, item.ProductoCarrito.Precio);
                    factura.Subtotal =expor;                 
               Console.WriteLine("-----------------------------------------------------------------------");
                   // f1.Facturacion();                                       
              Console.WriteLine("Subtotal...:"+factura.CalcularSubtotal());
              Console.WriteLine("Descuento...:"+ factura.CalcularDescuento());
              Console.WriteLine("Su total es..:"+ factura.CalcularTotal());

                    break;

                case 2:
                    Factura_C_Registrado f2 = new Factura_C_Registrado();
                    Calculos_A_Pagar_Registrado c2 = new Calculos_A_Pagar_Registrado();
                    Console.WriteLine("------------------Desea ingresar sus datos----------------------");
                    Console.WriteLine("si o no"); string op2 = Console.ReadLine();
                    if (op2 == "si") { f2.LlenarDatos(); } else { }
 ;                   Console.WriteLine("------------------Productos comprados-------------------------");
                    Console.WriteLine("Productos -----------Cantidad--------Precio-------------------");
                    decimal con = 0;
                  foreach (var item in carrito.Detalle)
                    {
                    Console.WriteLine("{0}{1}\t\t{2}\t\t{3}", item.ProductoCarrito.Codigo, item.ProductoCarrito.Descripcion, item.Cantidad, item.ProductoCarrito.Precio);
                    con=con+(item.Cantidad * item.ProductoCarrito.Precio);
                    }
                    c2.Subtotal = con;
                    Console.WriteLine("------------------------------------------------------------------------");
                    // f1.Facturacion();                                       
                    Console.WriteLine("Subtotal...:" + c2.CalcularSubtotal());
                    Console.WriteLine("Descuento...:" + c2.CalcularDescuento());
                    Console.WriteLine("Su total es..:" + c2.CalcularTotal());

                    //  carrito.CalculaAlgo();
                    //  Console.WriteLine("algo..."+carrito.Sutotal+"..."+carrit);
                    break;
                case 3:
                    ClientePremiun cli3 = new ClientePremiun();
                    Factura_C_Premiun f3 = new Factura_C_Premiun();
                    Calculos_A_pagar_Premiun c3 = new Calculos_A_pagar_Premiun();
                    Console.WriteLine("------------------Desea ingresar sus datos----------------------");
                    Console.WriteLine("si o no"); string op3 = Console.ReadLine();
                    if (op3 == "si") { f3.LlenarDatos(); } else { }
                    decimal con3 = 0;
                    Console.WriteLine("------------------Productos comprados----------------------");
                    Console.WriteLine("Productos -----------Cantidad--------Precio-----------Descuento");
                    foreach (var item in carrito.Detalle)
                    {
                 Console.WriteLine("{0}{1}\t\t{2}\t\t{3}", item.ProductoCarrito.Codigo, item.ProductoCarrito.Descripcion, item.Cantidad, item.ProductoCarrito.Precio);
                        con3 = con3 + (item.Cantidad * item.ProductoCarrito.Precio);                        
                    }
                    c3.Subtotal = con3;
                    Console.WriteLine("------------------------------------------------------------------------");
                    Console.WriteLine("Subtotal...:" + c3.CalcularSubtotal());
                    Console.WriteLine("Descuento...:" + c3.CalcularDescuento());
                    Console.WriteLine("Su total es..:" + c3.CalcularTotal());
                    Console.WriteLine("------------------------------------------------------------------------");
                    Console.WriteLine("Facha de inscripcion.:"+cli3.FechaDeInscre());
                    break;
                default:
                    Console.WriteLine("Ha seleccionado una opcion no valida" +
                        "\nPor favor seleccione una opcion dentro del rango[1-3]");
                    break;
            }
           

    }
    }
}
