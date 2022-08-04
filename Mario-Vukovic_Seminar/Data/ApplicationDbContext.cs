using Mario_Vukovic_Seminar.Models.Dbo;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mario_Vukovic_Seminar.Data
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Roles

            builder.Entity<IdentityRole>().HasData
            (
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN", Id = "1" },
                new IdentityRole { Name = "BasicUser", NormalizedName = "BASICUSER", Id = "2" },
                new IdentityRole { Name = "Employee", NormalizedName = "EMPLOYEE", Id = "3" },
                new IdentityRole { Name = "Editor", NormalizedName = "EDITOR", Id = "4" }
            );

            #endregion

            #region Users

            var hasher = new PasswordHasher<ApplicationUser?>();

            builder.Entity<ApplicationUser>().HasData
            (
                new ApplicationUser
                {
                    Id = "1",
                    FirstName = "Admin",
                    UserName = "admin@admin.com",
                    NormalizedUserName = "admin@admin.com".ToUpper(),
                    Email = "admin@admin.com",
                    NormalizedEmail = "admin@admin.com".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin123"),
                },

                new ApplicationUser
                {
                    Id = "2",
                    FirstName = "BasicUser",
                    UserName = "user@user.com",
                    NormalizedUserName = "user@user.com".ToUpper(),
                    Email = "user@user.com",
                    NormalizedEmail = "user@user.com".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "User123")
                });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = "1"
                },

                new IdentityUserRole<string>
                {
                    RoleId = "2",
                    UserId = "2"
                });

            #endregion
            
            #region Categories

            builder.Entity<ProductCategory>().HasData(
                new ProductCategory
                {
                    Id = 1,
                    Title = "Winter shoes",
                    Description = "Shoes best worn during the winter to keep you warm"
                },
                new ProductCategory
                {
                    Id = 2,
                    Title = "Summer shoes",
                    Description = "Shoes best worn during the summer, although who am I to tell you what to do, if you want to be cold; You be cold"
                },
                new ProductCategory
                {
                    Id = 3,
                    Title = "Ugly shoes",
                    Description = "For some reason people thing these look good and won't stop wearing them. Fashion, wow."
                },
                new ProductCategory
                {
                    Id = 4,
                    Title = "Shoes I like",
                    Description = "I like black...that's it"
                },
                new ProductCategory
                {
                    Id = 5,
                    Title = "Shoes your mom wears",
                    Description = "Damn, those are big"
                });

            #endregion

            #region Products
            builder.Entity<Product>().HasData
            (
                new Product
                {
                    Id = 1,
                    Name = "Wonderful Winter Boots",
                    Description = "Brown, made of real deer skin, used to cut down tree the picture was taken on",
                    ProductCategoryId = 1,
                    Quantity = 19,
                    Price = 320,
                    ProductImgUrl = "https://www.hotter.com/blog/wp-content/uploads/2016/11/RUBY_SL-RT-300x200.jpg"
                },

                new Product
                {
                    Id = 2,
                    Name = "Rain and winter Boots",
                    Description = "Snow not included",
                    ProductCategoryId = 1,
                    Quantity = 7,
                    Price = 120,
                    ProductImgUrl = "https://capitaliron.ca/wp-content/uploads/2021/02/Boots-snow-300x200.jpeg"
                },

                new Product
                {
                    Id = 3,
                    Name = "Barefoot Winter Shoes",
                    Description = "I have no idea what this is, but it sure is stylish",
                    ProductCategoryId = 1,
                    Quantity = 1,
                    Price = 560,
                    ProductImgUrl = "https://lh4.googleusercontent.com/uKiSMORQwKFcFD6mmxTLQKOJYzDnfa1SI-t4kUkZU0ctklvkYovubYe8YlXhmBLCYwHaM0VBvTuD2j68ODBCanhIY_nJteVdkPl6CtfVV2QQUvTf3wa4nukJsuB0NHrQWezwFjRI"
                },

                new Product
                {
                    Id = 4,
                    Name = "Brown Summer Sandals",
                    Description = "Approved by the Saviour himself",
                    ProductCategoryId = 2,
                    Quantity = 67,
                    Price = 540,
                    ProductImgUrl = "https://i.ebayimg.com/thumbs/images/g/brcAAOSw9k5XQKi5/s-l300.jpg"
                },

                new Product
                {
                    Id = 5,
                    Name = "Bare feet",
                    Description = "It's free, just take your shoes off",
                    ProductCategoryId = 2,
                    Quantity = 999,
                    Price = 0,
                    ProductImgUrl = "https://images.squarespace-cdn.com/content/v1/5b6c9532cc8fed0c2edbc0cc/1562095212390-Y0VENOYPZFPWLUY24FDA/adult-bare-feet-barefoot-1249546.jpg"
                },

                new Product
                {
                    Id = 6,
                    Name = "Some sort of white shoes",
                    Description = "This is the first thing that appears when I google for 'summer shoes', you tell me",
                    ProductCategoryId = 2,
                    Quantity = 7,
                    Price = 90,
                    ProductImgUrl = "https://www.shoes.hr/site/assets/files/21725/carl-perf_mephisto_white_leather_shoe-sneaker_for_summer_for_men_perforated_5136957_3.300x0.jpg"
                },

                new Product
                {
                    Id = 7,
                    Name = "Timberlands",
                    Description = "Diarrhea coloured",
                    ProductCategoryId = 3,
                    Quantity = 35,
                    Price = 117,
                    ProductImgUrl = "https://i.ebayimg.com/thumbs/images/g/GwQAAOSwpOdi4qjF/s-l300.jpg"
                },

                new Product
                {
                    Id = 8,
                    Name = "Crocs",
                    Description = "Not actually made of crocodiles, surprisingly comfy",
                    ProductCategoryId = 3,
                    Quantity = 76,
                    Price = 220,
                    ProductImgUrl = "https://www.abcrafty.com/wp-content/uploads/2021/10/tie-dye-crocs_20-300x200.jpg"
                },

                new Product
                {
                    Id = 9,
                    Name = "Ugg Boots",
                    Description = "Pretty damn uggly",
                    ProductCategoryId = 3,
                    Quantity = 12,
                    Price = 780,
                    ProductImgUrl = "https://cdn.shopify.com/s/files/1/1327/1087/products/ugg-boots-ta-cadence-women-short-ugg-boots-inner-zipper-1_300x.jpg?v=1621910505"
                },

                new Product
                {
                    Id = 10,
                    Name = "Addidas black",
                    Description = "UltraBOOST, what does that even MEAN",
                    ProductCategoryId = 4,
                    Quantity = 51,
                    Price = 870,
                    ProductImgUrl = "https://mangosneakers.com/wp-content/uploads/2021/01/f5ffefac-300x200.jpg"
                },

                new Product
                {
                    Id = 11,
                    Name = "Allstar Converse Black",
                    Description = "Told you it's all black",
                    ProductCategoryId = 4,
                    Quantity = 14,
                    Price = 170,
                    ProductImgUrl = "https://repsneakers.net/wp-content/uploads/2021/01/bc31d3c0-300x200.jpg"
                },

                new Product
                {
                    Id = 12,
                    Name = "Nothing",
                    Description = "I don't really like anything else",
                    ProductCategoryId = 4,
                    Quantity = 42,
                    Price = 300,
                    ProductImgUrl = "https://conejovet.com/wp-content/uploads/2017/10/Blank-300x200-300x300.jpg"
                },

                new Product
                {
                    Id = 13,
                    Name = "Pink...shoes",
                    Description = "Perfect for the office Christmas party",
                    ProductCategoryId = 5,
                    Quantity = 22,
                    Price = 310,
                    ProductImgUrl = "https://static.vecteezy.com/system/resources/thumbnails/008/623/000/small/pair-of-female-natural-leather-shoe-hand-made-beige-medium-heel-shoes-decorated-with-wooden-element-women-s-shoes-concept-leather-high-quality-and-exclusive-footwear-photo.jpg"
                },

                new Product
                {
                    Id = 14,
                    Name = "Pink Nike Sneakers",
                    Description = "I've never actually seen anyone wear these",
                    ProductCategoryId = 5,
                    Quantity = 57,
                    Price = 30,
                    ProductImgUrl = "https://i.pinimg.com/564x/d3/f0/fe/d3f0fe393d619f2d87933afbf5623038.jpg"
                },

                new Product
                {
                    Id = 15,
                    Name = "IKona Sw005 Fawn",
                    Description = "I used to get my ass whopped by these",
                    ProductCategoryId = 5,
                    Quantity = 69,
                    Price = 420,
                    ProductImgUrl = "https://shoeslylo.pk/wp-content/uploads/2019/08/Buy-Beautiful-IKona-Sw005-Fawn-Color-Shoes-300x200.jpeg"
                });
            #endregion
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<FileStorage> FileStorage { get; set; }

    }
}