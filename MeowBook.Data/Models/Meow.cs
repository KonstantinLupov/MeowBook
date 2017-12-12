using System;
using System.Collections.Generic;
using System.Text;

namespace MeowBook.Data.Models
{
    public class Meow
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public List<Tag> Tags => new List<Tag>();
        public List<Comment> Comments => new List<Comment>();
    }
}
