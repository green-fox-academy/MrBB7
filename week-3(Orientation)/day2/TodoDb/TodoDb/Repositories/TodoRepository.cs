using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
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

        public void EditTodo(Todo editedTodo)
        {
            todoDbContext.Update(editedTodo);
            todoDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Todo todo = todoDbContext.Todos.FirstOrDefault(x => x.Id == id);
            todoDbContext.Remove(todo);
            todoDbContext.SaveChanges();
        }

        public Todo GetTodo(long id)
        {
            return todoDbContext.Todos.Where(t => t.Id == id).SingleOrDefault();
        }

        public List<Todo> Filter(string filterWord)
        {
            List<Todo> filteredTodo = todoDbContext.Todos.Where(x => x.Title.ToLower().Contains(filterWord.ToLower())).ToList();
            todoDbContext.SaveChanges();
            return filteredTodo;
        }
    }
}
