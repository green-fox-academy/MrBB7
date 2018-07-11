using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoDb.Models;

namespace TodoDb.TodoService
{
    public interface ITodoRepository
    {
        void AddTodo(Todo todo);
        List<Todo> GetAllTodos();
        void EditTodo(Todo editedTodo);
        Todo GetTodo(int id);
        void Delete(int id);
        List<Todo> Filter(string filterWord);
    }
}
