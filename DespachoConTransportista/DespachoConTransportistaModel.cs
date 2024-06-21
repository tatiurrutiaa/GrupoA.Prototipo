using GrupoA.Prototipo.DespachoSinTransportista;
using GrupoA.Prototipo.RetiroStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.DespachoConTransportista
{
    internal class DespachoConTransportistaModel
    {
        public List<RetiroStock.OrdenPreparacion> ordenesPreparacion { get; set;}

        public DespachoConTransportistaModel()
        {
            ordenesPreparacion = new List<RetiroStock.OrdenPreparacion>
            {
                new() { NroOrdenPrep = 30, CuitCliente = "27-41672496-8", DNITransportista = 30000100, Estado = "en despacho" },
                new() { NroOrdenPrep = 31, CuitCliente = "27-41672496-8", DNITransportista = 30100200, Estado = "en despacho" },
                new() { NroOrdenPrep = 32, CuitCliente = "27-41672496-8", DNITransportista = 30200300, Estado = "en despacho" },
                new() { NroOrdenPrep = 33, CuitCliente = "27-41672496-8", DNITransportista = 30200300, Estado = "en despacho" },
                new() { NroOrdenPrep = 34, CuitCliente = "27-41672496-8", DNITransportista = 30400500, Estado = "en despacho" },
                new() { NroOrdenPrep = 35, CuitCliente = "30-22465788-7", DNITransportista = 30400500, Estado = "en despacho" },
                new() { NroOrdenPrep = 36, CuitCliente = "30-22465788-7", DNITransportista = 30400500, Estado = "en despacho" },
                new() { NroOrdenPrep = 37, CuitCliente = "34-56564433-5", DNITransportista = 35101021, Estado = "en despacho" },
                new() { NroOrdenPrep = 38, CuitCliente = "30-23456789-1", DNITransportista = 40900745, Estado = "en despacho" },
                new() { NroOrdenPrep = 39, CuitCliente = "30-23456789-1", DNITransportista = 40504002, Estado = "en despacho" },
                new() { NroOrdenPrep = 40, CuitCliente = "30-23456789-1", DNITransportista = 37568798, Estado = "en despacho" }
            };
        }

        public List<Remito> remitos = new();

        public List<RetiroStock.OrdenPreparacion> MercaderiaARetirar()
        {
            return ordenesPreparacion.Where(orden => orden.Estado == "en despacho" && orden.DNITransportista.HasValue).ToList();
        }

        public List<RetiroStock.OrdenPreparacion> ObtenerOrdenesPorDNI(int dniTransportista)
        {
            return ordenesPreparacion.Where(orden => orden.Estado == "en despacho" && orden.DNITransportista == dniTransportista).ToList();
        }
        public void GenerarRemito(int dniTransportista, List<int> ordenesSeleccionadas)
        {
            // Obtener el último número de remito y sumarle uno
            int nuevoNroRemito = remitos.Any() ? remitos.Max(r => r.NroRemito) + 1 : 1;

            // Obtener el CUIT del cliente de la primera orden seleccionada
            var primeraOrden = ordenesPreparacion.FirstOrDefault(o => o.NroOrdenPrep == ordenesSeleccionadas.First());
            var deposito = primeraOrden.NroDeposito;
            string cuitCliente = primeraOrden.CuitCliente;

            // Crear un nuevo remito
            var nuevoRemito = new Remito
            {
                NroRemito = nuevoNroRemito,
                CuitCliente = cuitCliente,
                Fecha = DateTime.Now,
                DNITransportista = dniTransportista,
                NroOrdenPreparacion = ordenesSeleccionadas,
                NroDeposito = deposito
            };

            // Agregar el remito a la lista de remitos
            remitos.Add(nuevoRemito);
        }
    }
}
