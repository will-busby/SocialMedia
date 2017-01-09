using SocialMediaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaApp.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public ICollection<UserNotification> UserNotifications { get; set; }
    }
}
