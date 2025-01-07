using ProductivityTracker.Core.Contracts;
using ProductivityTracker.Core.Dto;
using ProductivityTracker.Core.Dto.Common;
using ProductivityTracker.Data;
using ProductivityTracker.Data.Entities.Task;

namespace ProductivityTracker.Core.Core
{
    public class TaskService(ProductivityTrackerDbContext dbContext) : BaseService(dbContext), ITaskService
    {
        public async  Task<AutoResponseDto<string>> CreateTask(CreateTaskDto dto)
        {

            var response = new AutoResponseDto<string>();
            var task = new TaskItem()
            {
                Description = dto.Description,
                Status = dto.Status,
                DueDate = new DateTime(),
                Sentiment = dto.Sentiment
            };

            await _dbContext.Tasks.AddAsync(task);
            await _dbContext.SaveChangesAsync();
            return response;
        }
    }
}
