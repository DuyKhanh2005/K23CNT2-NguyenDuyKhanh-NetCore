using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NdkLesson10.Models;

public partial class NdkK23cnt2lesson10DbContext : DbContext
{
    public NdkK23cnt2lesson10DbContext()
    {
    }

    public NdkK23cnt2lesson10DbContext(DbContextOptions<NdkK23cnt2lesson10DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DUYKHANH2005\\MAY1;Database=NdkK23CNT2Lesson10Db;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity => 
        {
            entity
                .HasNoKey()
                .ToTable("Category");

            entity.Property(e => e.CateId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CateID");
            entity.Property(e => e.CateName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
