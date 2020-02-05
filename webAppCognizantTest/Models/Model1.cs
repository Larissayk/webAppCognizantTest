namespace webAppCognizantTest.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class myLocalDBLYKEntities : DbContext
    {
        public myLocalDBLYKEntities()
            : base("name=myLocalDBLYKEntities")
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.email)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.phone)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.address)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.neighborhood)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.city)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.state)
                .IsFixedLength();
        }
    }
}
