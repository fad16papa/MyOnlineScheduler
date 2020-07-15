using Microsoft.Extensions.DependencyInjection;
using MyOnlineScheduler.Activity.Application.Interfaces;
using MyOnlineScheduler.Activity.Application.Services;
using MyOnlineScheduler.Activity.Data.Context;
using MyOnlineScheduler.Activity.Data.Repository;
using MyOnlineScheduler.Activity.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOnlineScheduler.Infra.IOC
{
    public class DependencyInjection
    {
        public static void RegisterService(IServiceCollection services)
        {
            //Activity Application Services
            services.AddTransient<IActivityService, ActivityService>();
            services.AddTransient<IPhotoService, PhotoService>();

            //Activity Data 
            services.AddTransient<IActivityRepository, ActivityRepository>();
            services.AddTransient<IPhotoRepository, PhotoRepository>();
            services.AddTransient<ActivityDbContext>();
        }
    }
}
