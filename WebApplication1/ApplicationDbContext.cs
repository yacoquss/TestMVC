using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    {
        
    }
}