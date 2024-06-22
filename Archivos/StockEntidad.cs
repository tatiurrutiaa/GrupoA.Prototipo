using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos;
internal class StockEntidad
{
    //1 reg x producto/posicion/cliente
    public string CuitCliente { get; internal set; }
    public string Posicion { get; internal set; }
    public int Cantidad { get; internal set; }
    public int CodProducto { get; internal set; }
    public EstadosStock Estado { get; internal set; }
}

//20-44444--44444 AAA 496 Remeras Almacenado
//20-44444--44444 AAA 1 Remeras Despachada
//20-44444--44444 AAA 1 Remeras Despachada
//20-44444--44444 AAA 1 Remeras Despachada




//3 ordenes preparacion: A, B, C cada 1 x 1 remera.
//1 orden de seleccion (contiene A B C)
//A, B, C => seleccionadas
//A, B, C => preparadas
//1 orden de preparacion D x 1 remera.
