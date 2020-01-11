using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Producto
    {
        //el objeto bajo Construccion.
        //La clase producto representa el producto que el builder va 
        //a construir a traves de lo que diga el Director
        private IMotor motor;
        private ICarroceria carroceria;
        private ILlantas llantas;

        public void ColocarMotor(IMotor pMotor)
        {
            motor = pMotor;
            Console.WriteLine("Se ha colocado el motor:{0}",motor.especificaciones());
        }
        public void ColocarCarroceria (ICarroceria pCarroceria)
        {
            carroceria = pCarroceria;
            Console.WriteLine("Se ha colocado una carroceria:{0}",carroceria.caracteristicas());
        }
        public void ColocarLlantas(ILlantas pLlantas)
        {
            llantas = pLlantas;
            Console.WriteLine("Se ha colocado las llantas:{0}",llantas.informacion());
        }
        public void MostrarAuto()
        {
            Console.WriteLine("Tu auto tiene {0},{1},{2}",motor.especificaciones(),
                llantas.informacion(),carroceria.caracteristicas());
        }
    }
}
