namespace DAL
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public partial class GCdb : DbContext
    {
        public GCdb()
            : base("GCdb")
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<DeviceType> DeviceType { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderType> OrderType { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<StatusType> StatusType { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DeviceType>()
                .HasMany(e => e.Device)
                .WithRequired(e => e.DeviceType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderType>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.OrderType)
                .WillCascadeOnDelete(false);
        }
    }
}