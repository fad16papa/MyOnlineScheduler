﻿using MyOnlineScheduler.Activity.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOnlineScheduler.Activity.Application.Interfaces
{
    public interface IActivityService
    {
        IEnumerable<ActivityList> GetActivityLists();
    }
}
