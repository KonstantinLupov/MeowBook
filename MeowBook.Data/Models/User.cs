using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MeowBook.Data.Models
{
    // Add profile data for application users by adding properties to the User class
    public class User : IdentityUser
    {
        public List<Meow> Meows => new List<Meow>();
        public List<UserFriends> AddedFriends => new List<UserFriends>();
        public List<UserFriends> AddedMeFriends => new List<UserFriends>();
        public List<Comment> Comments => new List<Comment>();
    }
}
