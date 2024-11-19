using System.ComponentModel.DataAnnotations;

namespace BookStorePortal_Project_.Dto
{
    public class PatchPubInfoDto
    {
        [Required]
        public string? Logo { get; set; }

        [Required]
        public string? PrInfo { get; set; }
    }
}
