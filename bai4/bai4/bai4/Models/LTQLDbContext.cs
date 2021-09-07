using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace bai4.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<MatHang> MatHangs { get; set; }
        public virtual DbSet<NhapHang> NhapHangs { get; set; }
        public virtual DbSet<ChiTietNhap> ChiTietNhaps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.TenTK)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDons)
                .WithOptional(e => e.KhachHang)
                .WillCascadeOnDelete();

            modelBuilder.Entity<MatHang>()
                .Property(e => e.MaMH)
                .IsUnicode(false);

            modelBuilder.Entity<NhapHang>()
                .Property(e => e.MaN)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietNhap>()
                .Property(e => e.MaN)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietNhap>()
                .Property(e => e.MaMH)
                .IsUnicode(false);
        }
    }
}
