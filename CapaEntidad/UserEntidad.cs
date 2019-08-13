namespace CapaEntidad
{
    public class UserEntidad
    {
        private string user_nick, user_clave, user_nombre, user_apellido, user_obser;

        public string tbusuario
        {
            get { return user_nick; }
            set { user_nick = value; }
        }

        public string tbclave
        {
            get { return user_clave; }
            set { user_clave = value; }
        }

        public string tbnombre
        {
            get { return user_nombre; }
            set { user_nombre = value; }
        }
        public string tbapellido
        {
            get { return user_apellido; }
            set { user_apellido = value; }
        }
        public string tbobserva
        {
            get { return user_obser; }
            set { user_obser = value; }
        }

    }
}
