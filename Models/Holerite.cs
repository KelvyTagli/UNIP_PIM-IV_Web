using System;
using System.Collections.Generic;

namespace PIM_IV_Web.Models;

public partial class Holerite
{
    public int HoleriteId { get; set; }

    public int? FuncionarioId { get; set; }

    public decimal SalarioBase { get; set; }

    public decimal? SalarioBruto { get; set; }

    public decimal? SalarioLiquido { get; set; }

    public decimal? Inss { get; set; }

    public decimal? Fgts { get; set; }

    public decimal? ImpostoRenda { get; set; }

    public decimal? HorasTrabalhadas { get; set; }

    public decimal? OutrosDescontos { get; set; }

    public DateTime? DataEmissao { get; set; }

    public decimal? Beneficios { get; set; }

    public decimal? HorasExtras { get; set; }

    public decimal? ValorHoraExtra { get; set; }

    public decimal? Deducoes { get; set; }

    public string? Observacoes { get; set; }

    public virtual Funcionario? Funcionario { get; set; }
}
