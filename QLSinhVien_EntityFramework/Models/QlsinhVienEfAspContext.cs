using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QLSinhVien_DatabaseFirst.Models;

public partial class QlsinhVienEfAspContext : DbContext
{
    public QlsinhVienEfAspContext()
    {
    }

    public QlsinhVienEfAspContext(DbContextOptions<QlsinhVienEfAspContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Khoa> Khoas { get; set; }

    public virtual DbSet<Lop> Lops { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=MSI\\SQLEXPRESS;Initial Catalog=QLSinhVien_EF_ASP;User ID=sa;Password=10302003;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Khoa>(entity =>
        {
            entity.HasKey(e => e.MaKhoa).HasName("PK__Khoa__65390405D271A175");

            entity.ToTable("Khoa");

            entity.Property(e => e.MaKhoa).ValueGeneratedNever();
            entity.Property(e => e.TenKhoa).HasMaxLength(100);
        });

        modelBuilder.Entity<Lop>(entity =>
        {
            entity.HasKey(e => e.MaLop).HasName("PK__Lop__3B98D27337739EA5");

            entity.ToTable("Lop");

            entity.Property(e => e.MaLop)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Gvcn).HasMaxLength(100);

            entity.HasOne(d => d.MaKhoaNavigation).WithMany(p => p.Lops)
                .HasForeignKey(d => d.MaKhoa)
                .HasConstraintName("FK__Lop__MaKhoa__38996AB5");
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.MaSv).HasName("PK__SinhVien__2725081A8CDBC926");

            entity.ToTable("SinhVien");

            entity.Property(e => e.MaSv)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MaSV");
            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.Hoten).HasMaxLength(50);
            entity.Property(e => e.MaLop)
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.HasOne(d => d.MaLopNavigation).WithMany(p => p.SinhViens)
                .HasForeignKey(d => d.MaLop)
                .HasConstraintName("FK__SinhVien__MaLop__3B75D760");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
