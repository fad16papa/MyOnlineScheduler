using System;
using System.Collections.Generic;
using MyOnlineScheduler_API.Activity.Domain.Models;

namespace MyOnlineScheduler_API.Activity.Domain.Interfaces
{
    public interface IActivityItemRepository
    {
        IEnumerable<ActivityItem> GetActivities();
    }
}