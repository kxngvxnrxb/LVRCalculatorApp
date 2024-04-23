using LVRCalculatorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LVRCalculatorApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserToken> UserTokens { get; set; }
    }
}
