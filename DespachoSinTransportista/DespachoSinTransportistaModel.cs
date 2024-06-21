using GrupoA.Prototipo.RetiroStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoA.Prototipo.DespachoSinTransportista
{
    internal class DespachoSinTransportistaModel
    {
        public List<RetiroStock.OrdenPreparacion> ordenesPreparacion = new()
        {
            new() {NroOrdenPrep = 15, CuitCliente = "27-41672496-8", DNITransportista = 41672496,  Estado = "en despacho"},
            new() {NroOrdenPrep = 16, CuitCliente = "27-41672496-8", DNITransportista = null, Estado = "en despacho"},
            new() {NroOrdenPrep = 17, CuitCliente = "27-41672496-8", DNITransportista = null, Estado = "en despacho"},
            new() {NroOrdenPrep = 18, CuitCliente = "27-41672496-8", DNITransportista = null, Estado = "en despacho"},
            new() {NroOrdenPrep = 19, CuitCliente = "27-41672496-8", DNITransportista = null, Estado = "en despacho"},
            new() {NroOrdenPrep = 20, CuitCliente = "30-22465788-7", DNITransportista = null, Estado = "en despacho"},
            new() {NroOrdenPrep = 21, CuitCliente = "30-22465788-7", DNITransportista = null, Estado = "en despacho"},
            new() {NroOrdenPrep = 22, CuitCliente = "34-56564433-5", DNITransportista = null, Estado = "en despacho"},
            new() {NroOrdenPrep = 23, CuitCliente = "30-23456789-1", DNITransportista = null, Estado = "en despacho"},
            new() {NroOrdenPrep = 24, CuitCliente = "30-23456789-1", DNITransportista = null, Estado = "en despacho"},
            new() {NroOrdenPrep = 25, CuitCliente = "30-23456789-1", DNITransportista = null, Estado = "en despacho"}
        };

        public List<Remito> remitos = new();

        public List<RetiroStock.OrdenPreparacion> MercaderiaARetirar()
        {
            var ordenes = ordenesPreparacion.Where(o => o.Estado == "en despacho"
            && o.DNITransportista == null).ToList();

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
            return ordenes;
        }

        public void GenerarRemito(int dniTransportista, List<int> ordenesSeleccionadas)
        {
            // Obtener el último número de remito y sumarle uno
            int nuevoNroRemito = remitos.Any() ? remitos.Max(r => r.NroRemito) + 1 : 1;

            // Obtener el CUIT del cliente de la primera orden seleccionada
            var primeraOrden = ordenesPreparacion.FirstOrDefault(o => o.NroOrdenPrep == ordenesSeleccionadas.First());
            string cuitCliente = primeraOrden.CuitCliente;
            var deposito = primeraOrden.NroDeposito;

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