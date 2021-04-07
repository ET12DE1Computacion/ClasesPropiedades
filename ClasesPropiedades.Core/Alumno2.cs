namespace ClasesPropiedades.Core
{
    public class Alumno2
    {
        private string nombre;
        private string club;
        private int dni;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Club
        {
            get { return club; }
            set { club = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Saludar()
        {
            return $"Hola, soy {nombre}";
        }
        public bool SosDe(string unClub)
        {
            return club == unClub;
        }
    }
}