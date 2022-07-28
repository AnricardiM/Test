namespace MicroServicios.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<testAuto> testAuto { get; set; }
        public virtual DbSet<testCentro> testCentro { get; set; }
        public virtual DbSet<testVenta> testVenta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<testAuto>()
                .Property(e => e.descripcionAuto)
                .IsUnicode(false);

            modelBuilder.Entity<testCentro>()
                .Property(e => e.descripcionCentro)
                .IsUnicode(false);

            modelBuilder.Entity<testVenta>()
                .Property(e => e.descripcionVenta)
                .IsUnicode(false);
        }
    }
}
