using System;
using System.Collections.Generic;
using System.Text;
using BlogApp.Models.Objects;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<RelatedPost> RelatedPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Relation : Post->Author 1-n
            modelBuilder.Entity<Post>()
               .HasOne(p => p.Author)
               .WithMany(a => a.Post)
               .HasForeignKey(p => p.AuthorId);

            // Relation : Post->Commnet 1-n
            modelBuilder.Entity<Comment>()
               .HasOne(c => c.Post)
               .WithMany(p => p.Comments)
               .HasForeignKey(c => c.PostId);

            // Relation : Post->File 1-n
            modelBuilder.Entity<PostFile>()
               .HasOne(c => c.Post)
               .WithMany(p => p.Files)
               .HasForeignKey(c => c.PostId);

            // Relation : Post->Category n-n
            modelBuilder.Entity<PostCategory>()
                .HasKey(t => new { t.CategoryId, t.PostId });
            modelBuilder.Entity<PostCategory>()
               .HasOne(pc => pc.Post)
               .WithMany(p => p.PostCategories)
               .HasForeignKey(pc => pc.PostId);
            modelBuilder.Entity<PostCategory>()
               .HasOne(pc => pc.Category)
               .WithMany(p => p.PostCategories)
               .HasForeignKey(pc => pc.CategoryId);

            // Relation : Post->Tag n-n
            modelBuilder.Entity<PostTag>()
                .HasKey(t => new { t.TagId, t.PostId });
            modelBuilder.Entity<PostTag>()
                .HasOne(pt => pt.Post)
                .WithMany(p => p.PostTags)
                .HasForeignKey(pt => pt.PostId);
            modelBuilder.Entity<PostTag>()
                .HasOne(pt => pt.Tag)
                .WithMany(p => p.PostTags)
                .HasForeignKey(pt => pt.TagId);

            // Relation : Post->Commnet 1-n
            modelBuilder.Entity<RelatedPost>()
                .HasOne(c => c.Post)
                .WithMany(p => p.RelatedPosts)
                .HasForeignKey(c => c.PostId);
        }
    }
}
