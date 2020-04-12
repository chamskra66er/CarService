using Microsoft.AspNetCore.Mvc;
using ServerApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerApp.Data;

namespace ServerApp.Controllers
{
    [Route("/api/images")]
    public class ImageController : Controller
    {
        private readonly IImage _imageService;
        public ImageController(IImage imageService)
        {
            _imageService = imageService;
        }
        [HttpGet]
        public IEnumerable<Image> GetImages()
        {
            return _imageService.GetAll();
        }
        [HttpPost]
        public IActionResult CreateImage([FromBody] Image image)
        {
            if (ModelState.IsValid)
            {
                var model = image;
                _imageService.Add(model);
                return Ok(model.ImgUrl1);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        
    }
}
