using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreToDo.Data;
using AspNetCoreToDo.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreToDo.Services
{
    public class ToDoItemService : IToDoItemService
    {
        private readonly ApplicationDbContext _context;
        public ToDoItemService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ToDoItem[]> GetIncompleteItemsAsync()
        {
            return await _context.Items
            .Where(x => x.IsDone == false)
            .ToArrayAsync();
        }

        public async Task<bool> AddItemAsync(ToDoItem newItem)
        {
            newItem.Id = Guid.NewGuid();
            newItem.IsDone = false;
            newItem.DueAt = DateTimeOffset.Now.AddDays(3);
            _context.Items.Add(newItem);
            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }
    }
}