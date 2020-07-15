using System.Collections.Generic;
using MyOnlineScheduler_API.Activity.Data.Context;
using MyOnlineScheduler_API.Activity.Domain.Interfaces;
using MyOnlineScheduler_API.Activity.Domain.Models;

namespace MyOnlineScheduler_API.Activity.Data.Repository
{
    public class PhotoRepository : IPhotoRepository
    {
        private readonly ActivityDbContext _activityDbContext;
        public PhotoRepository(ActivityDbContext activityDbContext)
        {
            _activityDbContext = activityDbContext;
        }

        public IEnumerable<Photo> GetPhotos()
        {
            return _activityDbContext.Photos;
        }
    }
}