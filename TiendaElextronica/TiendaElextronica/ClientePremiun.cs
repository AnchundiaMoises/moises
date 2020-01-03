using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaElextronica
{
    class ClientePremiun:Cliente
    {
        public int PuntageCom { get; set; }
        public DateTime FechaInscriccion{ get; set; }
        public decimal FechaDeInscre()
        {
            TimeSpan timeSpan = DateTime.Today - this.FechaInscriccion;
            int dias = timeSpan.Days;
            int fecha = dias / 365;
            return fecha;
        }
    }
}
