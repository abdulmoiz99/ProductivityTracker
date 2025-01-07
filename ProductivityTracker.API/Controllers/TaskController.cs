using Microsoft.AspNetCore.Mvc;

namespace ProductivityTracker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private static readonly Task[] Tasks =
        [
            new Task { Id = 1, Title = "Task 1", Description = "Complete the project documentation", Status = "In Progress" },
            new Task { Id = 2, Title = "Task 2", Description = "Review pull requests", Status = "Completed" },
            new Task { Id = 3, Title = "Task 3", Description = "Fix the bug in the login module", Status = "Pending" },
            new Task { Id = 4, Title = "Task 4", Description = "Update the database schema", Status = "In Progress" },
            new Task { Id = 5, Title = "Task 5", Description = "Prepare the project presentation", Status = "Completed" }
        ];

        [HttpGet(Name = "GetTasks")]
        public IActionResult Get()
        {
            return Ok(Tasks);
        }
    }

    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
