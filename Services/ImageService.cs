using System;
using ProductPage.Data;
namespace ProductPage
{
    public class ImageService
    {
        private PinitgoDbContext _context;
        public ImageService(PinitgoDbContext context)
        {
            _context = context;
        }


    }
}