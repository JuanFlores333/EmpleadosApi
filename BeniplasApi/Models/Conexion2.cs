using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BeniplasApi.Models
{
    public partial class Conexion2 : DbContext
    {
        public Conexion2()
            : base("name=Conexion2")
        {
        }

        public virtual DbSet<Administradors> Administradors { get; set; }
        public virtual DbSet<Empleadoes> Empleadoes { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<Gerentes> Gerentes { get; set; }
        public virtual DbSet<RegistroAperturaAdministradors> RegistroAperturaAdministradors { get; set; }
        public virtual DbSet<RegistroAperturaEmpleadoes> RegistroAperturaEmpleadoes { get; set; }
        public virtual DbSet<RegistroAperturaGerentes> RegistroAperturaGerentes { get; set; }
        public virtual DbSet<Sucursals> Sucursals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administradors>()
                .HasMany(e => e.RegistroAperturaAdministradors)
                .WithOptional(e => e.Administradors)
                .HasForeignKey(e => e.Administrador_ID);

            modelBuilder.Entity<Empleadoes>()
                .HasMany(e => e.RegistroAperturaEmpleadoes)
                .WithOptional(e => e.Empleadoes)
                .HasForeignKey(e => e.Empleado_ID);

            modelBuilder.Entity<Empresas>()
                .HasMany(e => e.Gerentes)
                .WithOptional(e => e.Empresas)
                .HasForeignKey(e => e.Empresa_ID);

            modelBuilder.Entity<Empresas>()
                .HasMany(e => e.Sucursals)
                .WithOptional(e => e.Empresas)
                .HasForeignKey(e => e.Empresa_ID);

            modelBuilder.Entity<Gerentes>()
                .HasMany(e => e.RegistroAperturaGerentes)
                .WithOptional(e => e.Gerentes)
                .HasForeignKey(e => e.Gerente_ID);

            modelBuilder.Entity<Gerentes>()
                .HasMany(e => e.Sucursals)
                .WithOptional(e => e.Gerentes)
                .HasForeignKey(e => e.Gerente_ID);

            modelBuilder.Entity<Sucursals>()
                .HasMany(e => e.Empleadoes)
                .WithOptional(e => e.Sucursals)
                .HasForeignKey(e => e.Sucursal_ID);
        }
    }
}
