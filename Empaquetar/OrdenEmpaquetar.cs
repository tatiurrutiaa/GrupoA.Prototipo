using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Empaquetar
{
    public class OrdenEmpaquetar
    {
        public int Numero { get; set; }
        public List<Mercaderia> Productos { get; set; }

        public OrdenEmpaquetar()
        {
            Productos = new List<Mercaderia>();
        }

        public override string ToString()
        {
            return $"Orden #{Numero}";
        }
    }
}
