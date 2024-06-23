using GrupoA.Prototipo.Forms.RetiroStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Forms.Login.Model
{
    internal class IniciarSesionModel
    {
        public List<Usuario> Usuario = new()
        {
            new() {UsuarioIngreso = "admin", Contraseña = "admin"},
            new() {UsuarioIngreso = "gestiondepositos", Contraseña = "gestiondepositos"},
            new() {UsuarioIngreso = "preparacion", Contraseña = "preparacion"},
            new() {UsuarioIngreso = "almacen", Contraseña = "almacen"},
            new() {UsuarioIngreso = "despacho", Contraseña = "despacho"}
        };

        public string ValidarUsuario(string usuarioIngreso, string contraseña)
        {
            if (string.IsNullOrEmpty(usuarioIngreso))
            {
                return "Por favor, complete el campo Usuario";
            }

            if (string.IsNullOrEmpty(contraseña))
            {
                return "Por favor, complete el campo Contraseña.";
            }

            foreach (var usuario in Usuario)
            {
                if (usuario.UsuarioIngreso == usuarioIngreso && usuario.Contraseña == contraseña)
                {
                    return null;
                }
            }
            return "Acceso denegado. Usuario o contraseña incorrectos.";
        }
    }
}
