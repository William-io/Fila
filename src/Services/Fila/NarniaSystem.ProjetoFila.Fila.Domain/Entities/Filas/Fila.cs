using NarniaSystem.ProjetoFila.Core.Domain.Abstractions;
using NarniaSystem.ProjetoFila.Core.Domain.Interfaces;
using NarniaSystem.ProjetoFila.Domain.Entities.Telas;

namespace NarniaSystem.ProjetoFila.Domain.Entities.Filas;

public class Fila : Entity, IAggregateRoot
{
    public string Descricao { get; private set; }
    public int TelaId { get; private set; }

    public virtual Tela Tela { get; set; }
}
