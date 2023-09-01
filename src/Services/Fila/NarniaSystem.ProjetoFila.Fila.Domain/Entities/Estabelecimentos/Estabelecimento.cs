using NarniaSystem.ProjetoFila.Core.Domain.Abstractions;
using NarniaSystem.ProjetoFila.Core.Domain.Interfaces;

namespace NarniaSystem.ProjetoFila.Domain.Entities.Estabelecimentos;

public class Estabelecimento : Entity, IAggregateRoot
{
    public string Descricao { get; private set; }
}
