using System;
using System.Collections.Generic;

namespace PIM_IV_Web.Models;

public partial class Feria
{
    public int FeriasId { get; set; }

    public int? FuncionarioId { get; set; }

    public decimal? ValorFerias { get; set; }

    public DateTime? MesAno { get; set; }

    public virtual Funcionario? Funcionario { get; set; }
}
