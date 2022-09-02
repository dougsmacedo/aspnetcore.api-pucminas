using Microsoft.EntityFrameworkCore;

namespace aspnetcore.api_pucminas.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)   
        {
        }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Consumo> Consumos{ get; set; }
    }
}
