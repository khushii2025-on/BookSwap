using System.ComponentModel.DataAnnotations;

namespace BookSwap.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Book>? Books { get; set; }
    }
}