using ProductPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductPage.Repository.Interface
{
    public interface IUploadingImages
    {
        Task<bool> UploadImagesAsync(UploadModel model);
    }
}
