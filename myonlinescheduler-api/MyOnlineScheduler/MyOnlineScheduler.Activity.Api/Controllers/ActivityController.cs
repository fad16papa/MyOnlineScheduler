using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyOnlineScheduler.Activity.Application.Interfaces;
using MyOnlineScheduler.Activity.Domain.Models;

namespace MyOnlineScheduler.Activity.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityService _activityService;

        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        /// <summary>
        /// This fetch all the activity
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<ActivityList>> Get()
        {
            return Ok(_activityService.GetActivityLists());
        }
    }
}
