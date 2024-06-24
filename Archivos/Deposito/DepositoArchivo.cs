using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos.Deposito
{
    internal class DepositoArchivo
    {
        public static ReadOnlyCollection<DepositoEntidad> Depositos => depositos.AsReadOnly();

        private static List<DepositoEntidad> depositos;

        static DepositoArchivo()
        {
            try
            {
                if (File.Exists(@"Datos\Deposito.json"))
                {
                    var contenido = File.ReadAllText(@"Datos\Deposito.json");
                    depositos = JsonConvert.DeserializeObject<List<DepositoEntidad>>(contenido);
                }
                else
                {
                    depositos = new List<DepositoEntidad>();
                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción, por ejemplo, registrarla en un archivo de log
                Console.WriteLine($"Error al leer el archivo Deposito.json: {ex.Message}");
                depositos = new List<DepositoEntidad>();
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(depositos);
            File.WriteAllText(@"Datos\Deposito.json", contenido);
        }

        public static string BuscarNombreDeposito(int nroDeposito)
        {
            var deposito = Depositos.FirstOrDefault(d => d.NroDeposito == nroDeposito);
            if (deposito != null)
            {
                return deposito.NombreDeposito;
            }
            else
            {
                // Manejo del caso cuando el depósito no se encuentra
                return "Depósito no encontrado";
            }
        }

        public static int BuscarNroDeposito(string nombreDeposito)
        {
            var deposito = Depositos.FirstOrDefault(d => d.NombreDeposito == nombreDeposito);
            if (deposito != null)
            {
                return deposito.NroDeposito;
            }
            else
            {
                // Manejo del caso cuando el depósito no se encuentra
                return -1; // O algún otro valor que indique que no se encontró
            }
        }
    }
}
