namespace api_mini_atendimento.Models;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;

    // Relação 1:N → Cliente pode ter vários atendimentos
    public ICollection<Atendimento> Atendimentos { get; set; } = new List<Atendimento>();
}