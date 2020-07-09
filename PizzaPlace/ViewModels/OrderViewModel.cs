using System.ComponentModel.DataAnnotations;

namespace PizzaPlace.ViewModels
{
    public class OrderViewModel
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
        public bool IsProccessed { get; set; }
        public bool IsDelivered { get; set; }
    }
}
