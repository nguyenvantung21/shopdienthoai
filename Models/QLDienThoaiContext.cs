using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ShopPhone.Models
{
    public partial class QLDienThoaiContext : DbContext
    {
        public QLDienThoaiContext()
        {
        }

        public QLDienThoaiContext(DbContextOptions<QLDienThoaiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chitietdonhang> Chitietdonhangs { get; set; }
        public virtual DbSet<Danhmucsp> Danhmucsps { get; set; }
        public virtual DbSet<Donhang> Donhangs { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<Sanpham> Sanphams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-Q9Q66U0M\\SQLEXPRESS01;Initial Catalog=QLDienThoai;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Chitietdonhang>(entity =>
            {
                entity.HasKey(e => new { e.MaSanPham, e.MaDon })
                    .HasName("PK__CHITIETD__691FDB7B402E884C");

                entity.ToTable("CHITIETDONHANG");

                entity.Property(e => e.MaSanPham).HasMaxLength(50);

                entity.Property(e => e.MaDon).HasMaxLength(50);

                entity.Property(e => e.DonGia).HasColumnType("money");

                entity.HasOne(d => d.MaDonNavigation)
                    .WithMany(p => p.Chitietdonhangs)
                    .HasForeignKey(d => d.MaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHITIETDO__MaDon__300424B4");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.Chitietdonhangs)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHITIETDO__MaSan__2F10007B");
            });

            modelBuilder.Entity<Danhmucsp>(entity =>
            {
                entity.HasKey(e => e.MaDanhMuc)
                    .HasName("PK__DANHMUCS__B3750887C94964C1");

                entity.ToTable("DANHMUCSP");

                entity.Property(e => e.MaDanhMuc).HasMaxLength(50);

                entity.Property(e => e.TenDanhMuc)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Donhang>(entity =>
            {
                entity.HasKey(e => e.MaDon)
                    .HasName("PK__DONHANG__3D89F56868C523EC");

                entity.ToTable("DONHANG");

                entity.Property(e => e.MaDon).HasMaxLength(50);

                entity.Property(e => e.MaKhachHang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaNv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MaNV");

                entity.Property(e => e.NgayDat).HasColumnType("date");

                entity.Property(e => e.TinhTrang).HasMaxLength(50);

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.Donhangs)
                    .HasForeignKey(d => d.MaKhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DONHANG__MaKhach__30F848ED");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.Donhangs)
                    .HasForeignKey(d => d.MaNv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DONHANG__MaNV__31EC6D26");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => e.MaKhachHang)
                    .HasName("PK__KHACHHAN__88D2F0E5E1E06D68");

                entity.ToTable("KHACHHANG");

                entity.Property(e => e.MaKhachHang).HasMaxLength(50);

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.MatKhau).HasMaxLength(50);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(50)
                    .HasColumnName("SDT");

                entity.Property(e => e.TaiKhoanKh)
                    .HasMaxLength(50)
                    .HasColumnName("TaiKhoanKH");

                entity.Property(e => e.TenKhachHang).HasMaxLength(50);
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.MaNv)
                    .HasName("PK__NHANVIEN__2725D70A880C5641");

                entity.ToTable("NHANVIEN");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(50)
                    .HasColumnName("MaNV");

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.MatKhau).HasMaxLength(50);

                entity.Property(e => e.NgaySinh).HasMaxLength(50);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(50)
                    .HasColumnName("SDT");

                entity.Property(e => e.TaiKhoanNv)
                    .HasMaxLength(50)
                    .HasColumnName("TaiKhoanNV");

                entity.Property(e => e.TenNv)
                    .HasMaxLength(50)
                    .HasColumnName("TenNV");
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.MaSanPham)
                    .HasName("PK__SANPHAM__FAC7442D11F86EF2");

                entity.ToTable("SANPHAM");

                entity.Property(e => e.MaSanPham).HasMaxLength(50);

                entity.Property(e => e.Anh).HasMaxLength(50);

                entity.Property(e => e.GiaTien).HasColumnType("money");

                entity.Property(e => e.MaDanhMuc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MoTa).HasMaxLength(50);

                entity.Property(e => e.TenSanPham).HasMaxLength(50);

                entity.HasOne(d => d.MaDanhMucNavigation)
                    .WithMany(p => p.Sanphams)
                    .HasForeignKey(d => d.MaDanhMuc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAM__MaDanhM__2E1BDC42");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
