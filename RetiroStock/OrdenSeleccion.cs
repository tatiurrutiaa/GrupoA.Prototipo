using GrupoA.Prototipo.Archivos.Estados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.RetiroStock
{
    internal class OrdenSeleccion
    {
        public int NroOrdenSelec { get; internal set; }
        public List<int> NroOrdenesPreparacion { get; set; }
        public EstadosOrdenSeleccion Estado { get; internal set; }
    }
}
