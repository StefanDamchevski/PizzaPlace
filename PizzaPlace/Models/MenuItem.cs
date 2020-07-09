using System;
using System.ComponentModel.DataAnnotations;

namespace PizzaPlace.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
    }
}
