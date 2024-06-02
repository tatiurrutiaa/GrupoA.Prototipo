using GrupoA.Prototipo.RetiroStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoA.Prototipo.Salida
{
    internal class SalidaModel
    {
        public List<OrdenesPreparacion> ordenesPreparacion = new()
        {
        new() {NroOrdenPrep = 15, CuitCliente = "27-41672496-8", DNITransportista = 41672496,  Estado = "preparada"},
        new() {NroOrdenPrep = 16, CuitCliente = "27-41672496-8", DNITransportista = null, Estado = "preparada"},
        new() {NroOrdenPrep = 17, CuitCliente = "27-41672496-8", DNITransportista = null, Estado = "preparada"},
        new() {NroOrdenPrep = 18, CuitCliente = "27-41672496-8", DNITransportista = null, Estado = "preparada"},
        new() {NroOrdenPrep = 19, CuitCliente = "27-41672496-8", DNITransportista = null, Estado = "ingresada"},
        new() {NroOrdenPrep = 20, CuitCliente = "30-22465788-7", DNITransportista = null, Estado = "preparada"},
        new() {NroOrdenPrep = 21, CuitCliente = "30-22465788-7", DNITransportista = null, Estado = "preparada"},
        new() {NroOrdenPrep = 22, CuitCliente = "34-56564433-5", DNITransportista = null, Estado = "preparada"},
        new() {NroOrdenPrep = 23, CuitCliente = "30-23456789-1", DNITransportista = null, Estado = "preparada"},
        new() {NroOrdenPrep = 24, CuitCliente = "30-23456789-1", DNITransportista = null, Estado = "preparada"},
        new() {NroOrdenPrep = 25, CuitCliente = "30-23456789-1", DNITransportista = null, Estado = "preparada"}
        };

        public List<OrdenesPreparacion> MercaderiaARetirar()
        {
            var ordenes = ordenesPreparacion.Where(o => o.Estado == "preparada"
            && o.DNITransportista == null).ToList();

            if (ordenes == null)
            {
                MessageBox.Show("No hay ordenes de preparación para despachar." +
                    "Por favor, intente nuevamente en unos minutos.");
                return null;
            }
            else
            {
                return ordenes;
            }
        }
    }
}
