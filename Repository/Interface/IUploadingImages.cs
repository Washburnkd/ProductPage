using ProductPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductPage.Data;

namespace ProductPage.Repository.Interface
{
    public interface IUploadingImages
    {
        Task<bool> UploadImagesAsync(Upload model);
    }
}
