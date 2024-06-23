using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos;
internal class OrdenPreparacionEntidad
{
    public int NroOrdenPrep { get; set; }
    public string CuitCliente { get; set; }
    public EstadoOrdenPreparacion Estado { get; set; }
    public DateTime Fecha { get; set; }
    public int? DNITransportista { get; set; }
    public int NroDeposito { get; set; }
    public List<MercaderiasDetalle> mercaderiaDetalle { get; set; } = new List<MercaderiasDetalle>();
}
