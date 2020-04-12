using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerApp.Data;

namespace ServerApp.Services
{
    public interface IImage
    {
        Image GetById(int id);
        Image Delete(int id);
        Task Update(Image image, int id);
        Task Add(Image image);
        IEnumerable<Image> GetAll();
    }
}
