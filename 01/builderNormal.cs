using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class BuilderNormal:IBuilder
    {
        private Producto auto = new Producto();

        public void ConstrulleMotor()
        {
            auto.ColocarMotor(new MotorBasico());
        }
        public void ConstrulleLlantas()
        {
            auto.ColocarLlantas(new Llantas12());
        }
        public void ConstrulleCarroceria()
        {
            auto.ColocarCarroceria(new CarroceriaBasica());
        }
        public Producto ObtenProducto()
        {
            return auto;
        }
    }
}
