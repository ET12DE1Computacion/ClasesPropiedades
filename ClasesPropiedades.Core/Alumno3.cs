namespace ClasesPropiedades.Core
{
    public class Alumno3
    {
        public string Nombre { get; set; }
        public string Club { get; set; }
        public int Dni { get; set; }
        public string Saludar()
        {
            return $"Hola, soy {Nombre}";
        }
        public bool SosDe(string unClub)
        {
            return Club == unClub;
        }
    }
}