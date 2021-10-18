using Microsoft.EntityFrameworkCore;

namespace beltexam.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}


        public DbSet<User> Users {get; set;}
        public DbSet<User> LoginUsers {get; set;}
        public DbSet<Hobby> Hobbies {get;set;}
        public DbSet<UserHob> UserHobs {get;set;}
    }
} 