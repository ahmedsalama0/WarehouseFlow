using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseFlow
{
    public class AppDbContext : DbContext
    {
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemUnit> ItemUnits { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<SupplyPermit> SupplyPermits { get; set; }
        public DbSet<SuppliedItem> SuppliedItems { get; set; }
        public DbSet<ReleaseOrder> ReleaseOrders { get; set; }
        public DbSet<ReleasedItem> ReleasedItems { get; set; }
        public DbSet<WarehouseItem> WarehouseItems { get; set; }
        public DbSet<TransferredItem> TransferredItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source = .\\SQLEXPRESS ; initial catalog = test_project ; integrated security = true ; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransferredItem>()
                .HasOne(t => t.FromWarehouse)
                .WithMany(w => w.TransferredItemsFromWarehouse)
                .HasForeignKey(t => t.FromWarehouseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TransferredItem>()
                .HasOne(t => t.ToWarehouse)
                .WithMany(w => w.TransferredItemsToWarehouse)
                .HasForeignKey(t => t.ToWarehouseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SuppliedItem>()
                .HasOne(s => s.Permit)
                .WithMany(p => p.SuppliedItems)
                .HasForeignKey(s => s.PermitId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SuppliedItem>()
                .HasOne(s => s.Item)
                .WithMany(i => i.SuppliedItems)
                .HasForeignKey(s => s.ItemId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SuppliedItem>()
                .HasOne(s => s.Warehouse)
                .WithMany(w => w.SuppliedItems)
                .HasForeignKey(s => s.WarehouseId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ReleasedItem>()
                .HasOne(r => r.Permit)
                .WithMany(p => p.ReleasedItems)
                .HasForeignKey(r => r.PermitId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ReleasedItem>()
                .HasOne(r => r.Item)
                .WithMany(i => i.ReleasedItems)
                .HasForeignKey(r => r.ItemId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ReleasedItem>()
                .HasOne(r => r.Warehouse)
                .WithMany(w => w.ReleasedItems)
                .HasForeignKey(r => r.WarehouseId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SupplyPermit>()
                .HasOne(p => p.Supplier)
                .WithMany(s => s.SupplyPermits)
                .HasForeignKey(p => p.SupplierId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ReleaseOrder>()
                .HasOne(o => o.Supplier)
                .WithMany(c => c.ReleaseOrders)
                .HasForeignKey(o => o.SupplierId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<WarehouseItem>()
                .HasOne(wi => wi.Warehouse)
                .WithMany(w => w.WarehouseItems)
                .HasForeignKey(wi => wi.WarehouseId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<WarehouseItem>()
                .HasOne(wi => wi.Item)
                .WithMany(i => i.WarehouseItems)
                .HasForeignKey(wi => wi.ItemId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<WarehouseItem>()
                .HasOne(wi => wi.Supplier)
                .WithMany(s => s.WarehouseItems)
                .HasForeignKey(wi => wi.SupplierId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
