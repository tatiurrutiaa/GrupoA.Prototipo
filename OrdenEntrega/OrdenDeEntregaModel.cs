using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.OrdenEntrega
{
    internal class OrdenDeEntregaModel
    {
        public List<Pedido> OrdenDeEntrega { get; set; }
        public OrdenDeEntregaModel() { OrdenDeEntrega = new List<Pedido>(); }

    }
}
