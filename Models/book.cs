using System.ComponentModel.DataAnnotations;

namespace BookSwap.Models   
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(60)]
        public string Author { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string Condition { get; set; } = "Good";

        public bool IsAvailable { get; set; } = true;

        public int CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
