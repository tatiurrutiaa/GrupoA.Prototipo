using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.OrdenSeleccion
{
    internal class OrdenSeleccionModel
    {
        // Modelo de Orden de Seleccion
    }
}
// Modelos/Orden.cs
public class Orden
{
    public int OrdenId { get; set; }
    public string Estado { get; set; }
    public List<Producto> Productos { get; set; }
}

// Modelos/Producto.cs
public class Producto
{
    public int ProductoId { get; set; }
    public string Nombre { get; set; }
    public int CantidadRequerida { get; set; }
    public int CantidadDisponible { get; set; }
    public string UbicacionAlmacen { get; set; }
}

// Modelos/OrdenSeleccion.cs
public class OrdenSeleccion
{
    public int OrdenSeleccionId { get; set; }
    public int OrdenId { get; set; }
    public List<ProductoSeleccionado> ProductosSeleccionados { get; set; }
}

// Modelos/ProductoSeleccionado.cs
public class ProductoSeleccionado
{
    public int ProductoId { get; set; }
    public int CantidadARecoger { get; set; }
    public string UbicacionAlmacen { get; set; }
}
