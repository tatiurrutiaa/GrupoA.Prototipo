using GrupoA.Prototipo.RetiroStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.OrdenEntrega
{
    public class OrdenEntrega
    {
        public int NroOrdenEntrega { get; set; }
        public List<int> NroOrdenPreparacion { get; set; }
    }
}
