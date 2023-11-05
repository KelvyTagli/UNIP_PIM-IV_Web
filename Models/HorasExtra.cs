using System;
using System.Collections.Generic;

namespace PIM_IV_Web.Models;

public partial class HorasExtra
{
    public int HorasExtrasId { get; set; }

    public int? FuncionarioId { get; set; }

    public decimal? ValorHorasExtras { get; set; }

    public DateTime? MesAno { get; set; }

    public virtual Funcionario? Funcionario { get; set; }
}
