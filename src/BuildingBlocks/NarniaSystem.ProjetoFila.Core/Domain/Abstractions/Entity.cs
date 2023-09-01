namespace NarniaSystem.ProjetoFila.Core.Domain.Abstractions
{
    public abstract class Entity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedAt { get; set; }
        public DateTime AlteredAt { get; set; }
        public bool IsActive { get; private set; } = true;
        public void ChangeIsActive(bool isActive)
        {
            IsActive = isActive;
        }
    }
}
