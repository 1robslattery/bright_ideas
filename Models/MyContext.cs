using Microsoft.EntityFrameworkCore;

namespace BrightIdeas.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }

		// 'Users, Ideas & Likes' are tables w/n MySQL ActivityCenter database.
		// 'User, Ideas & Likes' are also referenced from public class w/n their respective .cs files.
		public DbSet<User> Users {get; set;}
		public DbSet<Idea> Ideas {get; set;}
		
		public DbSet<Association> Associations {get; set;}
    }
}