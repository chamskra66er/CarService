using ServerApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Services
{
    public class ImageService : IImage
    {
        private readonly ApplicationDbContext _context;
        public ImageService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Image image)
        {
            _context.Add(image);
            await _context.SaveChangesAsync();
        }

        public Image Delete(int id)
        {
            var image = GetById(id);
            if (image != null)
            {
                _context.Images.Remove(image);
                _context.SaveChanges();
            }
            return image;
        }

        public IEnumerable<Image> GetAll()
        {
            return _context.Images;
        }

        public Image GetById(int id)
        {
            var image = _context.Images.Find(id);
            return image;
        }

        public async Task Update(Image image, int id)
        {
            var img = GetById(id);
            img.ImgUrl1 = image.ImgUrl1;
            img.ImgUrl2 = image.ImgUrl2;
            img.ImgUrl3 = image.ImgUrl3;
            img.ImgUrl4 = image.ImgUrl4;
            await _context.SaveChangesAsync();
        }
    }
}
