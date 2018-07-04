using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoDb.Models;
using TodoDb.Repositories;
using TodoDb.TodoService;

namespace TodoDb.Controllers
{
    public class TodoController : Controller
    {
        IRepository repository;

        public TodoController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("/")]
        [HttpGet("list")]
        public IActionResult List()
        {
            return View(repository.GetAllTodos());
        }

        [HttpPost("addtodo")]
        public IActionResult AddTodo(Todo todo)
        {
            repository.AddTodo(todo);
            return View("List", repository.GetAllTodos());
        }

        [HttpPost("delete")]
        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return View("List", repository.GetAllTodos());
        }
    }
}