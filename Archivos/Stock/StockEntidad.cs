using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrupoA.Prototipo.Archivos.Estados;

namespace GrupoA.Prototipo.Archivos.Stock;
internal class StockEntidad
{
    public string CuitCliente { get; set; }
    public string Posicion { get; set; }
    public int Cantidad { get; set; }
    public int CodProducto { get; set; }
    public EstadosStock Estado { get; set; }
    public int NroDeposito { get; set; }
}

