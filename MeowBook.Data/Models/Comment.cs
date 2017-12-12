using System;
using System.Collections.Generic;
using System.Text;

namespace MeowBook.Data.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public int MeowId { get; set; }
        public Meow Meow { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
