using Microsoft.EntityFrameworkCore;
using MyOnlineScheduler_API.Activity.Domain.Models;

namespace MyOnlineScheduler_API.Activity.Data.Context
{
    public class ActivityDbContext : DbContext
    {
        protected ActivityDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ActivityItem> Activities { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}