using NarniaSystem.ProjetoFila.Core.Domain.Abstractions;
using NarniaSystem.ProjetoFila.Core.Domain.Interfaces;
using NarniaSystem.ProjetoFila.Domain.Entities.Guiches.Enums;

namespace NarniaSystem.ProjetoFila.Domain.Entities.Guiches;

public class Guiche : Entity, IAggregateRoot
{
    public string Descricao { get; private set; }
    public StatusGuicheEnum Status { get; private set; }

    public Guiche(string descricao)
    {
        Descricao = descricao;
        Status = StatusGuicheEnum.Fechado;
    }

    public void AlterarStatus(StatusGuicheEnum novoStatus)
    {

        if (Status == StatusGuicheEnum.Fechado && novoStatus == StatusGuicheEnum.Pausado)
        {
            throw new ArgumentException("Não é possivel alterar status de fechado para pausado");
        }

        Status = novoStatus;
    }
}