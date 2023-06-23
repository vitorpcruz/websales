namespace WebSales.Domain.Entities
{
    public abstract class Entity
    { 
        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? ModifiedAt { get; private set; }

        protected Entity()
        {
            CreatedAt = DateTime.Now;
            ModifiedAt = null;
        }
    }
}