using NarniaSystem.ProjetoFila.Core.Domain.Abstractions;
using NarniaSystem.ProjetoFila.Core.Domain.Interfaces;
using NarniaSystem.ProjetoFila.Domain.Entities.Estabelecimentos;
using NarniaSystem.ProjetoFila.Domain.Entities.Filas;

namespace NarniaSystem.ProjetoFila.Domain.Entities.Telas;

public class Tela : Entity, IAggregateRoot
{
    public string Descricao { get; private set; }
    public Guid EstabelecimentoId { get; private set; }

    public virtual Estabelecimento Estabelecimento { get; set; }
    public virtual ICollection<Fila> Filas { get; set; }
}
