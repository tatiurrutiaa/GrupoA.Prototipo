using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos.Ordenes.OrdenEntrega;
internal class OrdenEntregaEntidad
{
    public int NroOrdenEntrega { get; set; }
    public List<int> NroOrdenPreparacion { get; set; }
}
