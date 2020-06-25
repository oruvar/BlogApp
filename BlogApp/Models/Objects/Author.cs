using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogApp.Models.Objects
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Post> Post { get; set; }
    }
}
