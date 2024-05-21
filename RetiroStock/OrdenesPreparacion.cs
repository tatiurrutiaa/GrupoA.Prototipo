namespace GrupoA.Prototipo.RetiroStock
{
    public class OrdenesPreparacion
    {
        public int NroOrdenPrep { get; internal set; }
        public string CuitCliente { get; internal set; }
        public int Cantidad { get; internal set; }
        public string Mercaderia { get; internal set; }
        public string Estado { get; internal set; }
    }
}