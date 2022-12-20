using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ForumProjectBL.Entities;

namespace ForumProjectDAL
{
    public class ForumProjectDbContext : IdentityDbContext<User>
    {
        public DbSet<Discussion>? Discussions { get; set; }
        public DbSet<Message>? Messages { get; set; }
        public DbSet<Profile>? Profiles { get; set; }
        public DbSet<Question>? Questions { get; set; }
        public DbSet<Reply>? Replies { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<Signature>? Signatures { get; set; }
        public DbSet<Theme>? Themes { get; set; }
        public override DbSet<User>? Users { get; set; }

        public ForumProjectDbContext(DbContextOptions<ForumProjectDbContext> options) : base(options)
        {
        }
    }
}
