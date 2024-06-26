﻿// <auto-generated />
using Fiap.Web.LiveOn.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace Fiap.Web.LiveOn.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fiap.Web.LiveOn.Models.Acidentes", b =>
                {
                    b.Property<int>("AcidentesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AcidentesId"));

                    b.Property<int>("Acidentes")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("AcidentesId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("AvenidaId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("FarolQuebrado")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("AcidentesId");

                    b.HasIndex("AvenidaId");

                    b.ToTable("ACIDENTES", (string)null);
                });

            modelBuilder.Entity("Fiap.Web.LiveOn.Models.Congestionamento", b =>
                {
                    b.Property<int>("AcidentesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MontadoraId"));

                    b.Property<int>("CamerasdaAvenida")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("NomedaAvenida")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("FarolQuebrado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.HasKey("AcidentesId");

                    b.HasIndex("Nome");

                    b.HasIndex("NomedaAvenida", "FarolQuebrado")
                        .HasDatabaseName("IDX_PAIS_ANO");

                    b.ToTable("Congestionamento", (string)null);
                });

            modelBuilder.Entity("Fiap.Web.LiveOn.Models.Acidentes", b =>
                {
                    b.HasOne("Fiap.Web.LiveOn.Models.ACIDENTES", "Acidentes")
                        .WithMany()
                        .HasForeignKey("AcidentesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Acidentes");
                });
#pragma warning restore 612, 618
        }
    }
}
