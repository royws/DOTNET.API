﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DOTNET.API.Data;

namespace DOTNET.API.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DOTNET.API.Models.Case", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("DOTNET.API.Models.CaseTechnique", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CaseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TechniqueId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CaseId");

                    b.HasIndex("TechniqueId");

                    b.ToTable("CaseTechniques");
                });

            modelBuilder.Entity("DOTNET.API.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("DOTNET.API.Models.Technique", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Techniques");
                });

            modelBuilder.Entity("DOTNET.API.Models.Case", b =>
                {
                    b.HasOne("DOTNET.API.Models.Company", "Company")
                        .WithMany("Cases")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("DOTNET.API.Models.CaseTechnique", b =>
                {
                    b.HasOne("DOTNET.API.Models.Case", "Case")
                        .WithMany("CaseTechniques")
                        .HasForeignKey("CaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DOTNET.API.Models.Technique", "Technique")
                        .WithMany("CaseTechniques")
                        .HasForeignKey("TechniqueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Case");

                    b.Navigation("Technique");
                });

            modelBuilder.Entity("DOTNET.API.Models.Case", b =>
                {
                    b.Navigation("CaseTechniques");
                });

            modelBuilder.Entity("DOTNET.API.Models.Company", b =>
                {
                    b.Navigation("Cases");
                });

            modelBuilder.Entity("DOTNET.API.Models.Technique", b =>
                {
                    b.Navigation("CaseTechniques");
                });
#pragma warning restore 612, 618
        }
    }
}