using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class BuilderDeportivo: IBuilder
    {
        //una clase que invocada por el director 
        //paracrear las partes del producto.
        private Producto auto = new Producto();

        public void ConstrulleMotor()
        {
            auto.ColocarMotor(new MotorGrande());
        }
        public void ConstrulleLlantas()
        {
            auto.ColocarLlantas(new LlantasSuper());
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
