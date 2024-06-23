using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos;
internal class StockEntidad
{
    public string CuitCliente { get; internal set; }
    public string Posicion { get; internal set; }
    public int Cantidad { get; internal set; }
    public int CodProducto { get; internal set; }
    public EstadosStock Estado { get; internal set; }
    public int NroDeposito { get; internal set; }
}

