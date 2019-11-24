using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreToDo.Models;

namespace AspNetCoreToDo.Services
{
    public interface IToDoItemService
    {
        /// <summary>
        ///   Task returning ToDoItems will be fired asynchronously.
        ///   Tasks represent asynchronous jobs. These are run using 
        ///   threads from the thread pool.
        ///   Tasks can also be used to retrieve the results of these jobs.
        /// </summary>
        Task<ToDoItem[]> GetIncompleteItemsAsync();

        Task<bool> AddItemAsync(ToDoItem newItem);
    }
}