﻿using Common.Entities;
using LoginTemplate.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoginTemplate.DAL
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<OurVisionComponent> OurVisionComponents { get; set; }
        public DbSet<OurVision> OurVisions { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentComponent> DepartmentComponents { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Duty> Duties { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<WhyChoose> WhyChooses { get; set; }
        public DbSet<FAQCategory> FAQCategories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Medical> Medicals { get; set; }

    }
}
