﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TorrentMvcProject.Domain;

namespace TorrentMvcProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230218200838__end")]
    partial class _end
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TorrentMvcProject.Domain.Entity.Catagory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("TorrentMvcProject.Domain.Entity.Comments", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DataPost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("GameName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("TorrentMvcProject.Domain.Entity.GameItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RAM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReleaseDate")
                        .HasColumnType("int");

                    b.Property<string>("Windows")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("developer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("dizlike")
                        .HasColumnType("int");

                    b.Property<string>("img1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("languages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("like")
                        .HasColumnType("int");

                    b.Property<string>("mainImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("teg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("version")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("videoCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("weight")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("GameItems");
                });
#pragma warning restore 612, 618
        }
    }
}
