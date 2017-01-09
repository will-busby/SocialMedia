using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SocialMediaApp.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public ICollection<Friend> Friends { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Discussion> Discussions { get; set; }
        public ICollection<Friend> FriendsOfFriend { get; set; }
        public ICollection<UserNotification> UserNotifications { get; set; }
    }
}
