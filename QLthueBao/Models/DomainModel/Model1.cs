using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLthueBao.Models.DomainModel
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<GDGoiCuoc> GDGoiCuocs { get; set; }
        public virtual DbSet<GDNapDienThoai> GDNapDienThoais { get; set; }
        public virtual DbSet<GoiCuoc> GoiCuocs { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<LoaiGoiCuoc> LoaiGoiCuocs { get; set; }
        public virtual DbSet<NhaMang> NhaMangs { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<GoiCuoc>()
                .HasMany(e => e.GDGoiCuocs)
                .WithRequired(e => e.GoiCuoc)
                .HasForeignKey(e => e.Id_goi_cuoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GoiCuoc>()
                .HasMany(e => e.KhuyenMais)
                .WithOptional(e => e.GoiCuoc)
                .HasForeignKey(e => e.Id_goi_cuoc);

            modelBuilder.Entity<LoaiGoiCuoc>()
                .HasMany(e => e.GoiCuocs)
                .WithRequired(e => e.LoaiGoiCuoc)
                .HasForeignKey(e => e.Id_Loai_cuoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhaMang>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.NhaMang)
                .HasForeignKey(e => e.Id_nha_mang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Phone_number)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .HasMany(e => e.GDGoiCuocs)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.User_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.GDNapDienThoais)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.User_id)
                .WillCascadeOnDelete(false);
        }
    }
}
