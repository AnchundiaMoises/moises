using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaElextronica
{
    class Calculos_A_Pagar_Registrado : IProcesosTranssaccionales
    {
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public decimal CalcularDescuento()
        {
            this.Descuento = this.Subtotal * 0.05M;
                    
            return Descuento;
        }

        public decimal CalcularSubtotal()
        {
            return Subtotal;
        }

        public decimal CalcularTotal()
        {
            this.Total = Subtotal - Descuento;
            return Total; 
        }
    }
}
