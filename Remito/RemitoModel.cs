using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Remito
{
    internal class RemitoModel
    {
        public List<Remito> Remitos { get; set; }

        public RemitoModel()
        {
            Remitos = new List<Remito>();
            new Remito { NroRemito = "Ref", Fecha = DateTime.Now };
        }
    }
}
