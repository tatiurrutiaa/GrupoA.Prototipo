using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos;
internal class OrdenSeleccionEntidad
{
    public EstadosOrdenSeleccion Estado { get; internal set; }
    public int NroOrdenSelec { get; internal set; }
    public List<int> NroOrdenesPreparacion { get; set; }
}
