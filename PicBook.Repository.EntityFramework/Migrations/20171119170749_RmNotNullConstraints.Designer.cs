﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PicBook.Repository.EntityFramework;
using System;

namespace PicBook.Repository.EntityFramework.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20171119170749_RmNotNullConstraints")]
    partial class RmNotNullConstraints
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PicBook.Domain.PictureEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<Guid>("FileId");

                    b.Property<string>("ImgPath")
                        .IsRequired();

                    b.Property<bool>("IsPublic");

                    b.Property<string>("Name");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("PicBook.Domain.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.Property<string>("Provider");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.Property<string>("UserIdentifier");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PicBook.Domain.PictureEntity", b =>
                {
                    b.HasOne("PicBook.Domain.UserEntity", "User")
                        .WithMany("Pictures")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
