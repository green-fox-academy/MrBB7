using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoDb.Models;

namespace TodoDb.TodoService
{
    public interface IRepository
    {
        void AddTodo(Todo todo);
        List<Todo> GetAllTodos();
        void EditTodo(Todo editedTodo);
        Todo GetTodo(long id);
        void Delete(int id);
        List<Todo> Filter(string filterWord);
    }
}
