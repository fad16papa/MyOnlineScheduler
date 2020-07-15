using MyOnlineScheduler.Activity.Data.Context;
using MyOnlineScheduler.Activity.Domain.Interfaces;
using MyOnlineScheduler.Activity.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOnlineScheduler.Activity.Data.Repository
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly ActivityDbContext _activityDbContext;

        public ActivityRepository(ActivityDbContext activityDbContext)
        {
            _activityDbContext = activityDbContext;
        }

        public IEnumerable<ActivityList> GetActivityLists()
        {
            return _activityDbContext.ActivityLists;
        }
    }
}
