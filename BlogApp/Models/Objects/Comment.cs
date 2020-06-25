using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogApp.Models.Objects
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
        public string Avatar { get; set; }
        public int PostId { get; set;}
        public Post Post { get; set; }
    }
}
