using MyOnlineScheduler.Activity.Application.Interfaces;
using MyOnlineScheduler.Activity.Domain.Interfaces;
using MyOnlineScheduler.Activity.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOnlineScheduler.Activity.Application.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IActivityRepository _activityRepository;

        public ActivityService(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }

        public IEnumerable<ActivityList> GetActivityLists()
        {
            return _activityRepository.GetActivityLists();
        }
    }
}
