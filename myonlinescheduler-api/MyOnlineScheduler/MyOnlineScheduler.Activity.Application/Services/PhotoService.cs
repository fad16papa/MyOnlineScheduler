using MyOnlineScheduler.Activity.Application.Interfaces;
using MyOnlineScheduler.Activity.Domain.Interfaces;
using MyOnlineScheduler.Activity.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOnlineScheduler.Activity.Application.Services
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
