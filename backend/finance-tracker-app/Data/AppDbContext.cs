using Microsoft.EntityFrameworkCore;

namespace finance_tracker_app.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Entities.Category> Categories { get; set; }
        public DbSet<Entities.RecurringTransaction> RecurringTransactions { get; set; }
        public DbSet<Entities.RecurringTransactionAttachment> RecurringTransactionAttachments { get; set; }
        public DbSet<Entities.Transaction> Transactions { get; set; }
        public DbSet<Entities.TransactionAttachment> TransactionAttachments { get; set; }
        public DbSet<Entities.User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Entities.RecurringTransaction>()
                .Property(Rt => Rt.Amount)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Entities.RecurringTransaction>()
                .HasOne(Rt => Rt.Category)
                .WithMany(C => C.RecurringTransactions)
                .HasForeignKey(Rt => Rt.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Entities.RecurringTransaction>()
                .HasOne(Rt => Rt.User)
                .WithMany(U => U.RecurringTransactions)
                .HasForeignKey(Rt => Rt.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Entities.RecurringTransactionAttachment>()
                .HasOne(Rta => Rta.RecurringTransaction)
                .WithMany(Rt => Rt.Attachments)
                .HasForeignKey(Rta => Rta.RecurringTransactionId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Entities.Transaction>()
                .Property(T => T.Amount)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Entities.Transaction>()
                .HasOne(T => T.Category)
                .WithMany(C => C.Transactions)
                .HasForeignKey(T => T.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Entities.Transaction>()
                .HasOne(T => T.User)
                .WithMany(U => U.Transactions)
                .HasForeignKey(T => T.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Entities.TransactionAttachment>()
                .HasOne(Ta => Ta.Transaction)
                .WithMany(T => T.Attachments)
                .HasForeignKey(Ta => Ta.TransactionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
