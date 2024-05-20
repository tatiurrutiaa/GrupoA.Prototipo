using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.IniciarSesion
{
    internal class IniciarSesionModel
    {
        internal string Validar(Usuario usuario)
        {
            string error = usuario.Validar();
            if (error != null)
            {
                return error;
            }
            //otras validaciones
            return null;
        }
    }
}
