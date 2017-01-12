using SocialMediaApp.Data;
using SocialMediaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaApp.Infrastructure
{
    public class DiscussionRepository: GenericRepository<Discussion>
    {
        public DiscussionRepository(ApplicationDbContext db): base(db) { }
    }
}
