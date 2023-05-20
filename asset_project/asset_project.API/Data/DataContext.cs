using asset_project.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace asset_project.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Asset> Assets { get; set; }

        public DbSet<AssetDetail> Assetdetails { get; set; }

        public DbSet<AssetType> AssetTypes { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<IdentificationType> IdentificationTypes { get; set; }

        public DbSet<MaintenanceRequest> MaintenanceRequests { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<NotificationType> NotificationTypes { get; set; }

        public DbSet<Person> People { get; set; }

        public DbSet<Property> Properties { get; set; }

        public DbSet<Schedule> Schedules { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<StatusType> StatusTypes { get; set; }

        public DbSet<WorkOrder> WorkOrders { get; set; }

        public DbSet<WorkOrderDetail> WorkOrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Asset>().HasIndex(a => a.Code);
            modelBuilder.Entity<Asset>().HasIndex(a => a.Code);
            modelBuilder.Entity<AssetType>().HasIndex(t => t.Name);
            modelBuilder.Entity<Category>().HasIndex(c => c.Name);
            modelBuilder.Entity<City>().HasIndex(c => c.Name);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name);
            modelBuilder.Entity<IdentificationType>().HasIndex(i => i.Id);
            modelBuilder.Entity<MaintenanceRequest>().HasIndex(m => new { m.Id, m.RegisterDate });
            modelBuilder.Entity<Notification>().HasIndex(n => n.Id);
            modelBuilder.Entity<NotificationType>().HasIndex(t => t.name);
            modelBuilder.Entity<Person>().HasIndex(p => new { p.FirstName, p.LastName });
            modelBuilder.Entity<Property>().HasIndex(p => p.Name);
            modelBuilder.Entity<Schedule>().HasIndex(s => s.Id);
            modelBuilder.Entity<State>().HasIndex(s => s.Name);
            modelBuilder.Entity<StatusType>().HasIndex(s => s.Name);
            modelBuilder.Entity<WorkOrder>().HasIndex(w => new { w.AssignmentDateTime, w.Id });
            modelBuilder.Entity<WorkOrderDetail>().HasIndex(wd => wd.WordOrderId);

        }
    }
}
