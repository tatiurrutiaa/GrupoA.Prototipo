using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Empaquetar
{
    public class Orden
    {
        public string Nombre { get; set; }
        public List<string> Items { get; set; }

        public Orden(string nombre, List<string> items)
        {
            Nombre = nombre;
            Items = items;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
