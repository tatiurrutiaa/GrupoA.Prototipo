﻿namespace GrupoA.Prototipo.RetiroStock
{
    public class Stock
    {
        public string CuitCliente { get; internal set; }
        public string Posicion { get; internal set; }
        public int Cantidad { get; internal set; }
        public int CodProducto { get; internal set; }
        public string Estado { get; internal set; }
    }
}