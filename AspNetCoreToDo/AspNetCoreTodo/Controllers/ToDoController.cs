using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTodo.Controllers 
{
    public class ToDoController : Controller 
    {
        /// <summary>Action methods can return views, JSON data or HTTP status codes.</summary>
        public IActionResult Index () 
        {
            // Get to-do items from database
            // Put items into a model
            // Render view using the model
            return null;
        }
    }
}