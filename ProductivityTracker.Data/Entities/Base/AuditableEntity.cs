namespace ProductivityTracker.Data.Entities.Base
{
    public class AuditableEntity<T> : BaseEntity, IAuditableEntity<T>
    {
        public T Id { get; set; }
    }
}
