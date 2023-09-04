using NarniaSystem.ProjetoFila.Core.Domain.Abstractions;
using NarniaSystem.ProjetoFila.Core.Domain.Interfaces;
using NarniaSystem.ProjetoFila.Domain.Entities.Categorias.Enums;

namespace NarniaSystem.ProjetoFila.Domain.Entities.Categorias;

public class Categoria : Entity, IAggregateRoot
{
    public Categoria(string descricao, string cor)
    {
        Descricao = descricao;
        Cor = cor;
        NivelPrioridadeEnum = NivelPrioridadeEnum.Baixo;
    }

    public string Descricao { get; private set; }
    public string Cor { get; private set; } 

    public NivelPrioridadeEnum NivelPrioridadeEnum { get; private set; }

    public void AlterarNivelPrioridade(NivelPrioridadeEnum nivelPrioridadeEnum)
    {
        NivelPrioridadeEnum = nivelPrioridadeEnum;
    }
}
