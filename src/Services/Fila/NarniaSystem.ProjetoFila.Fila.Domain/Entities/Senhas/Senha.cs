using NarniaSystem.ProjetoFila.Core.Domain;

namespace NarniaSystem.ProjetoFila.Domain.Entities.Senhas;

public class Senha : Entity
{
    public int CategoriaId { get; private set; }
    public string Codigo { get; private set; }
}