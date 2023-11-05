using System;
using System.Collections.Generic;

namespace PIM_IV_Web.Models;

public partial class Afastamento
{
    public int AfastamentoId { get; set; }

    public int? FuncionarioId { get; set; }

    public decimal? ValorAfastamentos { get; set; }

    public DateTime? MesAno { get; set; }

    public virtual Funcionario? Funcionario { get; set; }
}
