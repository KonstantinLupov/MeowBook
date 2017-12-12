using System;
using System.Collections.Generic;
using System.Text;

namespace MeowBook.Data.Models
{
    public class UserFriends
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public string FriendId { get; set; }
        public User Friend { get; set; }
    }
}
