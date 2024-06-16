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
                new() { NroOrdenPrep = 15, CuitCliente = "27-41672496-8", DNITransportista = 41672496, Estado = "preparada" },
                new() { NroOrdenPrep = 16, CuitCliente = "27-41672496-8", DNITransportista = 46546462, Estado = "preparada" },
                new() { NroOrdenPrep = 17, CuitCliente = "27-41672496-8", DNITransportista = 16234853, Estado = "preparada" },
                new() { NroOrdenPrep = 18, CuitCliente = "27-41672496-8", DNITransportista = null, Estado = "preparada" },
                new() { NroOrdenPrep = 19, CuitCliente = "27-41672496-8", DNITransportista = 16280699, Estado = "ingresada" },
                new() { NroOrdenPrep = 20, CuitCliente = "30-22465788-7", DNITransportista = 20568962, Estado = "preparada" },
                new() { NroOrdenPrep = 21, CuitCliente = "30-22465788-7", DNITransportista = null, Estado = "preparada" },
                new() { NroOrdenPrep = 22, CuitCliente = "34-56564433-5", DNITransportista = 35101021, Estado = "preparada" },
                new() { NroOrdenPrep = 23, CuitCliente = "30-23456789-1", DNITransportista = null, Estado = "preparada" },
                new() { NroOrdenPrep = 24, CuitCliente = "30-23456789-1", DNITransportista = 40504002, Estado = "preparada" },
                new() { NroOrdenPrep = 25, CuitCliente = "30-23456789-1", DNITransportista = 37568798, Estado = "preparada" }
            };
        }

        public List<RetiroStock.OrdenPreparacion> MercaderiaARetirar()
        {
            return ordenesPreparacion.Where(orden => orden.Estado == "preparada" && orden.DNITransportista.HasValue).ToList();
        }

        public List<RetiroStock.OrdenPreparacion> ObtenerOrdenesPorDNI(int dniTransportista)
        {
            return ordenesPreparacion.Where(orden => orden.Estado == "preparada" && orden.DNITransportista == dniTransportista).ToList();
        
            /*if (ordenes == null)
            {
                MessageBox.Show("No hay ordenes de preparación para despachar." +
                    "Por favor, intente nuevamente en unos minutos.");
                return null;
            }
            else
            {
                return ordenes;
            }*/
        }
    }
}
