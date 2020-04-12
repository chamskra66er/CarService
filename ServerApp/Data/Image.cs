using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Data
{
    public class Image
    {
        public int Id { get; set; }
        public int ForumId { get; set; }
        [Required]
        public string ImgUrl1 { get; set; }
        [Required]
        public string ImgUrl2 { get; set; }
        [Required]
        public string ImgUrl3 { get; set; }
        [Required]
        public string ImgUrl4 { get; set; }
    }
}
