﻿using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }
        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }
    }
}
