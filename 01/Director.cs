using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Director
    {
        public void Construye(IBuilder pConstructor)
        {
            /*Aqui el Director indica los pasos para hacer la contruccion 
             * pero el constructor es el quev se encarga de construir segun 
             * esta especificacion*/
            pConstructor.ConstrulleMotor();
            pConstructor.ConstrulleCarroceria();
            pConstructor.ConstrulleLlantas();
        }
    }    
}
