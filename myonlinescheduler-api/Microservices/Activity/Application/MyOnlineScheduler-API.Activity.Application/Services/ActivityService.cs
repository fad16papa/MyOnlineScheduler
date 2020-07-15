using System.Collections.Generic;
using MyOnlineScheduler_API.Activity.Application.Interfaces;
using MyOnlineScheduler_API.Activity.Domain.Interfaces;
using MyOnlineScheduler_API.Activity.Domain.Models;

namespace MyOnlineScheduler_API.Activity.Application.Services
{
    public class ActivityService : IActivityItemService
    {
        private readonly IActivityItemRepository _activityItemRepository;
        public ActivityService(IActivityItemRepository activityItemRepository)
        {
            _activityItemRepository = activityItemRepository;
        }

        public IEnumerable<ActivityItem> GetActivities()
        {
            return _activityItemRepository.GetActivities();
        }
    }
}