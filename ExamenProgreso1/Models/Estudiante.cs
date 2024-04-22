namespace ExamenProgreso1.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string? Nombre {  get; set; }
        public int NumeroTelefono { get; set; }
        public decimal Sueldo { get; set; }
        public Boolean EsMayorDeEdad {  get; set; }
        public DateTime? FechaNacimiento { get; set; }


        public Carrera carrera { get; set; }
    }
}
