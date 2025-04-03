using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CaseManagmaentSystem.Models;

public partial class CaseManagementDbContext : DbContext
{
    public CaseManagementDbContext()
    {
    }

    public CaseManagementDbContext(DbContextOptions<CaseManagementDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Case> Cases { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=HANAN\\SQLEXPRESS;Database=CaseManagementDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Case>(entity =>
        {
            entity.HasKey(e => e.CaseId).HasName("PK__Cases__6CAE526C360B704D");

            entity.Property(e => e.CaseId).HasColumnName("CaseID");
            entity.Property(e => e.AssignedUserId).HasColumnName("AssignedUserID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Title).HasMaxLength(255);

            entity.HasOne(d => d.AssignedUser).WithMany(p => p.Cases)
                .HasForeignKey(d => d.AssignedUserId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__Cases__AssignedU__4E88ABD4");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.NotificationId).HasName("PK__Notifica__20CF2E327B1E5EAC");

            entity.Property(e => e.NotificationId).HasColumnName("NotificationID");
            entity.Property(e => e.CaseId).HasColumnName("CaseID");
            entity.Property(e => e.Message).HasMaxLength(500);
            entity.Property(e => e.SentAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Case).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.CaseId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Notificat__CaseI__52593CB8");

            entity.HasOne(d => d.User).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Notificat__UserI__534D60F1");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCACE4EA651B");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Role).HasMaxLength(20);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
