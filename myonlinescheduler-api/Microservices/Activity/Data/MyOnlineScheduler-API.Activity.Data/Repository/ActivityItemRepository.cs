using System.Collections.Generic;
using MyOnlineScheduler_API.Activity.Data.Context;
using MyOnlineScheduler_API.Activity.Domain.Interfaces;
using MyOnlineScheduler_API.Activity.Domain.Models;

namespace MyOnlineScheduler_API.Activity.Data.Repository
{
    public class ActivityItemRepository : IActivityItemRepository
    {
        private readonly ActivityDbContext _activityDbContext;

        public ActivityItemRepository(ActivityDbContext activityDbContext)
        {
            _activityDbContext = activityDbContext;
        }

        public IEnumerable<ActivityItem> GetActivities()
        {
            return _activityDbContext.Activities;
        }
    }
}