using Microsoft.Extensions.DependencyInjection;
using MyOnlineScheduler_API.Activity.Application.Interfaces;
using MyOnlineScheduler_API.Activity.Application.Services;
using MyOnlineScheduler_API.Activity.Data.Context;
using MyOnlineScheduler_API.Activity.Data.Repository;
using MyOnlineScheduler_API.Activity.Domain.Interfaces;

namespace Infra.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Services 
            services.AddTransient<IActivityItemService, ActivityService>();
            services.AddTransient<IPhotoService, PhotoService>();

            //Data 
            services.AddTransient<IActivityItemRepository, ActivityItemRepository>();
            services.AddTransient<IPhotoRepository, PhotoRepository>();

            //DB Context 
            services.AddTransient<ActivityDbContext>();
        }
    }
}