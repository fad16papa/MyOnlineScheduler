using MyOnlineScheduler.Activity.Data.Context;
using MyOnlineScheduler.Activity.Domain.Interfaces;
using MyOnlineScheduler.Activity.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOnlineScheduler.Activity.Data.Repository
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
