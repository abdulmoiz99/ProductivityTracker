namespace ProductivityTracker.Data.Entities.Base
{
    public interface IAuditableEntity<T>
    {
        T Id { get; set; }
    }
}
