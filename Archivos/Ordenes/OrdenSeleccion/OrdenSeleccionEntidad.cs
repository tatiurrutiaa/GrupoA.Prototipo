using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrupoA.Prototipo.Archivos.Estados;

namespace GrupoA.Prototipo.Archivos.Ordenes.OrdenSeleccion;
internal class OrdenSeleccionEntidad
{
    public int NroOrdenSelec { get; set; }
    public List<int> NroOrdenesPreparacion { get; set; }
    public EstadosOrdenSeleccion Estado { get; set; }
}
