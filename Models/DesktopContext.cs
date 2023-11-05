using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PIM_IV_Web.Models;

public partial class DesktopContext : DbContext
{

    public DesktopContext()
    {
    }

    public DesktopContext(DbContextOptions<DesktopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Afastamento> Afastamentos { get; set; }

    public virtual DbSet<ColaboradoresNovo> ColaboradoresNovos { get; set; }

    public virtual DbSet<Feria> Ferias { get; set; }

    public virtual DbSet<FolhaDePagamento> FolhaDePagamentos { get; set; }

    public virtual DbSet<Funcionario> Funcionarios { get; set; }

    public virtual DbSet<Holerite> Holerites { get; set; }

    public virtual DbSet<HorasExtra> HorasExtras { get; set; }

    public virtual DbSet<HorasTrabalhada> HorasTrabalhadas { get; set; }

    public virtual DbSet<Tarefa> Tarefas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=Tagliacolli;database=DESKTOP;trusted_Connection=true;Trustservercertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Afastamento>(entity =>
        {
            entity.HasKey(e => e.AfastamentoId).HasName("PK__Afastame__4C49EC7E6F6E3010");

            entity.Property(e => e.AfastamentoId).HasColumnName("AfastamentoID");
            entity.Property(e => e.FuncionarioId).HasColumnName("FuncionarioID");
            entity.Property(e => e.MesAno).HasColumnType("date");
            entity.Property(e => e.ValorAfastamentos).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Funcionario).WithMany(p => p.Afastamentos)
                .HasForeignKey(d => d.FuncionarioId)
                .HasConstraintName("FK__Afastamen__Funci__412EB0B6");
        });

