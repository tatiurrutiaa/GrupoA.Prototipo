
using GrupoA.Prototipo.EmpaquetarMercaderia;

namespace GrupoA.Prototipo.RetiroStock
{
    public class OrdenPreparacion
    {
        public int NroOrdenPrep { get; internal set; }
        public string CuitCliente { get; internal set; }
        public string Estado { get; internal set; }
        public DateTime Fecha { get; internal set; }
        public int? DNITransportista { get; internal set; }
        public List<MercaderiasDetalle> mercaderiaDetalle { get; set; } = new List<MercaderiasDetalle>();

        internal static IEnumerable<object> Where(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}