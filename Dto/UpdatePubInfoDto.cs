using System.ComponentModel.DataAnnotations;

namespace BookStorePortal_Project_.Dto
{
    public class UpdatePubInfoDto
    {
        [Required]
        public string? Logo { get; set; }

        [Required]
        public string? PrInfo { get; set; }
    }
}
