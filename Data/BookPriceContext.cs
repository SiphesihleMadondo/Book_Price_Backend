using System;
using System.Collections.Generic;
using Book_Price_Backend.Models;

//using Book_Price_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_Price_Backend.Data;

public partial class BookPriceContext : DbContext
{
    public BookPriceContext()
    {
    }

    public BookPriceContext(DbContextOptions<BookPriceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BookPrice> BookPrices { get; set; }

    public virtual DbSet<Partner> Partners { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookPrice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Book_Price");

            entity.Property(e => e.AdjustedAssetValue)
                .HasColumnType("decimal(29, 3)")
                .HasColumnName("Adjusted Asset Value");
            entity.Property(e => e.AdjustedRevenue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Adjusted Revenue");
            entity.Property(e => e.BookPrice1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Book Price");
            entity.Property(e => e.ClientName)
                .HasMaxLength(50)
                .HasColumnName("Client Name");
            entity.Property(e => e.Partner).HasMaxLength(50);
            entity.Property(e => e.Policynumber)
                .HasMaxLength(100)
                .HasColumnName("POLICYNUMBER");
            entity.Property(e => e.ProductProvider)
                .HasMaxLength(70)
                .HasColumnName("Product Provider");
            entity.Property(e => e.StatementDate).HasColumnName("Statement Date");
        });

        modelBuilder.Entity<Partner>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("partners");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
