using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Empaquetar
{
    public class Producto
    {
            public string IdProducto { get; set; }
            public string NombreProducto { get; set; }
            public int CantidadProducto { get; set; }

            public Producto()
            {
                IdProducto = string.Empty;
                NombreProducto = string.Empty;
            }

            public override string ToString()
            {
                return $"[ID: {IdProducto}], Producto: {NombreProducto}, (Cantidad: {CantidadProducto})";
            }
    }
}
