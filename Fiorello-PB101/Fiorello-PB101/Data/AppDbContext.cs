﻿using Fiorello_PB101.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_PB101.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SlidersInfos { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Expert>Experts { get; set; }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Product>Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDeleted);

            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = 1,
                    Title = "Title1",
                    Description = "Reshadin Blogu",
                    Image = "blog-feature-img-1.jpg",
                    CreatedDate = DateTime.Now
                },
                new Blog
                {
                    Id = 2,
                    Title = "Title2",
                    Description = "Ilqarin Blogu",
                    Image = "blog-feature-img-3.jpg",
                    CreatedDate = DateTime.Now
                },
                new Blog
                {
                    Id = 3,
                    Title = "Title3",
                    Description = "Hacixanin Blogu",
                    Image = "blog-feature-img-4.jpg",
                    CreatedDate = DateTime.Now
                });

            modelBuilder.Entity<Expert>().HasData(
                new Expert
                {
                    Id = 1,
                    Name = "CRYSTAL BROOKS",
                    Image = "h3-team-img-1.png",
                    Position = "Florist"
                },
                new Expert
                {
                    Id = 2,
                    Name = "SHIRLEY HARRIS",
                    Image = "h3-team-img-2.png",
                    Position = "Manager"
                },
                 new Expert
                 {
                     Id = 3,
                     Name = "BEVERLY CLARK",
                     Image = "h3-team-img-3.png",
                     Position = "Florist"
                 },
                  new Expert
                  {
                      Id = 4,
                      Name = "AMANDA WATKINS",
                      Image = "h3-team-img-4.png",
                      Position = "Florist"
                  });

        }

    }
}
