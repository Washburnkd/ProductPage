using System;
using ProductPage.Data;
using System.Threading.Tasks;
using System.Linq;
namespace ProductPage
{
    public class ImageService
    {
        private PinitgoDbContext _context;
        public ImageService(PinitgoDbContext context)
        {
            _context = context;
        }

        public async Task<bool> SaveImageAsync(string filename)
        {
            var u = new Upload();
            u.Name = filename;
            u.AID = 1;
            _context.Uploads.Add(u);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteImageAsync(int uid, string filePath)
        {
            var found = _context.Uploads.Where(x => x.UID == uid).FirstOrDefault();
            _context.Uploads.Remove(found);
            await _context.SaveChangesAsync();
            //System.IO.File.Delete(filePath);
            return true;
        }
    }
}