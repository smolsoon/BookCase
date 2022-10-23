using BookCase.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BookCase.Infrastructure.Database;

public class BookCaseContext : DbContext
{
    private readonly IConfiguration _configuration;
    public BookCaseContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(_configuration.GetConnectionString("Bookcase"));
}