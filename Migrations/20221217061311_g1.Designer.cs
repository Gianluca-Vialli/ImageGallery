﻿// <auto-generated />
using ImageGallery.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ImageGallery.Migrations
{
    [DbContext(typeof(GalleryContext))]
    [Migration("20221217061311_g1")]
    partial class g1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ImageGallery.Models.Gallery", b =>
                {
                    b.Property<int>("IdGallery")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("IdGallery");

                    b.ToTable("Galeria");
                });

            modelBuilder.Entity("ImageGallery.Models.Image", b =>
                {
                    b.Property<int>("IdImage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdGallery")
                        .HasColumnType("int");

                    b.Property<string>("ImageTitle")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("IdImage");

                    b.HasIndex("IdGallery");

                    b.ToTable("Imagem");
                });

            modelBuilder.Entity("ImageGallery.Models.Image", b =>
                {
                    b.HasOne("ImageGallery.Models.Gallery", "Gallery")
                        .WithMany("Images")
                        .HasForeignKey("IdGallery")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}