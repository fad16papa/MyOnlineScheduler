using System.Collections.Generic;
using MyOnlineScheduler_API.Activity.Domain.Models;

namespace MyOnlineScheduler_API.Activity.Domain.Interfaces
{
    public interface IPhotoRepository
    {
        IEnumerable<Photo> GetPhotos();
    }
}