using NarniaSystem.ProjetoFila.Core.Domain;
using NarniaSystem.ProjetoFila.Domain.Entities.Estabelecimentos;
using NarniaSystem.ProjetoFila.Domain.Entities.Filas;

namespace NarniaSystem.ProjetoFila.Domain.Entities.Telas;

public class Tela : Entity
{
    public string Descricao { get; private set; }
    public Guid EstabelecimentoId { get; private set; }

    public virtual Estabelecimento Estabelecimento { get; set; }
    public virtual ICollection<Fila> Filas { get; set; }
}
