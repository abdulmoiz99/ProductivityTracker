using ProductivityTracker.Core.Dto;
using ProductivityTracker.Core.Dto.Common;

namespace ProductivityTracker.Core.Contracts
{
    public interface ITaskService
    {
        Task<AutoResponseDto<string>> CreateTask(CreateTaskDto dto);
    }
}
