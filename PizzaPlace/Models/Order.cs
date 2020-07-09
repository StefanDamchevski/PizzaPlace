﻿using System.ComponentModel.DataAnnotations;

namespace PizzaPlace.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public bool IsProccessed { get; set; }
        [Required]
        public bool IsDelivered { get; set; }
    }
}
