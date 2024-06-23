using GrupoA.Prototipo.Archivos;
using GrupoA.Prototipo.Archivos.Cliente;
using GrupoA.Prototipo.Archivos.Contrato;
using GrupoA.Prototipo.Archivos.Deposito;
using GrupoA.Prototipo.Archivos.Mercaderias;
using GrupoA.Prototipo.Archivos.Ordenes.OrdenEntrega;
using GrupoA.Prototipo.Archivos.Ordenes.OrdenSeleccion;
using GrupoA.Prototipo.Archivos.Stock;

namespace GrupoA.Prototipo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new IniciarSesionForms());
            ClienteArchivo.GrabarDatos();
            ContratoArchivo.GrabarDatos();
            DepositoArchivo.GrabarDatos();
            MercaderiaArchivo.GrabarDatos();
            OrdenEntregaArchivo.GrabarDatos();
            OrdenPreparacionArchivo.GrabarDatos();
            OrdenSeleccionArchivo.GrabarDatos();
            RemitoArchivo.GrabarDatos();
            StockArchivo.GrabarDatos();
        }
    }
}