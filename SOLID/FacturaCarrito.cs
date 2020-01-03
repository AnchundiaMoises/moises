using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaElextronica
{
    public class  FacturaCarrito
    {

        public FacturaCarrito()
        {
            this.Detalle = new List<DetalleFactura>();
        }
        // public ListadoClientes Cabecera { get; set; }

        public List<DetalleFactura> Detalle { get; set; }
        //public void CalcularDescuento();
       // public decimal Sutotal { get; set; }
       /*  public void CalculaAlgo()
         {
             decimal conta = 0;
             foreach(var item in  this.Detalle)
             {
                 conta = conta + (item.Cantidad * item.ProductoCarrito.Precio);
             }
             this.Sutotal = conta;
         }*/


    }
}

