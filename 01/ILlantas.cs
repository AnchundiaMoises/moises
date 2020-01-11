using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface ILlantas
    {
        string informacion();
    }
    //Aqui tienes el tipo de llantas correctas
    class Llantas12: ILlantas
    {
        public string informacion()
        {
            return "Llantas de 14 pulgadas"; 
        }
    }
    class LlantasSuper : ILlantas
    {
        public string informacion()
        {
            return "Llantas de 18 pulgadas";
        }
    }
}
