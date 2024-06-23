using GrupoA.Prototipo.Archivos;

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
            MercaderiaArchivo.GrabarDatos();
            OrdenEntregaArchivo.GrabarDatos();
            OrdenPreparacionArchivo.GrabarDatos();
            OrdenSeleccionArchivo.GrabarDatos();
            RemitoArchivo.GrabarDatos();
            StockArchivo.GrabarDatos();
        }
    }
}