﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Model;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(AppicationDbContext))]
    [Migration("20240401054848_SeedingValues")]
    partial class SeedingValues
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApi.Model.User", b =>
                {
                    b.Property<int?>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("UserId"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            DateOfBirth = new DateTime(2001, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Adi.@gmail.com",
                            Password = "Adi",
                            UserName = "Adi"
                        },
                        new
                        {
                            UserId = 2,
                            DateOfBirth = new DateTime(2001, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Abhi.@gmail.com",
                            Password = "Abhi",
                            UserName = "Abhi"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
