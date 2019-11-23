using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreToDo.Services;
using AspNetCoreToDo.Models;

namespace AspNetCoreToDo.Controllers 
{
    public class ToDoController : Controller 
    {
        private readonly IToDoItemService _toDoItemService;

        public ToDoController(IToDoItemService toDoItemService)
        {
            _toDoItemService = toDoItemService;
        }

        /// <summary>Action methods can return views, JSON data or HTTP status codes.</summary>
        public async Task<IActionResult> Index () 
        {
            // Get to-do items from database
            /// <summary>
            ///   Making calls over networks or to a database takes time.
            ///   Make this call asynchronous as a result.
            /// </summary>
            var items = await _toDoItemService.GetIncompleteItemsAsync();

            // Put items into a (view) model
            var viewModel = new ToDoViewModel
            {
                Items = items
            };

            // Render view using the model
            /// <summary>Bind the model to the view.</summary>
            return View(viewModel);
        }
    }
}