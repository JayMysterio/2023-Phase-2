﻿namespace Back_End.Models
{
    public class TodoList
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public ICollection<TodoItem> TodoItems { get; set; } = new List<TodoItem>();
    }
}
