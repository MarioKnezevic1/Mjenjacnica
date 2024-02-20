using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Mjenjačnica.Models;
namespace Mjenjačnica.Data
{
    public class MjContext : DbContext
    {
        public MjContext(DbContextOptions<MjContext> options)
            :base(options)
        {
        }
        public DbSet<Mjenjačnica.Models.Model> Tecaj { get; set; } = default!;
        public DbSet<Mjenjačnica.Models.Evidencija> Evidencija { get; set; } = default!;
    }
}
