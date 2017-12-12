using System;
using System.Collections.Generic;
using System.Text;

namespace MeowBook.Data.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int MeowId { get; set; }

        public Meow Meow { get; set; }
    }
}
