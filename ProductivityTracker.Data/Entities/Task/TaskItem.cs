using ProductivityTracker.Data.Entities.Base;

namespace ProductivityTracker.Data.Entities.Task
{
    public class TaskItem : AuditableEntity<int>
    {
        public string Description { get; set; }
        public string Status { get; set; } // Pending, Completed
        public DateTime DueDate { get; set; }
        public string Sentiment { get; set; }
    }
}
