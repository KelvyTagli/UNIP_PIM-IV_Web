using System;
using System.Collections.Generic;

namespace PIM_IV_Web.Models;

public partial class HorasTrabalhada
{
    public int HorasTrabalhadasId { get; set; }

    public int? FuncionarioId { get; set; }

    public string? MesAno { get; set; }

    public DateTime? DataRegistro { get; set; }

    public TimeSpan? HoraEntrada { get; set; }

    public TimeSpan? HoraSaida { get; set; }

    public string? HorasTrabalhadas { get; set; }

    public virtual Funcionario? Funcionario { get; set; }
}
