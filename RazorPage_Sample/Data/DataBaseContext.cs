using Microsoft.EntityFrameworkCore;
using RazorPage_Sample.Models;

namespace RazorPage_Sample.Data;

public class DataBaseContext : DbContext
{
    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
    {

    }

    public DbSet<Product> Products { get; set; }
}