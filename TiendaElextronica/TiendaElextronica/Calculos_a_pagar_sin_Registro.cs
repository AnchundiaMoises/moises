using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaElextronica
{
    class Calculos_a_pagar_sin_Registro:IProcesosTranssaccionales
        

    {
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }


        public decimal CalcularSubtotal()
        {
            return Subtotal;
            //this.Subtotal = expor; ;
        }


        public decimal CalcularDescuento()
        {
            if (this.Subtotal >= 100)
            { this.Descuento = this.Subtotal * 0.05M; }
            else { this.Descuento = 0; }
            return Descuento;
         }
        public decimal CalcularTotal()
        {
            this.Total = Subtotal - Descuento;
            return Total;
        }

       
    }

}
/* public void CalcularSubtotal()
         {
             //FacturaCarrito factu = new FacturaCarrito();
             decimal conta = 0;
             foreach (var item in this.Detalle)
             {
                 conta = conta + (item.Cantidad * item.ProductoCarrito.Precio);
             }
             this.Subtotal = conta;
         }*/
//public void CalcularSubtotal(int cantida, decimal precio)

//  {
//decimal subtotal = 0;
//foreach (int item in cantida ) { 
//do
// {

// subtotal = subtotal + (cantida * precio);
// this.Subtotal = subtotal;
//  }
//  } while (cantida != 0);
//return CalcularSub;

// }