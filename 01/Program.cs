using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director miDirector = new Director();

            //contruimos un auto economico
            BuilderNormal normal = new BuilderNormal();
            miDirector.Construye(normal);

            //odtenemos el auto
            Producto auto1 = normal.ObtenProducto();

            auto1.MostrarAuto();

            Console.WriteLine("--------");

            //contruimos auto deportivo

            BuilderDeportivo deportivo = new BuilderDeportivo();
            miDirector.Construye(deportivo);

            //odtenemos el auto
            Producto auto2 = deportivo.ObtenProducto();

            auto2.MostrarAuto();

        }
    }
}
