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
            ArchivoOrdenPreparacion.GrabarDatos();
            ArchivoOrdenSeleccion.GrabarDatos();
            ArchivoStock.GrabarDatos();
            ArchivoOrdenEntrega.GrabarDatos();
            ArchivoCliente.GrabarDatos();
            ArchivoContrato.GrabarDatos();
            ArchivoMercaderia.GrabarDatos();
            ArchivoRemito.GrabarDatos();

        }
    }
}