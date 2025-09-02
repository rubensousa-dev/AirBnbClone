namespace DevBnbStart.Core.Entities
{
    public abstract class BaseEntities
    {
        protected BaseEntities()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
            IsDeleted = false;
        }
        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool IsDeleted { get; private set; }

        public void SetAsDeleted()
        {
            IsDeleted = true;
        }
    }
}
