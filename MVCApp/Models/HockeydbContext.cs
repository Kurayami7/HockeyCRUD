using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MVCApp.Models;

public partial class HockeydbContext : DbContext
{
    public HockeydbContext()
    {
    }

    public HockeydbContext(DbContextOptions<HockeydbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Player> Players { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=127.0.0.1;port=3307;uid=root;database=hockeydb");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Player>(entity =>
        {
            entity.HasKey(e => e.PlayerId).HasName("PRIMARY");

            entity.ToTable("players");

            entity.Property(e => e.PlayerId)
                .HasColumnType("int(11)")
                .HasColumnName("player_id");
            entity.Property(e => e.Dob)
                .HasColumnType("date")
                .HasColumnName("dob");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(255)
                .HasColumnName("image_url");
            entity.Property(e => e.JerseyNumber)
                .HasColumnType("int(11)")
                .HasColumnName("jersey_number");
            entity.Property(e => e.Matches)
                .HasColumnType("int(11)")
                .HasColumnName("matches");
            entity.Property(e => e.PlayerName)
                .HasMaxLength(255)
                .HasColumnName("player_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
