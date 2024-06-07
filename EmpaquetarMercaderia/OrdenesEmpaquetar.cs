using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.EmpaquetarMercaderia
{
    public class OrdenesEmpaquetar
    {
        public int NroOrdenPrep { get; set; }
        public string Mercaderia { get; set; }
        public string IdProducto { get; set; }
        public int Cantidad { get; set; }
        public string Estado { get; set; }
    }
}
