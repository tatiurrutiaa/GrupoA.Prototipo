namespace GrupoA.Prototipo.DespachoSinTransportista
{
    public class Remito
    {
        public int NroRemito { get; set; }
        public string CuitCliente { get; set; }
        public DateTime Fecha { get; set; }
        public int DNITransportista { get; set; }
        public int NroDeposito { get; set; }
        public List<int> NroOrdenPreparacion { get; set; }
    }
}