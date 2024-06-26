using Fiap.Web.LiveOn.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Fiap.Web.LiveOn.Data.Contexts
{
    public class DatabaseContext : DbContext
    {
        internal object Congestionamento;

        public DbSet<Trafego> Trafego { get; set; }

        public DbSet<Trafego> Acidentes { get; set; }
        public object NomedaAvenida { get; internal set; }
        public object Congestionamentos { get; internal set; }
        public object congestionamento { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trafego>( e =>
            {
                e.ToTable("TRAFEGO");

                e.HasKey(e => e.AvenidaId);

                e.Property(e => e.AvenidaId).IsRequired();
                e.Property(e => e.Congestionamentos).HasMaxLength(50);
                e.Property(e => e.Acidentes);

                e.HasIndex( e => e.Equals);

                e.HasIndex(e => new { e.AvenidaId, e.Acidentes })
                    .HasName("IDX_PAIS_ANO");

            });


            modelBuilder.Entity<Trafego>(entity =>
            {
                entity.ToTable("TRAFEGO");  // Define o nome da tabela
                entity.HasKey(e => e.AvenidaId);  // Define a chave primária

                // Define propriedades com configurações adicionais conforme necessário
                entity.Property(e => e.Acidentes); // Adicione .HasColumnType("tipo") se necessário
                entity.Property(e => e.Congestionamentos); // Adicione .HasColumnType("tipo") se necessário
                entity.Property(e => e.FarolQuebrado); // Adicione .HasColumnType("tipo") se necessário

                // Configuração do relacionamento
                entity.HasOne<AvenidaId>() // Especifica a entidade relacionada
                      .WithMany()  // Assume que uma avenida pode ter muitos tráfegos
                      .HasForeignKey(e => e.AvenidaId)  // Define a chave estrangeira
                      .IsRequired();  // Define como obrigatório
            });



        }


        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected DatabaseContext()
        {
        }
    }

    internal class AvenidaId
    {
    }
}
