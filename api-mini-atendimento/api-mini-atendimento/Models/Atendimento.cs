namespace api_mini_atendimento.Models;

public class Atendimento
{
    public int Id { get; set; }
    public string Canal { get; set; } = string.Empty;
    public string Mensagem { get; set; } = string.Empty;
    public DateTime Data { get; set; }
    public required Cliente ClienteId { get; set; }
    public required Cliente Cliente { get; set; }
}
