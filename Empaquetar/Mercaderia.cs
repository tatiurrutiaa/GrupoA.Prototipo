using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Empaquetar
{
    public class Mercaderia
    {
            public string IdProducto { get; set; }
            public string NombreProducto { get; set; }
            public int CantidadProducto { get; set; }

            public Mercaderia()
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
