using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Data
{
    public class Forum
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string VideoUrl { get; set; }
        public string FileUrl { get; set; }
        public string ImageUrl { get; set; }
        public string Path { get; set; }
        public string Value { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateFinish { get; set; }
        public Image Images { get; set; }
    }
}
