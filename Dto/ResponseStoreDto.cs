﻿namespace BookStorePortal_Project_.Dto
{
    public class ResponseStoreDto
    {
        public int StorId { get; set; }
        public string? StorName { get; set; }
        public string? StorAddress { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public ICollection<ResponseSaleDto>? Sales { get; set; }
    }
}
