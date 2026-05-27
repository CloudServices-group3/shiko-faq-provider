using Microsoft.EntityFrameworkCore;
using Shiko.FaqService.Models;

namespace Shiko.FaqService.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<FaqItem> FaqItems => Set<FaqItem>();
}