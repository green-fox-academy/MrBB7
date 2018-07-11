using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoDb.Models;
using TodoDb.Repositories;

namespace TodoDb.TodoService
{
    public class AssigneeRepository : IGenericRepository<Assignee>
    {
        private TodoDbContext todoDbContext;

        public AssigneeRepository(TodoDbContext todoDbContext)
        {
            this.todoDbContext = todoDbContext;
        }

        public void Create(Assignee element)
        {
            throw new NotImplementedException();
        }

        public void Delete(Assignee element)
        {
            throw new NotImplementedException();
        }

        public List<Assignee> GetAllElements()
        {
            throw new NotImplementedException();
        }

        public void Update(Assignee element)
        {
            throw new NotImplementedException();
        }
    }
}
