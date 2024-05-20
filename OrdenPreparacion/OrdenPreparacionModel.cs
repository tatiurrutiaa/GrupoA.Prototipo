using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.OrdenPreparacion;
internal class OrdenPreparacionModel
{
    public List<Cliente> Clientes = new()
    {
        new() { Cuit = "20-12345678-9", RazonSocial = "Empresa A" },
        new() { Cuit = "30-87654321-0", RazonSocial = "Empresa B" },
        new() { Cuit = "27-12345678-9", RazonSocial = "Empresa C" },
        new() { Cuit = "30-87654321-0", RazonSocial = "Empresa D" },
        new() { Cuit = "20-12345678-9", RazonSocial = "Empresa E" },
        new() { Cuit = "27-12345678-9", RazonSocial = "Empresa F" },
        new() { Cuit = "30-87654321-0", RazonSocial = "Empresa G" },
        new() { Cuit = "20-12345678-9", RazonSocial = "Empresa H" },
        new() { Cuit = "27-12345678-0", RazonSocial = "Empresa I" }
    };

    public Cliente BuscarCliente(string cuit)
    {
        foreach(Cliente cliente in Clientes)
        {
            if (cliente.Cuit == cuit)
            {
                return cliente;
            }
        }
        return null;
    }
}

