using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeowBook.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MeowBook.Data
{
    public class MeowBookDbContext : IdentityDbContext<User>
    {
        public MeowBookDbContext(DbContextOptions<MeowBookDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<UserFriends>()
                .HasKey(uf => new { uf.UserId, uf.FriendId });

            builder.Entity<Meow>()
                .HasOne(m => m.User)
                .WithMany(u => u.Meows);

            builder.Entity<Meow>()
                .HasMany(m => m.Tags)
                .WithOne(t => t.Meow);

            builder.Entity<Meow>()
                .HasMany(m => m.Comments);

            builder.Entity<UserFriends>()
                .HasOne(u => u.User)
                .WithMany(u => u.AddedFriends)
                .HasForeignKey(f => f.UserId).OnDelete(DeleteBehavior.Restrict);

            builder.Entity<UserFriends>()
                .HasOne(u => u.Friend)
                .WithMany(u => u.AddedMeFriends)
                .HasForeignKey(f => f.FriendId);


        }
    }
}
