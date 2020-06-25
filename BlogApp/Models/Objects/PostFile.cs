using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Models.Objects
{
    public class PostFile
    {
        [Key]
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FileExt { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }        
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
