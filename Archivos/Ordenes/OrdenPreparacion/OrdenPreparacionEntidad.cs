using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrupoA.Prototipo.Archivos.Estados;
using GrupoA.Prototipo.Archivos.Mercaderias;

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
