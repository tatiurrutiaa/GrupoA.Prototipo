using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.EmpaquetarMercaderia
{
    public class MercaderiasDetalle
    {
        public string NombreDeposito { get; set; } //no va acá, debe estar en clase ordenPreparacion
        public int CodProducto { get; set; }
        public string DescProducto { get; set; } //hay que eliminar esta propiedad
        //la desc hay que buscarla desde el archivo mercadería
        public int CantidadProducto { get; set; }

        internal string? FirstOrDefault(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
