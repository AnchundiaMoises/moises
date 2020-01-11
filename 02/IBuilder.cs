using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface IBuilder
    {
        //interfas que define que se puede construir
        void ConstrulleMotor();
        void ConstrulleCarroceria();
        void ConstrulleLlantas();
    }
}
