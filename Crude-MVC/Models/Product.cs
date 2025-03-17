using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Crude_MVC.Models
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(100)] 
        public string Name { get; set; } = string.Empty;

        [Precision(16,2)]
        public decimal Price { get; set; }

        [MaxLength(500)] 
        public string Description { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
