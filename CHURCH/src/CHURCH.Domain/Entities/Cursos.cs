namespace CHURCH.Domain.Entities
{
    public class Cursos
    {
        public int CursoId { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int IglesiaId { get; set; }
    }

}
