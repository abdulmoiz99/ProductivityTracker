using Microsoft.EntityFrameworkCore;
using ProductivityTracker.Core.Contracts;
using ProductivityTracker.Core.Dto.Common;
using ProductivityTracker.Core.Dto.Task;
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
        public async Task<AutoResponseDto<List<TasksDto>>> Tasks()
        {
            var response = new AutoResponseDto<List<TasksDto>>()
            {
                Result = await _dbContext.Tasks
                                         .Where(sc => sc.Status != "COMPLETED")
                                         .Select(sc => new TasksDto()
                                         {
                                             Description = sc.Description,
                                             Status = sc.Status,
                                             DueDate = sc.DueDate,
                                             Sentiment = sc.Sentiment,
                                         })
                                         .ToListAsync()
            };

            return response;
        }
    }
}
