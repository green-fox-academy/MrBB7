using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoDb.Models;
using TodoDb.TodoService;

namespace TodoDb.Repositories
{
    public class TodoRepository : IRepository
    {
        private TodoDbContext todoDbContext;
        public TodoRepository(TodoDbContext todoDbContext)
        {
            this.todoDbContext = todoDbContext;
        }

        public List<Todo> GetAllTodos()
        {
            return todoDbContext.Todos.ToList();
        }

        public void AddTodo(Todo todo)
        {
            todoDbContext.Add(todo);
            todoDbContext.SaveChanges();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            Todo todo = todoDbContext.Todos.FirstOrDefault(x => x.Id == id);
            todoDbContext.Remove(todo);
            todoDbContext.SaveChanges();
        }

        public List<Todo> Search(string word)
        {
            throw new NotImplementedException();
        }
    }
}
