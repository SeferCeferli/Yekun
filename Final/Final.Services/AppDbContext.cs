using Final.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Final.Services
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Advertisment> Advertisment { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CustomUser> customUsers { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<NewsToTag> newsToTags { get; set; }
    }
}
