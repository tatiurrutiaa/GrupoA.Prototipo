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
                new() { NroOrdenPrep = 30, CuitCliente = "27-41672496-8", DNITransportista = 30000100, Estado = "preparada" },
                new() { NroOrdenPrep = 31, CuitCliente = "27-41672496-8", DNITransportista = 30100200, Estado = "preparada" },
                new() { NroOrdenPrep = 32, CuitCliente = "27-41672496-8", DNITransportista = 30200300, Estado = "preparada" },
                new() { NroOrdenPrep = 33, CuitCliente = "27-41672496-8", DNITransportista = 30200300, Estado = "preparada" },
                new() { NroOrdenPrep = 34, CuitCliente = "27-41672496-8", DNITransportista = 30400500, Estado = "preparada" },
                new() { NroOrdenPrep = 35, CuitCliente = "30-22465788-7", DNITransportista = 30400500, Estado = "preparada" },
                new() { NroOrdenPrep = 36, CuitCliente = "30-22465788-7", DNITransportista = 30400500, Estado = "preparada" },
                new() { NroOrdenPrep = 37, CuitCliente = "34-56564433-5", DNITransportista = 35101021, Estado = "preparada" },
                new() { NroOrdenPrep = 38, CuitCliente = "30-23456789-1", DNITransportista = 40900745, Estado = "preparada" },
                new() { NroOrdenPrep = 39, CuitCliente = "30-23456789-1", DNITransportista = 40504002, Estado = "preparada" },
                new() { NroOrdenPrep = 40, CuitCliente = "30-23456789-1", DNITransportista = 37568798, Estado = "preparada" }
            };
        }

        public List<RetiroStock.OrdenPreparacion> MercaderiaARetirar()
        {
            return ordenesPreparacion.Where(orden => orden.Estado == "preparada" && orden.DNITransportista.HasValue).ToList();
        }

        public List<RetiroStock.OrdenPreparacion> ObtenerOrdenesPorDNI(int dniTransportista)
        {
            return ordenesPreparacion.Where(orden => orden.Estado == "preparada" && orden.DNITransportista == dniTransportista).ToList();
        }
    }
}
