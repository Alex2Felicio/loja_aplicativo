using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace loja_aplicativo.Models
{
    public partial class DB_LOJAContext : DbContext
    {
        public DB_LOJAContext()
        {
        }

        public DB_LOJAContext(DbContextOptions<DB_LOJAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TabFornecedor> TabFornecedors { get; set; }
        public virtual DbSet<TabFuncionario> TabFuncionarios { get; set; }
        public virtual DbSet<TabProduto> TabProdutos { get; set; }
        public virtual DbSet<TabTipoFuncionario> TabTipoFuncionarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Database=DB_LOJA;Username=postgres;Password=masterkey");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Portuguese_Brazil.1252");

            modelBuilder.Entity<TabFornecedor>(entity =>
            {
                entity.HasKey(e => e.CdFornecedor)
                    .HasName("tab_fornecedor_pkey");

                entity.ToTable("tab_fornecedor");

                entity.Property(e => e.CdFornecedor).HasColumnName("cd_fornecedor");

                entity.Property(e => e.DsEmailContato)
                    .HasMaxLength(50)
                    .HasColumnName("ds_email_contato");

                entity.Property(e => e.DsRamo)
                    .HasMaxLength(30)
                    .HasColumnName("ds_ramo");

                entity.Property(e => e.NmFornecedor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nm_fornecedor");

                entity.Property(e => e.NmResponsavel)
                    .HasMaxLength(100)
                    .HasColumnName("nm_responsavel");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(15)
                    .HasColumnName("nr_cnpj");

                entity.Property(e => e.NrRamal)
                    .HasMaxLength(15)
                    .HasColumnName("nr_ramal");

                entity.Property(e => e.NrTelefoneEmpresa)
                    .HasMaxLength(15)
                    .HasColumnName("nr_telefone_empresa");
            });

            modelBuilder.Entity<TabFuncionario>(entity =>
            {
                entity.HasKey(e => e.CdFuncionario)
                    .HasName("tab_funcionario_pkey");

                entity.ToTable("tab_funcionario");

                entity.Property(e => e.CdFuncionario).HasColumnName("cd_funcionario");

                entity.Property(e => e.DsDataNascimento)
                    .HasColumnType("date")
                    .HasColumnName("ds_data_nascimento");

                entity.Property(e => e.DsEmail)
                    .HasMaxLength(50)
                    .HasColumnName("ds_email");

                entity.Property(e => e.IdTipoFuncionario).HasColumnName("id_tipo_funcionario");

                entity.Property(e => e.NmFuncionario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nm_funcionario");

                entity.Property(e => e.NrRg)
                    .HasMaxLength(10)
                    .HasColumnName("nr_rg");

                entity.Property(e => e.NrTelefone)
                    .HasMaxLength(15)
                    .HasColumnName("nr_telefone");

                entity.HasOne(d => d.IdTipoFuncionarioNavigation)
                    .WithMany(p => p.TabFuncionarios)
                    .HasForeignKey(d => d.IdTipoFuncionario)
                    .HasConstraintName("tab_funcionario_id_tipo_funcionario_fkey");
            });

            modelBuilder.Entity<TabProduto>(entity =>
            {
                entity.HasKey(e => e.CdProduto)
                    .HasName("tab_produto_pkey");

                entity.ToTable("tab_produto");

                entity.Property(e => e.CdProduto)
                    .ValueGeneratedNever()
                    .HasColumnName("cd_produto");

                entity.Property(e => e.DsDataEntrada)
                    .HasColumnType("date")
                    .HasColumnName("ds_data_entrada");

                entity.Property(e => e.DsMargem).HasColumnName("ds_margem");

                entity.Property(e => e.DsQuantidade).HasColumnName("ds_quantidade");

                entity.Property(e => e.DsTamanho)
                    .HasMaxLength(10)
                    .HasColumnName("ds_tamanho");

                entity.Property(e => e.DsValor).HasColumnName("ds_valor");

                entity.Property(e => e.DsValorVenda).HasColumnName("ds_valor_venda");

                entity.Property(e => e.IdFornecedor).HasColumnName("id_fornecedor");

                entity.Property(e => e.NmCor)
                    .HasMaxLength(100)
                    .HasColumnName("nm_cor");

                entity.Property(e => e.NmProduto)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nm_produto");

                entity.HasOne(d => d.IdFornecedorNavigation)
                    .WithMany(p => p.TabProdutos)
                    .HasForeignKey(d => d.IdFornecedor)
                    .HasConstraintName("tab_produto_id_fornecedor_fkey");
            });

            modelBuilder.Entity<TabTipoFuncionario>(entity =>
            {
                entity.HasKey(e => e.IdTipoFuncionario)
                    .HasName("tab_tipo_funcionario_pkey");

                entity.ToTable("tab_tipo_funcionario");

                entity.Property(e => e.IdTipoFuncionario).HasColumnName("id_tipo_funcionario");

                entity.Property(e => e.DsTipoFuncionario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ds_tipo_funcionario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
