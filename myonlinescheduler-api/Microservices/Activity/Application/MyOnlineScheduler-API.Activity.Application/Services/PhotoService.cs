using System.Collections.Generic;
using MyOnlineScheduler_API.Activity.Application.Interfaces;
using MyOnlineScheduler_API.Activity.Domain.Interfaces;
using MyOnlineScheduler_API.Activity.Domain.Models;

namespace MyOnlineScheduler_API.Activity.Application.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly IPhotoRepository _photoRepository;
        public PhotoService(IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }

        public IEnumerable<Photo> GetPhotos()
        {
            return _photoRepository.GetPhotos();
        }
    }
}