using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.OrdenEntrega
{
    internal class Pedido
    {
        public string NroPedido { get; set; }
        public DateTime Fecha { get; set; }
        public string Cuit { get; set; }
        public string RazonSocial { get; set; }
        public string NroRemito { get; set; }
        public DateTime FechaRemito { get; set; }
    }
}
