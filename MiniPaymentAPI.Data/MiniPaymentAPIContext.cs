using Microsoft.EntityFrameworkCore;
using MiniPaymentAPI.Data.Entities;

namespace MiniPaymentAPI.Data
{
    public class MiniPaymentAPIContext : DbContext
    {
        public MiniPaymentAPIContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionDetail> TransactionsDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Transaction>(e =>
            {
                e.HasKey(e => e.Id);

            });


            modelBuilder.Entity<TransactionDetail>(e =>
            {
                e.HasKey(e => e.Id);

                e.HasOne(e => e.Transaction)
                .WithMany(e => e.TransactionDetails)
                .HasForeignKey(e => e.TransactionId);
            });
        }
    }
}