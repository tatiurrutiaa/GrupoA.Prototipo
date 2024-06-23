using GrupoA.Prototipo.Archivos;
using GrupoA.Prototipo.Archivos.Cliente;
using GrupoA.Prototipo.Archivos.Deposito;
using GrupoA.Prototipo.Archivos.Estados;
using GrupoA.Prototipo.Archivos.Mercaderias;
using GrupoA.Prototipo.Archivos.Stock;
using GrupoA.Prototipo.EmpaquetarMercaderia;
using GrupoA.Prototipo.Forms.OrdenPreparacion.ModelClases;
using GrupoA.Prototipo.Forms.RetiroStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Forms.OrdenPreparacion.Model;
internal class OrdenPreparacionModel
{
    public Cliente BuscarCliente(string cuit)
    {
        foreach (ClienteEntidad clienteEntidad in ClienteArchivo.Clientes)
        {
            if (clienteEntidad.CuitCliente == cuit)
            {
                return new Cliente { Cuit = clienteEntidad.CuitCliente, RazonSocial = clienteEntidad.RazonSocial };
            }
        }

        return null;
    }

    public List<Deposito> Depositos
    {
        get
        {
            var depositos = new List<Deposito>();
            foreach (var depositoEntidad in DepositoArchivo.Depositos)
            {
                var depo = new Deposito();
                depo.NumDeposito = depositoEntidad.NroDeposito;
                depo.NombreDeposito = depositoEntidad.NombreDeposito;

                depositos.Add(depo);
            }

            return depositos;
        }
    }
    public int NuevoNroOrden()
    {
        int nuevoNroOrden = (OrdenPreparacionArchivo.OrdenesPreparacion.Any() ? OrdenPreparacionArchivo.OrdenesPreparacion.Max(o => o.NroOrdenPrep) : 0) + 1;
        return nuevoNroOrden;
    }

    public List<string> ObtenerDepositosPorCliente(string cuitCliente)
    {
        // Filtrar los stocks por el CuitCliente proporcionado y obtener los números de depósito únicos
        var depositosUnicos = StockArchivo.Stocks
            .Where(s => s.CuitCliente == cuitCliente)
            .Select(s => s.NroDeposito)
            .Distinct()
            .ToList();

        var nombresDepositos = new List<string>();

        // Obtener los nombres de los depósitos únicos
        foreach (var deposito in depositosUnicos)
        {
            var nombreDeposito = DepositoArchivo.BuscarNombreDeposito(deposito);
            nombresDepositos.Add(nombreDeposito);
        }

        return nombresDepositos;
    }

    public List<(int CantidadTotal, int CodProducto, string Descripcion)> ObtenerMercaderiaDelDeposito(string cuitCliente, string nombredeposito)
    {
        int nroDeposito = DepositoArchivo.BuscarNroDeposito(nombredeposito);
        var productosPorClienteYDeposito = StockArchivo.Stocks
            .Where(s => s.CuitCliente == cuitCliente && s.NroDeposito == nroDeposito
            && (s.Estado == EstadosStock.Ingresado || s.Estado == EstadosStock.Almacenado))
            .GroupBy(s => s.CodProducto)
            .Select(g => (
                CantidadTotal: g.Sum(s => s.Cantidad),
                CodProducto: g.Key,
                Descripcion: MercaderiaArchivo.BuscarDescripcion(g.Key)
            ))
            .ToList();

        return productosPorClienteYDeposito;
    }

    public void CrearOrdenYActualizarStock(string cuit, int dni, string nombredeposito, ListBox ListaMercaderiaEnOrdenPreparacion)
    {
        int nroorden = NuevoNroOrden();
        var estado = EstadosOrdenPreparacion.Pendiente;
        var mercaderiaDetalleList = new List<MercaderiasDetalle>();

        foreach (var item in ListaMercaderiaEnOrdenPreparacion.Items)
        {
            string[] partes = item.ToString().Split(new string[] { " - " }, StringSplitOptions.None);
            string descripcion = partes[0];
            int cantidad = int.Parse(partes[1]);

            int codProducto = MercaderiaArchivo.BuscarCodProducto(descripcion);

            // Creamos un nuevo detalle de mercadería y lo agregamos a la lista
            var detalle = new MercaderiasDetalle
            {
                CodProducto = codProducto,
                CantidadProducto = cantidad
            };

            mercaderiaDetalleList.Add(detalle);
        }

        var nuevaorden = new OrdenPreparacionEntidad
        {
            NroOrdenPrep = nroorden,
            CuitCliente = cuit,
            Estado = estado,
            Fecha = DateTime.Now,
            DNITransportista = dni,
            NroDeposito = DepositoArchivo.BuscarNroDeposito(nombredeposito),
            mercaderiaDetalle = mercaderiaDetalleList
        };

        OrdenPreparacionArchivo.AgregarOrdenPreparacion(nuevaorden);

        foreach (var item in nuevaorden.mercaderiaDetalle)
        {
            var stockItem = StockArchivo.Stocks.First(s => s.CodProducto == item.CodProducto
            && (s.Estado == EstadosStock.Ingresado || s.Estado == EstadosStock.Almacenado)
            && s.CuitCliente == nuevaorden.CuitCliente);
            if (stockItem.Cantidad == item.CantidadProducto)
            {
                StockArchivo.CambiarEstado(stockItem, EstadosStock.Comprometido);
            }
            else
            {
                int cantidadRetirada = item.CantidadProducto;
                // stockItem.Cantidad -= cantidadRetirada;
                StockArchivo.CambiarCantidad(stockItem, cantidadRetirada);

                var stockRetirado = new StockEntidad
                {
                    CuitCliente = stockItem.CuitCliente,
                    Posicion = stockItem.Posicion,
                    Cantidad = cantidadRetirada,
                    CodProducto = stockItem.CodProducto,
                    Estado = EstadosStock.Comprometido,
                    NroDeposito = stockItem.NroDeposito
                };

                // stock.Add(stockRetirado);
                StockArchivo.AgregarStock(stockRetirado);
            }
        }
        MessageBox.Show("La orden fue generada con éxito.");
    }
}
