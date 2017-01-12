using SocialMediaApp.Data;
using SocialMediaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaApp.Infrastructure
{
    public class CommentRepository : GenericRepository<Comment>
    {
        public CommentRepository(ApplicationDbContext db) : base(db) { }
    }
}
