namespace Wedding.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WeddingEntity : DbContext
    {
        public WeddingEntity()
            : base("name=WeddingEntity")
        {
        }

        public virtual DbSet<LeiBie> LeiBie { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<Prouduct> ShangPin { get; set; }
        public virtual DbSet<User> User { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<LeiBie>()
                .HasMany(e => e.ShangPin)
                .WithRequired(e => e.LeiBie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.ManrName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.ManPwd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.rEmail)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .HasMany(e => e.News)
                .WithRequired(e => e.Member)
                .HasForeignKey(e => e.ManID);

            modelBuilder.Entity<Order>()
                .Property(e => e.Total)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetail)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Prouduct>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Prouduct>()
                .HasMany(e => e.Cart)
                .WithRequired(e => e.ShangPin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prouduct>()
                .HasMany(e => e.OrderDetail)
                .WithRequired(e => e.ShangPin)
                .HasForeignKey(e => e.AlbumId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserPwd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
