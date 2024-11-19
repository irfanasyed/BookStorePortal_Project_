﻿using System.ComponentModel.DataAnnotations;

namespace BookStorePortal_Project_.Dto
{
    public class CreateRoyschedDto
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Title ID must be a positive integer.")]
        public int TitleId { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Low Range must be a non-negative number.")]
        public int LowRange { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "High Range must be greater than zero.")]
        public int HighRange { get; set; }

        [Required]
        [Range(0.01, 100.00, ErrorMessage = "Royalty must be between 0.01 and 100.")]
        public decimal Royalty { get; set; }
    }
}

