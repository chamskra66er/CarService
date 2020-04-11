using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Data
{
    public class Forum
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string VideoUrl { get; set; }
        public string FileUrl { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public string Path { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Value must be at least 1")]
        public string Value { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateFinish { get; set; }
        [Required]
        public Image Images { get; set; }
    }
}
