namespace ProductivityTracker.Data.Entities.Base
{
    public class AuditableEntity<T> : IAuditableEntity<T>
    {
        public T Id { get; set; }
    }
}
