using System;
using System.Collections.Generic;

namespace PIM_IV_Web.Models;

public partial class Tarefa
{
    public int TarefaId { get; set; }

    public int FuncionarioId { get; set; }

    public string Prioridades { get; set; } = null!;

    public string Tipos { get; set; } = null!;

    public string? Titulo { get; set; }

    public DateTime? DataEntrega { get; set; }

    public int? StatusTarefa { get; set; }

    public virtual Funcionario Funcionario { get; set; } = null!;
}
