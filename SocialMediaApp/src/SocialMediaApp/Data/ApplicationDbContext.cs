using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialMediaApp.Models;

namespace SocialMediaApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<UserNotification> UserNotifications { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Discussion> Discussions { get; set; }
        public DbSet<Friend> Friends { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Define Entity Relationships
            builder.Entity<UserNotification>().HasKey(x => new { x.UserId, x.NotificationId });
            builder.Entity<ApplicationUser>().HasMany(u => u.Comments).WithOne(c => c.User);
            builder.Entity<ApplicationUser>().HasMany(u => u.Discussions).WithOne(d => d.User);
            builder.Entity<ApplicationUser>().HasMany(u => u.Friends).WithOne(f => f.UserFriend);
            builder.Entity<ApplicationUser>().HasMany(u => u.FriendsOfFriend).WithOne(f => f.User);
            builder.Entity<ApplicationUser>().HasMany(u => u.Messages).WithOne(m => m.FromUser);
            //builder.Entity<ApplicationUser>().HasMany(u => u.Messages).WithOne(m => m.ToUser);

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
