﻿using System.ComponentModel.DataAnnotations;

namespace BookStorePortal_Project_.Dto
{
    public class ResponseAuthorDto
    {
        [Key]
        public int AuId {  get; set; }
        [Required]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "Name should contain more than 4 characters")]
        public string AuLname { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "Name should contain more than 4 characters")]
        public string AuFname { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Address cannot exist more than 50 characters")]
        public string Address { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "city should contain within 20 characters")]
        public string City { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "state should contain within 20 characters")]
        public string State { get; set; }
        [Required]
        [StringLength(7, MinimumLength = 6, ErrorMessage = "Zip should contain within 7 characters")]
        public string Zip { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "contract should contain within 20 characters")]
        public string Contract { get; set; }
    }
}
