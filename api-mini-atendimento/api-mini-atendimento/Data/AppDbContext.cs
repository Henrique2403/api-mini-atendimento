using api_mini_atendimento.Models;
using Microsoft.EntityFrameworkCore;

namespace api_mini_atendimento.Data;

public class AppDbContext : DbContext
{
    DbSet<Cliente> cliente;
    DbSet<Atendimento> atendimento;
}
