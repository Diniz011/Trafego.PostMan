﻿// <auto-generated />
using Fiap.Web.LiveOn.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace Fiap.Web.LiveOn.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240612000220_AddModeloVeiculo")]
    partial class AddModeloVeiculo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fiap.Web.LiveOn.Models.ModeloVeiculo", b =>
                {
                    b.Property<int>("ModeloVeiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ModeloVeiculoId"));

                    b.Property<int>("AnoModelo")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("MontadoraId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("NomeModelo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("TipoCombustivel")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("ModeloVeiculoId");

                    b.HasIndex("MontadoraId");

                    b.ToTable("MODELOS", (string)null);
                });

            modelBuilder.Entity("Fiap.Web.LiveOn.Models.Montadora", b =>
                {
                    b.Property<int>("MontadoraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MontadoraId"));

                    b.Property<int>("AnoFundacao")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("PaisOrigem")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.HasKey("MontadoraId");

                    b.HasIndex("Nome");

                    b.HasIndex("PaisOrigem", "AnoFundacao")
                        .HasDatabaseName("IDX_PAIS_ANO");

                    b.ToTable("MONTADORA", (string)null);
                });

            modelBuilder.Entity("Fiap.Web.LiveOn.Models.ModeloVeiculo", b =>
                {
                    b.HasOne("Fiap.Web.LiveOn.Models.Montadora", "Montadora")
                        .WithMany()
                        .HasForeignKey("MontadoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Montadora");
                });
#pragma warning restore 612, 618
        }
    }
}
