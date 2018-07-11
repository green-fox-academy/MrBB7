using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoDb.Models
{
    public class Assignee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<Todo> Todos { get; set; }
    }
}
