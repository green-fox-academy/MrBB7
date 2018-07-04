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

        [HttpGet("filter")]
        public IActionResult List([FromQuery]string filterWord)
        {
            return View("List", repository.Filter(filterWord).ToList());
        }

        [HttpGet("edittodo")]
        public ActionResult EditTodo(long id)
        { 
            return View("EditTodo", repository.GetTodo(id));
        }

        [HttpPost("edittodo")]
        public ActionResult EditTodo(Todo editedTodo)
        {
            repository.EditTodo(editedTodo);
            return View("List", repository.GetAllTodos());
        }
    }
}
