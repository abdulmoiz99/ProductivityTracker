using ProductivityTracker.Core.Dto.Common;
using ProductivityTracker.Core.Dto.Task;

namespace ProductivityTracker.Core.Contracts
{
    public interface ITaskService
    {
        Task<AutoResponseDto<string>> CreateTask(CreateTaskDto dto);
        Task<AutoResponseDto<List<TasksDto>>> Tasks();
    }
}
