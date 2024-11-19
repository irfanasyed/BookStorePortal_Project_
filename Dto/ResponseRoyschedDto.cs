using System.ComponentModel.DataAnnotations;

namespace BookStorePortal_Project_.Dto
{
    public class ResponseRoyschedDto
    {
        [Required]
        public int Id { get; set; } // Unique identifier for the Roysched

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Title ID must be a positive integer.")]
        public int TitleId { get; set; } // Foreign Key for Title

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Low Range must be a non-negative number.")]
        public int LowRange { get; set; } // Minimum range for royalty

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "High Range must be greater than zero.")]
        public int HighRange { get; set; } // Maximum range for royalty

        [Required]
        [Range(0.01, 100.00, ErrorMessage = "Royalty percentage must be between 0.01 and 100.")]
        public decimal Royalty { get; set; } // Royalty percentage
    }
}
