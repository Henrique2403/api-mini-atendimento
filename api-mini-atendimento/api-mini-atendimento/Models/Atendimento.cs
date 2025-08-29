namespace api_mini_atendimento.Models;

 public class Atendimento
{
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public bool Finalizado { get; set; } = false;
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
}
