using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio1.Entities
{
    public class Comment
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string CommentCont { get; set; }
        public User User { get; set; }
    }
}
