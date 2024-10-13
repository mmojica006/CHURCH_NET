namespace CHURCH.Application.Dtos.Distritos.Response
{
    public class GetAllDistritosResponseDto
    {
        public int DistritoId { get; set; }
        public string? Nombre { get; set; }
        public bool Estado { get; set; }
        public string EstadoString { get; set; }
    }
}
