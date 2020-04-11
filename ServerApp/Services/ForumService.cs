using Microsoft.EntityFrameworkCore;
using ServerApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Services
{
    public class ForumService : IForum
    {
        private readonly ApplicationDbContext _context;
        public ForumService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task Create(Forum forum)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int forumId)
        {
            throw new NotImplementedException();
        }

        public Forum GetById(int id)
        {
            var forum = _context.Forums.Where(f => f.Id == id)
                .Include(l => l.Images).Where(l => l.Images.Id == id)
                .FirstOrDefault();
                
            return forum;
        }

        public IEnumerable<Forum> GetFilteredForums(string searchQuery) =>
            GetAll().Where(p => p.Title.Contains(searchQuery) || p.Description.Contains(searchQuery));

        public IEnumerable<Forum> GetAll() =>
            _context.Forums.Include(l=>l.Images);


        public Task UpdateForumDescription(int forumId, string newDescription)
        {
            throw new NotImplementedException();
        }

        public Task UpdateForumTitle(int forumId, string newTitle)
        {
            throw new NotImplementedException();
        }

        public async Task Add(Forum forum)
        {
            _context.Add(forum);
            await _context.SaveChangesAsync();
        }
    }
}
