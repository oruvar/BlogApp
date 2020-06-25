using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogApp.Models.Objects
{
    public class RelatedPost
    {
        [Key]
        public int Id { get; set; }
        public int PostId { get; set; }
        public int RelatedId { get; set; }

        public Post Post { get; set; }

    }
}
