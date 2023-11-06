using System;
using System.Collections.Generic;

namespace PIM_IV_Web.Models;

public partial class Funcionario
{
    public int FuncionarioId { get; set; }

    public string? NomeCompleto { get; set; }

    public string? Sexo { get; set; }

    public DateTime? DataNascimento { get; set; }

    public string? Cpf { get; set; }

    public string? EstadoCivil { get; set; }

    public string? Rg { get; set; }

    public string? TituloEleitor { get; set; }

    public string? Reservista { get; set; }

    public string? Email { get; set; }

    public string? Celular { get; set; }

    public string? Telefone { get; set; }

    public string? Endereco { get; set; }

    public string? Bairro { get; set; }

    public string? Numero { get; set; }

    public string? Cep { get; set; }

    public string? Complemento { get; set; }

    public string? Estado { get; set; }

    public string? Escolaridade { get; set; }

    public string? Filhos { get; set; }

    public string? Pcd { get; set; }

    public DateTime? DataContratacao { get; set; }

    public string? Cargo { get; set; }

    public string? Funcao { get; set; }

    public decimal? SalarioBase { get; set; }

    public string? Banco { get; set; }

    public string? Agencia { get; set; }

    public string? ContaCorrente { get; set; }

    public byte[]? ImagemFuncionario { get; set; }

    public bool? Ativo { get; set; }

    public int UsuarioId { get; set; }

    public virtual ICollection<Afastamento> Afastamentos { get; set; } = new List<Afastamento>();

    public virtual ICollection<ColaboradoresNovo> ColaboradoresNovos { get; set; } = new List<ColaboradoresNovo>();

    public virtual ICollection<Feria> Feria { get; set; } = new List<Feria>();

    public virtual ICollection<FolhaDePagamento> FolhaDePagamentos { get; set; } = new List<FolhaDePagamento>();

    public virtual ICollection<Holerite> Holerites { get; set; } = new List<Holerite>();

    public virtual ICollection<HorasExtra> HorasExtras { get; set; } = new List<HorasExtra>();

    public virtual ICollection<HorasTrabalhada> HorasTrabalhada { get; set; } = new List<HorasTrabalhada>();

    public virtual ICollection<Tarefa> Tarefas { get; set; } = new List<Tarefa>();
}
