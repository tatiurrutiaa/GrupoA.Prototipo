using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos;
internal class StockEntidad
{
    public string CuitCliente { get; set; }
    public string Posicion { get; set; }
    public int Cantidad { get; set; }
    public int CodProducto { get; set; }
    public EstadosStock Estado { get; set; }
    public int NroDeposito { get; set; }
}

