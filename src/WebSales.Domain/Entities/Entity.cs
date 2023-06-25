namespace WebSales.Domain.Entities
{
    public abstract class Entity
    {
        public int? Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? ModifiedAt { get; private set; }

        public Entity()
        {
            CreatedAt = DateTime.Now;
            ModifiedAt = null;
        }

        public Entity(int id)
        {
            Id = id;
            CreatedAt = DateTime.Now;
            ModifiedAt = null;
        }

        public Entity(int id, DateTime createdAt, DateTime modifiedAt)
        {
            Id = id;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
        }
    }
}