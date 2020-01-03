using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaElextronica
{
    interface IProcesosTranssaccionales
    {
        public decimal CalcularSubtotal();
        public decimal CalcularDescuento();
       public decimal CalcularTotal();
    }
}
