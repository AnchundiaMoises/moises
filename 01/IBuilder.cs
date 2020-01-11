using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface IBuilder
    {
        void ConstrulleMotor();
        void ConstrulleCarroceria();
        void ConstrulleLlantas();
    }
}
