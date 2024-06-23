using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos
{
    internal class RemitoEntidad
    {
        public int NroRemito { get; set; }
        public string CuitCliente { get; set; }
        public DateTime Fecha { get; set; }
        public int DNITransportista { get; set; }
        public int NroDeposito { get; set; }
        public List<int> NroOrdenPreparacion { get; set; }
    }
}
