using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServerApp.Services;
using ServerApp.Data;

namespace ServerApp.Controllers
{
    [Route("api/forums")]
    [ApiController]
    public class ForumController : Controller
    {
        private readonly IForum _forumService;
        private readonly IImage _imageService;
        public ForumController(IForum forumService)
        {
            _forumService = forumService;
        }

        [HttpGet("{id}")]
        public Forum GetForum(int id)
        {
            return _forumService.GetById(id);
        }
        [HttpGet]
        public IEnumerable<Forum> GetForum(string category)
        {
            var query = _forumService.GetAll();
            if (!string.IsNullOrWhiteSpace(category))
            {
                string catLower = category.ToLower();
                query = _forumService.GetFilteredForums(catLower);
                return query.ToList();
            }
            return _forumService.GetAll();
        }
        [HttpPost]
        public IActionResult CreateForum([FromBody] Forum forum)
        {
            if (ModelState.IsValid)
            {
                var model = forum;
                _forumService.Add(model);
                return Ok(model.Title);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

    }
}
