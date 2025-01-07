namespace ProductivityTracker.Core.Dto.Task
{
    public class TasksDto
    {
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DueDate { get; set; }
        public string Sentiment { get; set; }
    }
}
