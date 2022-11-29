using System;
using System.Collections.Generic;

namespace ProjetoEstacionamento.Model;

public partial class Automovei
{
    public int Id { get; set; }

    public string? Modelo { get; set; }

    public int? Preco { get; set; }
}
