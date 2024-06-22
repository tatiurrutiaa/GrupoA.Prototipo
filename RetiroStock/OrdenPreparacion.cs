
using GrupoA.Prototipo.EmpaquetarMercaderia;

namespace GrupoA.Prototipo.RetiroStock
{
    public class OrdenPreparacion
    {
        public int NroOrdenPrep { get; set; }
        public string CuitCliente { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
        public int? DNITransportista { get; set; }
        public int NroDeposito { get; set; }
        public List<MercaderiasDetalle> mercaderiaDetalle { get; set; } = new List<MercaderiasDetalle>();

        internal static IEnumerable<object> Where(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}