using GrupoA.Prototipo.Archivos;
using GrupoA.Prototipo.RetiroStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.EmpaquetarMercaderia
{
    public class EmpaquetarMercaderiaModel
    {
        public List<RetiroStock.OrdenPreparacion> ordenesPreparacion = ArchivoOrdenPreparacion.OrdenesPreparacion.ToList();
        public List<RetiroStock.Mercaderia> mercaderia = ArchivoMercaderia.Mercaderias.ToList();

        public int OrdenEnPantalla()
        {
            return ordenesPreparacion
                .Where(o => o.Estado == "seleccionada")
                .OrderBy(o => o.NroOrdenPrep)
                .Select(o => o.NroOrdenPrep)
                .FirstOrDefault();
        }

        public List<RetiroStock.OrdenPreparacion> ObtenerOrdenesSeleccionadas()
        {
            var ordenesSeleccionadas = ordenesPreparacion.Where(o => o.Estado == "seleccionada").ToList();

            foreach (var orden in ordenesSeleccionadas)
            {
                foreach (var mercaderiaDetalle in orden.mercaderiaDetalle)
                {
                    var descProducto = mercaderia.FirstOrDefault(m => m.CodProducto
                    == mercaderiaDetalle.CodProducto)?.DescProducto;
                    mercaderiaDetalle.DescProducto = descProducto ?? "Descripción no encontrada";
                }
            }
            return ordenesSeleccionadas;
        }

        public void CambiarEstadoOrden(int nroOrdenPrep, string nuevoEstado)
        {
            var orden = ordenesPreparacion.FirstOrDefault(o => o.NroOrdenPrep == nroOrdenPrep);
            if (orden != null)
            {
                //orden.Estado = nuevoEstado;
                ArchivoOrdenPreparacion.ModificarEstado(orden, "preparada");
            }
        }

        /*public string ObtenerCuitCliente(int nroOrden)
        {
            // Buscar la orden correspondiente al número de orden proporcionado
            var orden = OrdenesPreparacion.FirstOrDefault(o => o.NroOrdenPrep == nroOrden);

            // Si se encontró la orden, devolver el CUIT del cliente; de lo contrario, devolver una cadena vacía
            return orden != null ? orden.CuitCliente : "";
        }*/
    }
}
