using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaElextronica
{
    class ListaDeProductos
    {
        public ListaDeProductos()
        {
            StockProductos = new List<Producto>();
        }
        public List<Producto> StockProductos { get; set; }

        public void GeneraProductos()
        {
            Random random = new Random();
            int numero;
            for (int i = 1; i <= 10; i++)
            {
                Producto producto = new Producto();
                producto.Codigo = i;
                numero = random.Next(20);
                char letra = (char)(((int)'A') + random.Next(26));
                producto.Descripcion = "Xtechnology " + letra + i;
                producto.Precio =numero; 

                StockProductos.Add(producto);
            }
        }
        public void imprimirlistado()
        {
            Console.WriteLine("Stock De Productos");
            Console.WriteLine("Identificador\tDescripcion\t\t\tPrecio");
            foreach (var item in StockProductos)
            {
                Console.WriteLine("{0}\t\t{1}\t\t\t{2}",
                item.Codigo, item.Descripcion, item.Precio);
            }
        }
    }
}
