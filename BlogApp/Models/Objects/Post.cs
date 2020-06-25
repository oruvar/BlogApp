using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogApp.Models.Objects
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Content { get; set; }
        public string ShortContent { get; set; }
        public string CoverImage { get; set; }
        public string Url { get; set; }
        public int Views { get; set; }
        public bool IsPublish { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;        
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public ICollection<PostCategory> PostCategories { get; set; }        
        public ICollection<RelatedPost> RelatedPosts { get; set; }        
        public ICollection<PostTag> PostTags { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<PostFile> Files { get; set; }
    }
}
