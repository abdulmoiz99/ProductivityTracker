using Microsoft.AspNetCore.Mvc;
using ProductivityTracker.Core.Contracts;
using ProductivityTracker.Core.Dto.Task;

namespace ProductivityTracker.API.Controllers
{
    public class TaskController : BaseController
    {
        private readonly ITaskService _service;

        public TaskController(ITaskService taskService)
        {
            _service = taskService;
        }

        [HttpPost]
        [Route("create-task")]
        public async Task<IActionResult> CreateTask(CreateTaskDto dto)
        {
            var response = await _service.CreateTask(dto);
            return StatusCode((int)response.StatusCode, response);
        }
        [HttpGet]
        public async Task<IActionResult> Tasks()
        {
            var response = await _service.Tasks();
            return StatusCode((int)response.StatusCode, response);
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
