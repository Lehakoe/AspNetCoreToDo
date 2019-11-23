using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTodo.Models 
{
    /// <summary>
    ///   This is a plain old C#/CLR object (POCO).
    ///   Represents what an entry/record in the db 
    ///   (whatever the database is) looks like in C#.
    /// </summary>
    public class TodoItem 
    {
        public Guid Id { get; set; }
        public bool IsDone { get; set; }

        [Required]
        public string Title { get; set; }
        public DateTimeOffset? DueAt { get; set; }
    }
}