using System.ComponentModel.DataAnnotations;

namespace BookStorePortal_Project_.Dto
{
    public class CreatePubInfoDto
    {
        [Required]
        public string? Logo { get; set; }

        [Required]
        public string? PrInfo { get; set; }
    }
}
