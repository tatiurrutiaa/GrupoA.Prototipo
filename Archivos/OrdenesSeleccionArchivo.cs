using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos;
internal static class OrdenesSeleccionArchivo
{
    static List<OrdenSeleccionEntidad> ordenes;

    public static IReadOnlyCollection<OrdenSeleccionEntidad> Ordenes => ordenes.AsReadOnly();

    internal static void AgregarOrden(OrdenSeleccionEntidad nuevaOrdenEntrega)
    {
        ordenes.Add(nuevaOrdenEntrega); 
    }
}
