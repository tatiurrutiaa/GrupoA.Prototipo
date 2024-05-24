using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Empaquetar
{
    public class Orden
    {
        public int Numero { get; set; }
        public List<Producto> Productos { get; set; }

        public Orden()
        {
            Productos = new List<Producto>();
        }

        public override string ToString()
        {
            return $"Orden #{Numero}";
        }
    }
}
