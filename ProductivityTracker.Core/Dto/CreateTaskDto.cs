namespace ProductivityTracker.Core.Dto
{
    public class CreateTaskDto
    {
        public string Description { get; set; }
        public string Status { get; set; } // Pending, Completed
        public DateTime DueDate { get; set; }
        public string Sentiment { get; set; }
    }
}
