namespace ClasesPropiedades.Core
{
    public class Alumno
    {
        private string nombre;
        private string club;
        private int dni;

        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string unNombre)
        {
            nombre = unNombre;
        }
        public string GetClub()
        {
            return club;
        }
        public void SetClub(string unClub)
        {
            club = unClub;
        }
        public int GetDni()
        {
            return dni;
        }
        public void SetDni(int unDni)
        {
            dni = unDni;
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