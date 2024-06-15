using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;
using Notify.Common.Infrastracture.Entitites;

namespace Notify.Common.Infrastracture
{
    public class SvcDbContext:DbContext
    {
        public SvcDbContext(DbContextOptions<SvcDbContext> dbContextOptions):base(dbContextOptions)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SmsTracker>().ToCollection("sms_tracker");
        }
    }
}
