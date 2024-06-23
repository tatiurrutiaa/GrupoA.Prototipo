using GrupoA.Prototipo.Archivos;
using GrupoA.Prototipo.Archivos.Estados;
using GrupoA.Prototipo.Archivos.Mercaderias;
using GrupoA.Prototipo.Forms.RetiroStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Forms.EmpaquetarMercaderia.Model
{
    public class EmpaquetarMercaderiaModel
    {
        public int OrdenEnPantalla()
        {
            return OrdenPreparacionArchivo.OrdenesPreparacion
                .Where(o => o.Estado == EstadosOrdenPreparacion.Seleccionada)
                .OrderBy(o => o.NroOrdenPrep)
                .Select(o => o.NroOrdenPrep)
                .FirstOrDefault();
        }

        public static List<OrdenPreparacion> ObtenerOrdenesSeleccionadas()
        {
            var ordenes = new List<OrdenPreparacion>();
            foreach (var OrdenPreparacionEntidad in OrdenPreparacionArchivo.OrdenesPreparacion
                    .Where(o => o.Estado == EstadosOrdenPreparacion.Seleccionada).ToList())
            {
                var orden = new OrdenPreparacion();
                orden.NroOrdenPrep = OrdenPreparacionEntidad.NroOrdenPrep;
                orden.CuitCliente = OrdenPreparacionEntidad.CuitCliente;
                orden.Estado = OrdenPreparacionEntidad.Estado;
                orden.Fecha = OrdenPreparacionEntidad.Fecha;
                orden.DNITransportista = OrdenPreparacionEntidad.DNITransportista;
                orden.NroDeposito = OrdenPreparacionEntidad.NroDeposito;
                orden.mercaderiaDetalle = OrdenPreparacionEntidad.mercaderiaDetalle;
                ordenes.Add(orden);
            }
            return ordenes;
        }

        public string BuscarDescProducto(int codProducto)
        {
            string descproducto = MercaderiaArchivo.BuscarDescripcion(codProducto);
            return descproducto;
        }

        public void CambiarEstadoOrden(int nroOrdenPrep)
        {
            var orden = OrdenPreparacionArchivo.OrdenesPreparacion.FirstOrDefault(o => o.NroOrdenPrep == nroOrdenPrep);
            if (orden != null)
            {
                OrdenPreparacionArchivo.ModificarEstado(orden, EstadosOrdenPreparacion.Preparada);
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

