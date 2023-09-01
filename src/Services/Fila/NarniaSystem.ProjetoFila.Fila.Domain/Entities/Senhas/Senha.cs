using NarniaSystem.ProjetoFila.Core.Domain.Abstractions;
using NarniaSystem.ProjetoFila.Core.Domain.Interfaces;

namespace NarniaSystem.ProjetoFila.Domain.Entities.Senhas;

public class Senha : Entity, IAggregateRoot
{
    public int CategoriaId { get; private set; }
    public string Codigo { get; private set; }
}