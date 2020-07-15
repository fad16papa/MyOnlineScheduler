using System.Collections.Generic;
using MyOnlineScheduler_API.Activity.Domain.Models;

namespace MyOnlineScheduler_API.Activity.Application.Interfaces
{
    public interface IPhotoService
    {
        IEnumerable<Photo> GetPhotos();
    }
}