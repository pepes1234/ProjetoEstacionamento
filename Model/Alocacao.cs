using System;
using System.Collections.Generic;

namespace ProjetoEstacionamento.Model;

public partial class Alocacao
{
    public int Id { get; set; }

    public int? Area { get; set; }

    public int? Automoveis { get; set; }

    public int? Concessionaria { get; set; }

    public int? Quantidade { get; set; }
}
