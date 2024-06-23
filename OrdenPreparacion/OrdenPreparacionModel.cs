using GrupoA.Prototipo.Archivos;
using GrupoA.Prototipo.EmpaquetarMercaderia;
using GrupoA.Prototipo.RetiroStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.OrdenPreparacion;
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

    public List<Mercaderia> Mercaderias => MercaderiaArchivo.Mercaderias.Select(m => new Mercaderia
    {
        CodProducto = m.CodProducto,
        DescProducto = m.Descripcion
    }).ToList();

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
}
