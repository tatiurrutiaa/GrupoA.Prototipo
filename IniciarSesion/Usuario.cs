namespace GrupoA.Prototipo.IniciarSesion
{
    internal class Usuario
    {
        public Usuario()
        {
        }

        public string UsuarioIngreso { get; internal set; }
        public string Contraseña { get; internal set; }

        internal string Validar()
        {
            if (string.IsNullOrWhiteSpace(UsuarioIngreso))
            {
                return "Por favor, complete el campo Usuario.";
            }

            if (string.IsNullOrWhiteSpace(Contraseña))
            {
                return "Por favor, complete el campo Contraseña.";
            }

            if (UsuarioIngreso != "admin" & Contraseña != "admin")
            {
                return "El usuario y/o contraseña son incorrectos.";
            }

            return null;
        }
    }
}