namespace Entity.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QL_TourDuLichDBContext : DbContext
    {
        public QL_TourDuLichDBContext()
            : base("name=QL_TourDuLichDBContext")
        {
        }

        public virtual DbSet<DiaDiemDL> DiaDiemDL { get; set; }
        public virtual DbSet<Doan_ChiPhiKhac> Doan_ChiPhiKhac { get; set; }
        public virtual DbSet<Doan_KhachSan> Doan_KhachSan { get; set; }
        public virtual DbSet<Doan_PhuongTien> Doan_PhuongTien { get; set; }
        public virtual DbSet<Doan_QuanAn> Doan_QuanAn { get; set; }
        public virtual DbSet<DoanDL> DoanDL { get; set; }
        public virtual DbSet<DoanDL_KhachHang> DoanDL_KhachHang { get; set; }
        public virtual DbSet<DoanDL_NhanVien> DoanDL_NhanVien { get; set; }
        public virtual DbSet<Gia_Tour> Gia_Tour { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<LoaiHinhDL> LoaiHinhDL { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<NhiemVu> NhiemVu { get; set; }
        public virtual DbSet<TinhThanh> TinhThanh { get; set; }
        public virtual DbSet<Tour> Tour { get; set; }
        public virtual DbSet<Tour_DiaDiemDL> Tour_DiaDiemDL { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiaDiemDL>()
                .HasMany(e => e.Doan_KhachSan)
                .WithRequired(e => e.DiaDiemDL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DiaDiemDL>()
                .HasMany(e => e.Doan_QuanAn)
                .WithRequired(e => e.DiaDiemDL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DiaDiemDL>()
                .HasMany(e => e.Tour_DiaDiemDL)
                .WithRequired(e => e.DiaDiemDL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DoanDL>()
                .HasMany(e => e.Doan_KhachSan)
                .WithRequired(e => e.DoanDL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DoanDL>()
                .HasMany(e => e.Doan_PhuongTien)
                .WithRequired(e => e.DoanDL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DoanDL>()
                .HasMany(e => e.Doan_QuanAn)
                .WithRequired(e => e.DoanDL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DoanDL>()
                .HasMany(e => e.DoanDL_KhachHang)
                .WithRequired(e => e.DoanDL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DoanDL>()
                .HasMany(e => e.DoanDL_NhanVien)
                .WithRequired(e => e.DoanDL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SoDT)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Passport)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.DoanDL_KhachHang)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiHinhDL>()
                .HasMany(e => e.Tour)
                .WithOptional(e => e.LoaiHinhDL1)
                .HasForeignKey(e => e.LoaiHinhDL);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SoDT)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.DoanDL_NhanVien)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhiemVu>()
                .HasMany(e => e.DoanDL_NhanVien)
                .WithRequired(e => e.NhiemVu)
                .HasForeignKey(e => e.MaNhiemVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TinhThanh>()
                .HasMany(e => e.DiaDiemDL)
                .WithOptional(e => e.TinhThanh1)
                .HasForeignKey(e => e.TinhThanh);

            modelBuilder.Entity<Tour>()
                .HasMany(e => e.Gia_Tour)
                .WithRequired(e => e.Tour)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tour>()
                .HasMany(e => e.Tour_DiaDiemDL)
                .WithRequired(e => e.Tour)
                .WillCascadeOnDelete(false);
        }
    }
}
