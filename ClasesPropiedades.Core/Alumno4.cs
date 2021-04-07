namespace ClasesPropiedades.Core
{
    public class Alumno4
    {
        public string Nombre { get; set; }
        public string Club { get; set; }
        public int Dni { get; set; }
        public string Saludar() => $"Hola, soy {Nombre}";
        public bool SosDe(string unClub) => Club == unClub;
    }
}