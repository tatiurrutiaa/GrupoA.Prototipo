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
    public List<Cliente> Clientes = new()
    {
        new() { Cuit = "20-12345678-9", RazonSocial = "Empresa A" },
        new() { Cuit = "33-87654321-0", RazonSocial = "Empresa B" },
        new() { Cuit = "27-12345678-9", RazonSocial = "Empresa C" },
        new() { Cuit = "30-87654321-0", RazonSocial = "Empresa D" },
        new() { Cuit = "22-12345678-9", RazonSocial = "Empresa E" },
        new() { Cuit = "27-12345678-5", RazonSocial = "Empresa F" },
        new() { Cuit = "32-87654321-5", RazonSocial = "Empresa G" },
        new() { Cuit = "24-12345678-9", RazonSocial = "Empresa H" },
        new() { Cuit = "27-12345678-0", RazonSocial = "Empresa I" }
    };

    public List<Deposito> Depositos = new()
    {
        new Deposito { NroDeposito = 1 , NombreDeposito = "Almacén Central"},
        new Deposito { NroDeposito = 2 , NombreDeposito = "Depósito Norte"},
        new Deposito { NroDeposito = 3 , NombreDeposito = "Centro de Distribución Sur"},

    };

    /*public List<MercaderiasDetalle> Mercaderias = new (){
         new MercaderiasDetalle { IdProducto = "A001", Mercaderia = "bolsas de cemento", CantidadProducto = 700,   NumDeposito = 1},
         new MercaderiasDetalle { IdProducto = "A002", Mercaderia = "ladrillos",         CantidadProducto = 500,   NumDeposito = 1},
         new MercaderiasDetalle { IdProducto = "A003", Mercaderia = "cemento cola",      CantidadProducto = 300,   NumDeposito = 1},
         new MercaderiasDetalle { IdProducto = "A004", Mercaderia = "bolsas de arena",   CantidadProducto = 1000,  NumDeposito = 2},
         new MercaderiasDetalle { IdProducto = "A005", Mercaderia = "bolsas de cal",     CantidadProducto = 800,   NumDeposito = 2},
         new MercaderiasDetalle { IdProducto = "A006", Mercaderia = "vigas de madera",   CantidadProducto = 200,   NumDeposito = 3},
         new MercaderiasDetalle { IdProducto = "A007", Mercaderia = "tejas",             CantidadProducto = 400,   NumDeposito = 3 },
         new MercaderiasDetalle { IdProducto = "A008", Mercaderia = "cable eléctrico",   CantidadProducto = 600,   NumDeposito = 3 },
         new MercaderiasDetalle { IdProducto = "A009", Mercaderia = "tubos de PVC",      CantidadProducto = 300,   NumDeposito = 3 }
    };*/

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

/*private void CargarDepositosEnComboBox()
{
    comboBoxDepositos.Items.Clear();

    // Agregar los nombres de los depósitos al ComboBox
    foreach (var deposito in depositos)
    {
        comboBoxDepositos.Items.Add(deposito);
    }
}*/
