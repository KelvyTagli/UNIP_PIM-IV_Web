using System;
using System.Collections.Generic;

namespace PIM_IV_Web.Models;

public partial class FolhaDePagamento
{
    public int FolhaId { get; set; }

    public int? FuncionarioId { get; set; }

    public string? Observacoes { get; set; }

    public virtual Funcionario? Funcionario { get; set; }
}
