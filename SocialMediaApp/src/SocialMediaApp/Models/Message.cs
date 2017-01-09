using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaApp.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public string ToUserId { get; set; }
        [ForeignKey("ToUserId")]
        public ApplicationUser ToUser { get; set; }
        public DateTime DateTime { get; set; }
        public string FromUserId { get; set; }
        [ForeignKey("FromUserId")]
        public ApplicationUser FromUser { get; set; }
    }
}
