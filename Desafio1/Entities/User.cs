using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio1.Entities
{
    public class User

    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Password { get; set; }
        public string Email { get; set; }
        public ICollection<Posteo> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
