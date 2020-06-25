using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Models.Objects
{
    public class PostCategory
    {        
        public int CategoryId { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public Category Category { get; set; }
    }
}
