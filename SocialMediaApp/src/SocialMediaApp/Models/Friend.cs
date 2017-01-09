using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaApp.Models
{
    public class Friend
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId"), InverseProperty("Friends")]
        public ApplicationUser User { get; set; }
        public string FriendId { get; set; }
        [ForeignKey("FriendId"), InverseProperty("FriendsOfFriend")]
        public ApplicationUser UserFriend { get; set; }
    }
}
