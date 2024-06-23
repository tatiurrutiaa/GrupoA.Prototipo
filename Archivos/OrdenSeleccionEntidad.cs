using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos;
internal class OrdenSeleccionEntidad
{
    public int NroOrdenSelec { get; set; }
    public List<int> NroOrdenesPreparacion { get; set; }
    public EstadosOrdenSeleccion Estado { get; set; }
}
