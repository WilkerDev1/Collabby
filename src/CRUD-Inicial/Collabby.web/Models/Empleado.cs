namespace Collabby.web.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public int NombreCompleto { get; set; }
        public int Correo { get; set; }
        public DateOnly FechaContrato { get; set; }
        public bool Activo { get; set; }


    }
}
