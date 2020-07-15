using MyOnlineScheduler.Activity.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOnlineScheduler.Activity.Domain.Interfaces
{
    public interface IPhotoRepository
    {
        IEnumerable<Photo> GetPhotos();
    }
}