        modelBuilder.Entity<ColaboradoresNovo>(entity =>
        {
            entity.HasKey(e => e.ColaboradorNovoId).HasName("PK__Colabora__905D552D0AD08131");

            entity.Property(e => e.ColaboradorNovoId).HasColumnName("ColaboradorNovoID");
            entity.Property(e => e.Abril).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Agosto).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Dezembro).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Fevereiro).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.FuncionarioId).HasColumnName("FuncionarioID");
            entity.Property(e => e.Janeiro).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Julho).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Junho).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Maio).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Marco).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Novembro).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Outubro).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Setembro).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Funcionario).WithMany(p => p.ColaboradoresNovos)
                .HasForeignKey(d => d.FuncionarioId)
                .HasConstraintName("FK__Colaborad__Funci__49C3F6B7");
        });

        modelBuilder.Entity<Feria>(entity =>
        {
            entity.HasKey(e => e.FeriasId).HasName("PK__Ferias__35809511414DE581");

            entity.Property(e => e.FeriasId).HasColumnName("FeriasID");
            entity.Property(e => e.FuncionarioId).HasColumnName("FuncionarioID");
            entity.Property(e => e.MesAno).HasColumnType("date");
            entity.Property(e => e.ValorFerias).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Funcionario).WithMany(p => p.Feria)
                .HasForeignKey(d => d.FuncionarioId)
                .HasConstraintName("FK__Ferias__Funciona__440B1D61");
        });

        modelBuilder.Entity<FolhaDePagamento>(entity =>
        {
            entity.HasKey(e => e.FolhaId).HasName("PK__FolhaDeP__A1B1048279B881DD");

            entity.ToTable("FolhaDePagamento");

            entity.Property(e => e.FolhaId).HasColumnName("FolhaID");
            entity.Property(e => e.FuncionarioId).HasColumnName("FuncionarioID");

            entity.HasOne(d => d.Funcionario).WithMany(p => p.FolhaDePagamentos)
                .HasForeignKey(d => d.FuncionarioId)
                .HasConstraintName("FK__FolhaDePa__Funci__4F7CD00D");
        });

        modelBuilder.Entity<Funcionario>(entity =>
        {
            entity.HasKey(e => e.FuncionarioId).HasName("PK__Funciona__297ECD4A8020802C");

            entity.Property(e => e.FuncionarioId).HasColumnName("FuncionarioID");
            entity.Property(e => e.Agencia).HasMaxLength(20);
            entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bairro).HasMaxLength(100);
            entity.Property(e => e.Banco).HasMaxLength(50);
            entity.Property(e => e.Cargo).HasMaxLength(50);
            entity.Property(e => e.Celular).HasMaxLength(20);
            entity.Property(e => e.Cep)
                .HasMaxLength(10)
                .HasColumnName("CEP");
            entity.Property(e => e.Complemento).HasMaxLength(200);
            entity.Property(e => e.ContaCorrente).HasMaxLength(20);
            entity.Property(e => e.Cpf)
                .HasMaxLength(14)
                .HasColumnName("CPF");
            entity.Property(e => e.DataContratacao).HasColumnType("date");
            entity.Property(e => e.DataNascimento).HasColumnType("date");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Endereco).HasMaxLength(200);
            entity.Property(e => e.Escolaridade).HasMaxLength(50);
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.EstadoCivil).HasMaxLength(20);
            entity.Property(e => e.Filhos).HasMaxLength(50);
            entity.Property(e => e.Funcao).HasMaxLength(50);
            entity.Property(e => e.NomeCompleto).HasMaxLength(200);
            entity.Property(e => e.Numero).HasMaxLength(20);
            entity.Property(e => e.Pcd)
                .HasMaxLength(50)
                .HasColumnName("PCD");
            entity.Property(e => e.Reservista).HasMaxLength(20);
            entity.Property(e => e.Rg)
                .HasMaxLength(20)
                .HasColumnName("RG");
            entity.Property(e => e.SalarioBase).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Sexo).HasMaxLength(10);
            entity.Property(e => e.Telefone).HasMaxLength(20);
            entity.Property(e => e.TituloEleitor).HasMaxLength(20);
            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
        });

        modelBuilder.Entity<Holerite>(entity =>
        {
            entity.HasKey(e => e.HoleriteId).HasName("PK__tmp_ms_x__CF69223E131AD7D3");

            entity.ToTable("Holerite");

            entity.Property(e => e.HoleriteId).HasColumnName("HoleriteID");
            entity.Property(e => e.Beneficios).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.DataEmissao).HasColumnType("date");
            entity.Property(e => e.Deducoes).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Fgts)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FGTS");
            entity.Property(e => e.FuncionarioId).HasColumnName("FuncionarioID");
            entity.Property(e => e.HorasExtras).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.HorasTrabalhadas).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ImpostoRenda).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Inss)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("INSS");
            entity.Property(e => e.OutrosDescontos).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.SalarioBase).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.SalarioBruto).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.SalarioLiquido).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ValorHoraExtra).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Funcionario).WithMany(p => p.Holerites)
                .HasForeignKey(d => d.FuncionarioId)
                .HasConstraintName("FK__Holerite__Funcio__628FA481");
        });

        modelBuilder.Entity<HorasExtra>(entity =>
        {
            entity.HasKey(e => e.HorasExtrasId).HasName("PK__HorasExt__0B6D7C5DA5CF246C");

            entity.Property(e => e.HorasExtrasId).HasColumnName("HorasExtrasID");
            entity.Property(e => e.FuncionarioId).HasColumnName("FuncionarioID");
            entity.Property(e => e.MesAno).HasColumnType("date");
            entity.Property(e => e.ValorHorasExtras).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Funcionario).WithMany(p => p.HorasExtras)
                .HasForeignKey(d => d.FuncionarioId)
                .HasConstraintName("FK__HorasExtr__Funci__46E78A0C");
        });

        modelBuilder.Entity<HorasTrabalhada>(entity =>
        {
            entity.HasKey(e => e.HorasTrabalhadasId).HasName("PK__HorasTra__68AB7FFE40486140");

            entity.Property(e => e.HorasTrabalhadasId).HasColumnName("HorasTrabalhadasID");
            entity.Property(e => e.DataRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date");
            entity.Property(e => e.FuncionarioId).HasColumnName("FuncionarioID");
            entity.Property(e => e.HorasTrabalhadas)
                .HasMaxLength(30)
                .HasComputedColumnSql("(CONVERT([nvarchar],datediff(minute,[HoraEntrada],[HoraSaida])/(60.0)-(1)))", false);
            entity.Property(e => e.MesAno)
                .HasMaxLength(255)
                .HasDefaultValueSql("(CONVERT([nvarchar](255),datepart(month,getdate())))");

            entity.HasOne(d => d.Funcionario).WithMany(p => p.HorasTrabalhada)
                .HasForeignKey(d => d.FuncionarioId)
                .HasConstraintName("FK__HorasTrab__Funci__2B0A656D");
        });

        modelBuilder.Entity<Tarefa>(entity =>
        {
            entity.HasKey(e => e.TarefaId).HasName("PK__tmp_ms_x__1EE07C6F3C3EE98F");

            entity.Property(e => e.TarefaId).HasColumnName("TarefaID");
            entity.Property(e => e.DataEntrega).HasColumnType("date");
            entity.Property(e => e.FuncionarioId).HasColumnName("FuncionarioID");
            entity.Property(e => e.Prioridades)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StatusTarefa).HasDefaultValueSql("((0))");
            entity.Property(e => e.Tipos)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(45)
                .IsUnicode(false);

            entity.HasOne(d => d.Funcionario).WithMany(p => p.Tarefas)
                .HasForeignKey(d => d.FuncionarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Tarefas__Funcion__151B244E");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PK__Usuarios__2B3DE798F017D4BA");

            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            entity.Property(e => e.DataCriacao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.NomeUsuario).HasMaxLength(50);
            entity.Property(e => e.Senha).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    internal string? GetUserById(int userId)
    {
        throw new NotImplementedException();
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
