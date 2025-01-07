using ProductivityTracker.Data;

namespace ProductivityTracker.Core.Core
{
    public class BaseService
    {
        protected readonly ProductivityTrackerDbContext _dbContext;
        //protected readonly IHttpContextAccessor _httpContextAccessor;

        public BaseService(ProductivityTrackerDbContext dbContext)
        {
            _dbContext = dbContext;
            //_httpContextAccessor = httpContextAccessor;
        }
    }
}
